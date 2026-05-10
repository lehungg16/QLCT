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
using System.Windows.Forms.DataVisualization.Charting;
using ClosedXML.Excel;
using System.IO;

namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class ucBaoCao : UserControl
    {
        private readonly string connectionString = ConnectionHelper.ConnectionString;
        public ucBaoCao()
        {
            InitializeComponent();
        }
        private void ucBaoCao_Load_1(object sender, EventArgs e)
        {
            LoadBaoCaoTheoThang();
            LoadChiTietGiaoDich();
        }
        // ====================== BÁO CÁO THEO THÁNG (BIỂU ĐỒ + TỔNG) ======================
        private void LoadBaoCaoTheoThang()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            FORMAT(NgayGiaoDich, 'MM/yyyy') AS ThangNam,
                            SUM(CASE WHEN LoaiGiaoDich = N'Thu Nhập' THEN SoTien ELSE 0 END) AS TongThu,
                            SUM(CASE WHEN LoaiGiaoDich = N'Chi Tiêu' THEN SoTien ELSE 0 END) AS TongChi,
                            SUM(CASE WHEN LoaiGiaoDich = N'Thu Nhập' THEN SoTien ELSE -SoTien END) AS SoDu
                        FROM GiaoDich
                        WHERE NgayGiaoDich >= DATEADD(MONTH, -12, GETDATE())
                        GROUP BY FORMAT(NgayGiaoDich, 'MM/yyyy')
                        ORDER BY ThangNam";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind vào DataGridView (nếu bạn có dgvBaoCao)
                        if (dgvBaoCao != null)
                            dgvBaoCao.DataSource = dt;

                        // Vẽ biểu đồ
                        if (chartBaoCao != null)
                        {
                            chartBaoCao.DataSource = dt;
                            chartBaoCao.Series.Clear();

                            // Series Thu Nhập
                            Series seriesThu = chartBaoCao.Series.Add("Thu Nhập");
                            seriesThu.ChartType = SeriesChartType.Column;
                            seriesThu.Color = Color.FromArgb(40, 167, 69);
                            seriesThu.IsValueShownAsLabel = true;
                            seriesThu.XValueMember = "ThangNam";
                            seriesThu.YValueMembers = "TongThu";

                            // Series Chi Tiêu
                            Series seriesChi = chartBaoCao.Series.Add("Chi Tiêu");
                            seriesChi.ChartType = SeriesChartType.Column;
                            seriesChi.Color = Color.FromArgb(220, 53, 69);
                            seriesChi.IsValueShownAsLabel = true;
                            seriesChi.XValueMember = "ThangNam";
                            seriesChi.YValueMembers = "TongChi";

                            chartBaoCao.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo theo tháng:\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================== CHI TIẾT GIAO DỊCH ======================
        private void LoadChiTietGiaoDich()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT TOP 50
                            g.MaGiaoDich AS [Mã GD],
                            g.NgayGiaoDich AS [Ngày],
                            g.LoaiGiaoDich AS [Loại],
                            dm.TenDanhMuc AS [Danh mục],
                            g.SoTien AS [Số tiền],
                            g.MoTa AS [Mô tả]
                        FROM GiaoDich g
                        JOIN DanhMuc dm ON g.MaDanhMuc = dm.MaDanhMuc
                        ORDER BY g.NgayGiaoDich DESC, g.MaGiaoDich DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dgvChiTiet != null)
                            dgvChiTiet.DataSource = dt;
                    }

                    // Định dạng cột Số tiền
                    FormatSoTienColumn(dgvChiTiet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết giao dịch:\n" + ex.Message);
            }
        }

        private void FormatSoTienColumn(DataGridView dgv)
        {
            if (dgv == null) return;

            if (dgv.Columns["Số tiền"] != null)
            {
                dgv.Columns["Số tiền"].DefaultCellStyle.Format = "#,##0 ₫";
                dgv.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        // ====================== NÚT LÀM MỚI ======================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBaoCaoTheoThang();
            LoadChiTietGiaoDich();
        }

        // ====================== NÚT XUẤT EXCEL (cơ bản) ======================
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvChiTiet.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để xuất!");
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Files|*.xlsx";
                    sfd.Title = "Lưu file Excel";
                    sfd.FileName = "BaoCao.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            // Sheet 1: Chi tiết giao dịch
                            var ws1 = wb.Worksheets.Add("ChiTiet");

                            // Tìm cột "Số lượng"
                            int soLuongCol = -1;
                            for (int i = 0; i < dgvChiTiet.Columns.Count; i++)
                            {
                                if (dgvChiTiet.Columns[i].HeaderText == "Số lượng")
                                {
                                    soLuongCol = i + 1;
                                    break;
                                }
                            }

                            if (soLuongCol != -1)
                            {
                                int lastRow = dgvChiTiet.Rows.Count + 1;

                                ws1.Cell(lastRow + 1, soLuongCol - 1).Value = "Tổng:";
                                ws1.Cell(lastRow + 1, soLuongCol).FormulaA1 =
                                    $"SUM({ws1.Cell(2, soLuongCol).Address}:{ws1.Cell(lastRow, soLuongCol).Address})";
                            }

                            for (int i = 0; i < dgvChiTiet.Columns.Count; i++)
                            {
                                ws1.Cell(1, i + 1).Value = dgvChiTiet.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dgvChiTiet.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvChiTiet.Columns.Count; j++)
                                {
                                    ws1.Cell(i + 2, j + 1).Value = dgvChiTiet.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // Sheet 2: Báo cáo tháng
                            var ws2 = wb.Worksheets.Add("BaoCaoThang");

                            for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                            {
                                ws2.Cell(1, i + 1).Value = dgvBaoCao.Columns[i].HeaderText;
                            }

                            for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                                {
                                    ws2.Cell(i + 2, j + 1).Value = dgvBaoCao.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            string filePath = sfd.FileName;

                            // Nếu file đã tồn tại thì thêm (1), (2)...
                            if (File.Exists(filePath))
                            {
                                string directory = Path.GetDirectoryName(filePath);
                                string fileName = Path.GetFileNameWithoutExtension(filePath);
                                string extension = Path.GetExtension(filePath);

                                int count = 1;

                                while (File.Exists(filePath))
                                {
                                    filePath = Path.Combine(directory,
                                        $"{fileName} ({count}){extension}");
                                    count++;
                                }
                            }

                            wb.SaveAs(filePath);
                        }

                        MessageBox.Show("Xuất Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message);
            }
        }
        // ===================== NÚT IN BÁO CÁO ================================
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
