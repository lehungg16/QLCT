using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class ucDashboard : UserControl
    {
        private readonly string connectionString = @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
        public ucDashboard()
        {
            InitializeComponent();
        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // ==================== TẢI DỮ LIỆU DASHBOARD ====================
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Tổng Thu Nhập
                    string sqlThu = @"SELECT ISNULL(SUM(SoTien), 0) 
                                    FROM GiaoDich 
                                    WHERE LoaiGiaoDich = N'Thu Nhập'";

                    // 2. Tổng Chi Tiêu
                    string sqlChi = @"SELECT ISNULL(SUM(SoTien), 0) 
                                    FROM GiaoDich 
                                    WHERE LoaiGiaoDich = N'Chi Tiêu'";

                    decimal tongThu = 0, tongChi = 0;

                    using (SqlCommand cmd = new SqlCommand(sqlThu, conn))
                    {
                        tongThu = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
                    }

                    using (SqlCommand cmd = new SqlCommand(sqlChi, conn))
                    {
                        tongChi = Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
                    }

                    decimal soDu = tongThu - tongChi;

                    /* * 3. Hiển thị tổng thu nhập, tổng chi tiêu, số dư hiện tại lên label
                     * 4. Định dạng số tiền (định dạng tiền tệ, căn phải)
                     * 5. Màu xanh nếu số dư >= 0, màu đỏ nếu số dư < 0
                     */
                    lblTongThuNhap.Text = tongThu.ToString("#,##0") + " ₫";
                    lblTongChiTieu.Text = tongChi.ToString("#,##0") + " ₫";
                    lblSoDuHienTai.Text = soDu.ToString("#,##0") + " ₫";

                    lblSoDuHienTai.ForeColor = soDu >= 0 ? Color.Green : Color.Red;

                    // Load biểu đồ và giao dịch gần đây
                    LoadChartThang(conn);
                    LoadRecentTransactions(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Dashboard:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== BIỂU ĐỒ THEO THÁNG ====================
        private void LoadChartThang(SqlConnection conn)
        {
            try
            {
                string sqlChart = @"
                    SELECT 
                        FORMAT(NgayGiaoDich, 'MM/yyyy') AS ThangNam,
                        SUM(CASE WHEN LoaiGiaoDich = N'Thu Nhập' THEN SoTien ELSE 0 END) AS ThuNhap,
                        SUM(CASE WHEN LoaiGiaoDich = N'Chi Tiêu' THEN SoTien ELSE 0 END) AS ChiTieu
                    FROM GiaoDich
                    WHERE NgayGiaoDich >= DATEADD(MONTH, -6, GETDATE())
                    GROUP BY FORMAT(NgayGiaoDich, 'MM/yyyy')
                    ORDER BY ThangNam";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlChart, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    chartThuchi.DataSource = dt;
                    chartThuchi.Series.Clear();

                    // Series Thu Nhập
                    var seriesThu = chartThuchi.Series.Add("Thu Nhập");
                    seriesThu.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    seriesThu.Color = Color.FromArgb(40, 167, 69);
                    seriesThu.IsValueShownAsLabel = true;

                    // Series Chi Tiêu
                    var seriesChi = chartThuchi.Series.Add("Chi Tiêu");
                    seriesChi.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    seriesChi.Color = Color.FromArgb(220, 53, 69);
                    seriesChi.IsValueShownAsLabel = true;

                    chartThuchi.DataBind();
                }
            }
            catch
            {
                // Bỏ qua lỗi nếu chưa có dữ liệu hoặc chart chưa thiết kế
            }
        }

        // ==================== GIAO DỊCH GẦN ĐÂY ====================
        private void LoadRecentTransactions(SqlConnection conn)
        {
            try
            {
                string sqlRecent = @"
                    SELECT TOP 8 
                        NgayGiaoDich AS [Ngày],
                        LoaiGiaoDich AS [Loại],
                        TenDanhMuc AS [Danh mục],
                        SoTien AS [Số tiền],
                        MoTa AS [Mô tả]
                    FROM GiaoDich g
                    JOIN DanhMuc dm ON g.MaDanhMuc = dm.MaDanhMuc
                    ORDER BY g.NgayGiaoDich DESC, g.MaGiaoDich DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(sqlRecent, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRecentTransactions.DataSource = dt;

                    // Định dạng cột Số tiền
                    if (dgvRecentTransactions.Columns["Số tiền"] != null)
                    {
                        dgvRecentTransactions.Columns["Số tiền"].DefaultCellStyle.Format = "#,##0 ₫";
                        dgvRecentTransactions.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm giao dịch sẽ được làm ở phần sau.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }

}
