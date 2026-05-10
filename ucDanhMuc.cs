using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class ucDanhMuc : UserControl
    {
        private readonly string connectionString =
            @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";

        public ucDanhMuc()
        {
            InitializeComponent();
        }

        private void ucDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDataDanhMuc();
        }

        // ==================== TẢI DỮ LIỆU DANH MỤC ====================
        private void LoadDataDanhMuc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = @"
                        SELECT 
                            MaDanhMuc AS [Mã DM],
                            TenDanhMuc AS [Tên danh mục],
                            LoaiDanhMuc AS [Loại],
                            NgayTao AS [Ngày tạo]
                        FROM DanhMuc
                        ORDER BY LoaiDanhMuc, TenDanhMuc";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDanhMuc.DataSource = dt;
                    }

                    // Định dạng cột
                    if (dgvDanhMuc.Columns["Mã DM"] != null)
                    {
                        dgvDanhMuc.Columns["Mã DM"].Width = 80;
                    }

                    if (dgvDanhMuc.Columns["Tên danh mục"] != null)
                    {
                        dgvDanhMuc.Columns["Tên danh mục"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu Danh Mục:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== NÚT THÊM DANH MỤC ====================
        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            using (var frm = new ThemDanhMuc("0")) // "0" = thêm mới
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataDanhMuc();
                }
            }
        }

        // ==================== NÚT SỬA ====================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần sửa!", "Thông báo");
                return;
            }

            int maDanhMuc = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["Mã DM"].Value);

            using (var frm = new ThemDanhMuc(maDanhMuc.ToString()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadDataDanhMuc();
                }
            }
        }

        // ==================== NÚT XÓA ====================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa!", "Thông báo");
                return;
            }

            string tenDanhMuc = dgvDanhMuc.CurrentRow.Cells["Tên danh mục"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục '{tenDanhMuc}'?\n\nLưu ý: Danh mục đang được sử dụng sẽ không thể xóa.",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int maDanhMuc = Convert.ToInt32(dgvDanhMuc.CurrentRow.Cells["Mã DM"].Value);

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa danh mục thành công!", "Thành công");
                                LoadDataDanhMuc();
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa danh mục này vì đang có giao dịch liên quan.",
                                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa danh mục: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void lblnameDanhMuc_Click(object sender, EventArgs e)
        {
        }

        
    }
}