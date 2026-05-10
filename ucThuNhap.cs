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
    public partial class ucThuNhap : UserControl
    {
        private readonly string connectionString =
            @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";
        public ucThuNhap()
        {
            InitializeComponent();
        }

        private void ucThuNhap_Load(object sender, EventArgs e)
        {
            /* * 1. Load dữ liệu giao dịch Thu Nhập lên DataGridView
             * 2. Tính tổng thu nhập và hiển thị lên label
             * 3. Định dạng cột Số tiền (định dạng tiền tệ, căn phải, màu xanh)
             */
                LoadDataThuNhap();
        }

        // ==================== TẢI DỮ LIỆU THU NHẬP ====================
        private void LoadDataThuNhap()
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
                            dm.MaDanhMuc AS [Danh mục],
                            g.SoTien AS [Số tiền],
                            g.MoTa AS [Mô tả],
                            g.NgayTao AS [Thời gian tạo]
                        FROM GiaoDich g
                        JOIN DanhMuc dm ON g.MaDanhMuc = dm.MaDanhMuc
                        WHERE g.LoaiGiaoDich = N'Thu Nhập'
                        ORDER BY g.NgayGiaoDich DESC, g.MaGiaoDich DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvThuNhap.DataSource = dt;
                    }

                    // Tính tổng thu nhập
                    string sqlTong = @"SELECT ISNULL(SUM(SoTien), 0) 
                                     FROM GiaoDich 
                                     WHERE LoaiGiaoDich = N'Thu Nhập'";

                    using (SqlCommand cmd = new SqlCommand(sqlTong, conn))
                    {
                        decimal tongThu = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTongThuNhap.Text = tongThu.ToString("#,##0") + " ₫";
                    }

                    // Định dạng cột Số tiền
                    if (dgvThuNhap.Columns["Số tiền"] != null)
                    {
                        dgvThuNhap.Columns["Số tiền"].DefaultCellStyle.Format = "#,##0 ₫";
                        dgvThuNhap.Columns["Số tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvThuNhap.Columns["Số tiền"].DefaultCellStyle.ForeColor = Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Thu Nhập:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ==================== NÚT THÊM THU NHẬP ====================
        private void btnThemThuNhap_Click_1(object sender, EventArgs e)
        {
            // Mở form thêm giao dịch với loại mặc định là Thu Nhập
            ThemGiaoDich frm = new ThemGiaoDich("Thu Nhập", 0);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataThuNhap();        // Load lại dữ liệu sau khi thêm
            }
        }

        // ==================== NÚT SỬA ====================
        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dgvThuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần sửa!", "Thông báo");
                return;
            }

            int maGiaoDich = Convert.ToInt32(dgvThuNhap.CurrentRow.Cells["Mã GD"].Value);

            ThemGiaoDich frm = new ThemGiaoDich("Thu Nhập", maGiaoDich);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataThuNhap();
            }
        }

        // ==================== NÚT XÓA ====================
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvThuNhap.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa!", "Thông báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int maGiaoDich = Convert.ToInt32(dgvThuNhap.CurrentRow.Cells["Mã GD"].Value);

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
                    LoadDataThuNhap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }

            }
        }
    }
}
