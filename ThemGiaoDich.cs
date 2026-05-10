using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class ThemGiaoDich : Form
    {
        private readonly string connectionString =
            @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;" +
            "Trusted_Connection=True;TrustServerCertificate=True;" +
            "MultipleActiveResultSets=True;";

        private string _type;   // "Thu Nhập" | "Chi Tiêu" | "" (chọn từ form)
        private int _id;     // MaNguoiDung đang đăng nhập
      

        // ─── Constructor gọi từ Dashboard ──────────────────────────────────
        public ThemGiaoDich(string type, int id)
        {
            InitializeComponent();
            _type = type;
            _id = id;
        }

        // ═══════════════════════════════════════════════════════════════════
        //  LOAD FORM
        // ═══════════════════════════════════════════════════════════════════
        private void ThemGiaoDich_Load(object sender, EventArgs e)
        {
            // Ngày mặc định = hôm nay
            dtpNgay.Value = DateTime.Today;

            // Nếu type đã được truyền vào thì khoá ComboBox lại
            if (!string.IsNullOrEmpty(_type))
            {
                cmbLoai.SelectedItem = _type;
                cmbLoai.Enabled = false;
            }

            LoadTaiKhoan();
            LoadDanhMuc();
        }

        // ─── Tải danh sách tài khoản của người dùng ────────────────────────
        private void LoadTaiKhoan()
        {
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                string sql = @"
                    SELECT MaTaiKhoan,
                           TenTaiKhoan + ' (' + LoaiTaiKhoan + ')' AS HienThi
                    FROM   TaiKhoan
                    WHERE  MaNguoiDung = @uid
                    ORDER  BY TenTaiKhoan";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", _id);

                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                cmbTaiKhoan.DataSource = dt;
                cmbTaiKhoan.DisplayMember = "HienThi";
                cmbTaiKhoan.ValueMember = "MaTaiKhoan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải tài khoản:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Tải danh mục theo loại giao dịch ─────────────────────────────
        private void LoadDanhMuc()
        {
            string loai = cmbLoai.SelectedItem?.ToString() ?? "";

            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Lấy danh mục theo LoaiDanhMuc phù hợp với loại giao dịch
                // hoặc lấy tất cả nếu chưa chọn loại
                string sql = string.IsNullOrEmpty(loai)
                    ? @"SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc
                        WHERE (MaNguoiDung = @uid OR MaNguoiDung IS NULL)
                        ORDER BY TenDanhMuc"
                    : @"SELECT MaDanhMuc, TenDanhMuc FROM DanhMuc
                        WHERE LoaiDanhMuc = @loai
                          AND (MaNguoiDung = @uid OR MaNguoiDung IS NULL)
                        ORDER BY TenDanhMuc";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", _id);
                if (!string.IsNullOrEmpty(loai))
                    cmd.Parameters.AddWithValue("@loai", loai);

                var dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                cmbDanhMuc.DataSource = dt;
                cmbDanhMuc.DisplayMember = "TenDanhMuc";
                cmbDanhMuc.ValueMember = "MaDanhMuc";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Khi đổi loại giao dịch → reload danh mục ─────────────────────
        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDanhMuc();
            UpdateSoTienLabel();
        }

        // ─── Màu nhãn số tiền theo loại ────────────────────────────────────
        private void UpdateSoTienLabel()
        {
            lblSoTien.ForeColor = cmbLoai.SelectedItem?.ToString() == "Thu Nhập"
                ? Color.FromArgb(40, 167, 69)
                : Color.FromArgb(220, 53, 69);
        }

        // ═══════════════════════════════════════════════════════════════════
        //  LƯU GIAO DỊCH
        // ═══════════════════════════════════════════════════════════════════
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ── Validate ────────────────────────────────────────────────────
            if (cmbLoai.SelectedItem == null)
            { ShowWarn("Vui lòng chọn loại giao dịch."); cmbLoai.Focus(); return; }

            if (cmbDanhMuc.SelectedValue == null)
            { ShowWarn("Vui lòng chọn danh mục."); cmbDanhMuc.Focus(); return; }

            if (!decimal.TryParse(txtSoTien.Text.Replace(",", "").Replace(".", ""),
                    out decimal soTien) || soTien <= 0)
            { ShowWarn("Số tiền không hợp lệ. Nhập số dương."); txtSoTien.Focus(); return; }

            // ── Insert ──────────────────────────────────────────────────────
            try
            {
                using var conn = new SqlConnection(connectionString);
                conn.Open();

                // Xác định NgayGiaoDich
                DateTime ngay = dtpNgay.Value.Date;

                // Lấy MaTaiKhoan đã chọn (nullable)
                int? maTK = null;
                if (cmbTaiKhoan.SelectedValue is int tk && tk > 0)
                    maTK = tk;

                string sql = @"
                    INSERT INTO GiaoDich
                        (MaNguoiDung, NgayGiaoDich, LoaiGiaoDich,
                         MaDanhMuc, SoTien, MoTa, GhiChu)
                    VALUES
                        (@uid, @ngay, @loai,
                         @maDanhMuc, @soTien, @moTa, @ghiChu)";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", _id);
                cmd.Parameters.AddWithValue("@ngay", ngay);
                cmd.Parameters.AddWithValue("@loai", cmbLoai.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@maDanhMuc", cmbDanhMuc.SelectedValue);
                cmd.Parameters.AddWithValue("@soTien", soTien);
                cmd.Parameters.AddWithValue("@moTa",
                    string.IsNullOrWhiteSpace(txtMoTa.Text)
                        ? (object)DBNull.Value : txtMoTa.Text.Trim());
                cmd.Parameters.AddWithValue("@ghiChu",
                    string.IsNullOrWhiteSpace(txtGhiChu.Text)
                        ? (object)DBNull.Value : txtGhiChu.Text.Trim());

                cmd.ExecuteNonQuery();

                // Nếu có tài khoản → cập nhật số dư
                if (maTK.HasValue)
                    CapNhatSoDuTaiKhoan(conn, maTK.Value,
                        cmbLoai.SelectedItem.ToString(), soTien);

                MessageBox.Show("✅ Giao dịch đã được lưu thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu giao dịch:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── Cập nhật SoDuHienTai trong bảng TaiKhoan ─────────────────────
        private void CapNhatSoDuTaiKhoan(SqlConnection conn,
            int maTK, string loai, decimal soTien)
        {
            string sign = loai == "Thu Nhập" ? "+" : "-";
            string sqlTK = $"UPDATE TaiKhoan SET SoDuHienTai = SoDuHienTai {sign} @st " +
                           "WHERE MaTaiKhoan = @maTK";
            using var cmd = new SqlCommand(sqlTK, conn);
            cmd.Parameters.AddWithValue("@st", soTien);
            cmd.Parameters.AddWithValue("@maTK", maTK);
            cmd.ExecuteNonQuery();
        }

        // ─── Hủy ───────────────────────────────────────────────────────────
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // ─── Format số tiền khi rời TextBox ───────────────────────────────
        private void txtSoTien_Leave(object sender, EventArgs e)
        {
            string raw = txtSoTien.Text.Replace(",", "").Replace(".", "");
            if (decimal.TryParse(raw, out decimal val))
                txtSoTien.Text = val.ToString("#,##0");
        }

        private void txtSoTien_Enter(object sender, EventArgs e)
        {
            txtSoTien.Text = txtSoTien.Text.Replace(",", "");
        }

        // ─── Helper ────────────────────────────────────────────────────────
        private static void ShowWarn(string msg) =>
            MessageBox.Show(msg, "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

    }
}