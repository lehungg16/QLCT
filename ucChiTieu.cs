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
    public partial class ucChiTieu : UserControl
    {
        private readonly string connectionString =
            @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
        public ucChiTieu()
        {
            InitializeComponent();
        }

        private void ucChiTieu_Load(object sender, EventArgs e)
        {
            LoadDataChiTieu();
        }

        // ==================== TẢI DỮ LIỆU CHI TIÊU ====================
        private void LoadDataChiTieu()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            g.MaGiaoDich AS [Mã GD],
                            g.NgayGiaoDich AS [Ngày],
                            dm.TenDanhMuc AS [Danh mục],
                            g.SoTien AS [Số tiền],
                            g.MoTa AS [Mô tả],
                            g.NgayTao AS [Thời gian tạo]
                        FROM GiaoDich g
                        JOIN DanhMuc dm ON g.MaDanhMuc = dm.MaDanhMuc
                        WHERE g.LoaiGiaoDich = N'Chi Tiêu'
                        ORDER BY g.NgayGiaoDich DESC, g.MaGiaoDich DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvChiTieu.DataSource = dt;
                    }

                    // Tính tổng chi tiêu
                    string sqlTong = @"SELECT ISNULL(SUM(SoTien), 0) 
                                     FROM GiaoDich 
                                     WHERE LoaiGiaoDich = N'Chi Tiêu'";

                    using (SqlCommand cmd = new SqlCommand(sqlTong, conn))
                    {
                        decimal tongChi = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTongChiTieu.Text = tongChi.ToString("#,##0") + " ₫";
                    }

                    // Định dạng cột Số tiền
                    if (dgvChiTieu.Columns["Số tiền"] != null)
                    {
                        dgvChiTieu.Columns["Số tiền"].DefaultCellStyle.Format = "#,##0 ₫";
                        dgvChiTieu.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvChiTieu.Columns["Số tiền"].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Chi Tiêu:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== NÚT LÀM MỚI ====================
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataChiTieu();
        }

        // ==================== NÚT THÊM CHI TIÊU ====================
        private void btnThemChiTieu_Click(object sender, EventArgs e)
        {
            ThemGiaoDich frm = new ThemGiaoDich("Chi Tiêu", 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataChiTieu();
            }
        }

        // ==================== NÚT SỬA ====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần sửa!", "Thông báo");
                return;
            }

            int maGiaoDich = Convert.ToInt32(dgvChiTieu.CurrentRow.Cells["Mã GD"].Value);

            ThemGiaoDich frm = new ThemGiaoDich("Chi Tiêu", maGiaoDich);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataChiTieu();
            }
        }

        // ==================== NÚT XÓA ====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTieu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int maGiaoDich = Convert.ToInt32(dgvChiTieu.CurrentRow.Cells["Mã GD"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM GiaoDich WHERE MaGiaoDich = @MaGiaoDich";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaGiaoDich", maGiaoDich);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadDataChiTieu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void lblTongChiTieu_Click(object sender, EventArgs e)
        {

        }
    }
}
