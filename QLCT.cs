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
    public partial class Quản_Lý_Chi_Tiêu : Form
    {
        public Quản_Lý_Chi_Tiêu()
        {
            InitializeComponent();
        }

        // Constructor nhận tên user từ Login
        public Quản_Lý_Chi_Tiêu(string hoTen)
        {
            InitializeComponent();
            lblName.Text = hoTen; // Gán tên vào label
            //ApplyAllIcons(); // Áp dụng font và màu sắc cho tất cả controls
        }

        private void ApplyAllIcons()
        {
            // Chỉ gọi ApplyIconFont cho các Button trong panelMenu
            AppIcons.Apply(btnDashboard, AppIcons.Dashboard, "Dashboard");
            AppIcons.Apply(btnIncome, AppIcons.ThuNhap, "Thu Nhập");
            AppIcons.Apply(btnSpending, AppIcons.ChiTieu, "Chi Tiêu");
            AppIcons.Apply(btnReport, AppIcons.BaoCao, "Báo Cáo");
            AppIcons.Apply(btnCategory, AppIcons.DanhMuc, "Danh Mục");
        }

        private void LoadUserControl(UserControl uc)
        {
            if (uc == null) return;
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
            uc.Show();
        }

        private void Quản_Lý_Chi_Tiêu_Load(object sender, EventArgs e)
        {
            LoadUserControl(new ucDashboard());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDashboard());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e) { }

        private void labelQLCT_Click(object sender, EventArgs e) { }

        private void panelHeader_Paint_1(object sender, PaintEventArgs e) { }

        private void panelMain_Paint_1(object sender, PaintEventArgs e) { }

        private void btnIncome_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new ucThuNhap());
        }

        private void btnSpending_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new ucChiTieu());
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new ucBaoCao());
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new ucDanhMuc());
        }
    }
}