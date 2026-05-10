namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ThemGiaoDich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpNgay = new DateTimePicker();
            lblSoTien = new Label();
            btnHuy = new Button();
            cmbLoai = new ComboBox();
            cmbTaiKhoan = new ComboBox();
            cmbDanhMuc = new ComboBox();
            btnLuu = new Button();
            txtMoTa = new TextBox();
            txtGhiChu = new TextBox();
            txtSoTien = new TextBox();
            SuspendLayout();
            // 
            // dtpNgay
            // 
            dtpNgay.Location = new Point(460, 62);
            dtpNgay.Name = "dtpNgay";
            dtpNgay.Size = new Size(250, 27);
            dtpNgay.TabIndex = 0;
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(216, 24);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(58, 20);
            lblSoTien.TabIndex = 1;
            lblSoTien.Text = "Số Tiền";
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 10F);
            btnHuy.Location = new Point(605, 371);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(170, 67);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // cmbLoai
            // 
            cmbLoai.FormattingEnabled = true;
            cmbLoai.Location = new Point(492, 174);
            cmbLoai.Name = "cmbLoai";
            cmbLoai.Size = new Size(138, 28);
            cmbLoai.TabIndex = 3;
            cmbLoai.Text = "Chuyển Khoản";
            cmbLoai.Visible = false;
            cmbLoai.SelectedIndexChanged += cmbLoai_SelectedIndexChanged;
            // 
            // cmbTaiKhoan
            // 
            cmbTaiKhoan.FormattingEnabled = true;
            cmbTaiKhoan.Location = new Point(460, 106);
            cmbTaiKhoan.Name = "cmbTaiKhoan";
            cmbTaiKhoan.Size = new Size(170, 28);
            cmbTaiKhoan.TabIndex = 4;
            cmbTaiKhoan.Visible = false;
            // 
            // cmbDanhMuc
            // 
            cmbDanhMuc.FormattingEnabled = true;
            cmbDanhMuc.Location = new Point(479, 140);
            cmbDanhMuc.Name = "cmbDanhMuc";
            cmbDanhMuc.Size = new Size(151, 28);
            cmbDanhMuc.TabIndex = 5;
            cmbDanhMuc.Visible = false;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10F);
            btnLuu.Location = new Point(407, 371);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(170, 67);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(505, 208);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(125, 27);
            txtMoTa.TabIndex = 7;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(505, 255);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(125, 27);
            txtGhiChu.TabIndex = 8;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(525, 288);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(105, 27);
            txtSoTien.TabIndex = 9;
            // 
            // ThemGiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoTien);
            Controls.Add(txtGhiChu);
            Controls.Add(txtMoTa);
            Controls.Add(btnLuu);
            Controls.Add(cmbDanhMuc);
            Controls.Add(cmbTaiKhoan);
            Controls.Add(cmbLoai);
            Controls.Add(btnHuy);
            Controls.Add(lblSoTien);
            Controls.Add(dtpNgay);
            Name = "ThemGiaoDich";
            Text = "ThemGiaoDich";
            Load += ThemGiaoDich_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNgay;
        private Label lblSoTien;
        private Button btnHuy;
        private ComboBox cmbLoai;
        private ComboBox cmbTaiKhoan;
        private ComboBox cmbDanhMuc;
        private Button btnLuu;
        private TextBox txtMoTa;
        private TextBox txtGhiChu;
        private TextBox txtSoTien;
    }
}