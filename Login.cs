using Microsoft.Data.SqlClient;


namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    public partial class Login : Form
    {
        private readonly string connStr =
            @"Server=localhost\MSSQLSERVER01;Database=QuanLyChiTieu;Trusted_Connection=True;TrustServerCertificate=True";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e) { }

        private void textBoxPass_TextChanged(object sender, EventArgs e) { }

        private void checkBoxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = !checkBoxShowPass.Checked;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text.Trim();
            string password = textBoxPass.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Nhập Đầy Đủ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Kiểm tra đăng nhập và lấy HoTen cùng lúc
                    string query = @"
                        SELECT HoTen FROM NguoiDung 
                        WHERE TenDangNhap = @TenDangNhap 
                          AND MatKhauHash = @MatKhauHash";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNhap", username);
                        cmd.Parameters.AddWithValue("@MatKhauHash", password);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string hoTen = result.ToString()!;

                            Quản_Lý_Chi_Tiêu f = new Quản_Lý_Chi_Tiêu(hoTen);
                            f.Show();
                            this.Hide();
                            f.FormClosed += (s, args) => this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                                "Lỗi đăng nhập",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}