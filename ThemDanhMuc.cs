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
    public partial class ThemDanhMuc : Form
    {
        private string _type; // loại: Thu / Chi
        private int _id; // MaNguoiDung đang đăng nhập

        // Constructor có tham số
        public ThemDanhMuc(string type)
        {
            InitializeComponent();
            _type = type ?? ""; // fix luôn lỗi nullable
            _id = 0;
        }

        private void ThemDanhMuc_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /* Nút này có logic là trở về lại ucDanhMuc, có nghĩa là
              * quay lại ucDanhMuc */
        }

        private void btnThemDanhMuc_Click(object sender, EventArgs e)
        {
            /* Nút này thêm excel , gọi là insert vào bản, 
             * logic là (người dùng sẽ kích vào sẽ nhập File Excel */
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* Nút này để lưu những gì user đã thêm từ 
             * - txtBoxDanhMuc*/
            // SQL bảng là 'DanhMuc' trường 'TenDanhMuc'

        }

        private void txtBoxDanhMuc_TextChanged(object sender, EventArgs e)
        {
            //Ô danh mục
        }

        // Ngay chỗ này ô chọn ( 2 thuộc tính <<'Chi Tiêu' & 'Thu Nhập'>>)
    }
}
