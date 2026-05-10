namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ucThuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThuNhap));
            dgvThuNhap = new DataGridView();
            lblTongThuNhap = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThemThuNhap = new Button();
            lblTongThu = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvThuNhap).BeginInit();
            SuspendLayout();
            // 
            // dgvThuNhap
            // 
            dgvThuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThuNhap.Location = new Point(14, 83);
            dgvThuNhap.Name = "dgvThuNhap";
            dgvThuNhap.RowHeadersWidth = 51;
            dgvThuNhap.Size = new Size(810, 379);
            dgvThuNhap.TabIndex = 0;
            // 
            // lblTongThuNhap
            // 
            lblTongThuNhap.AutoSize = true;
            lblTongThuNhap.Font = new Font("Segoe UI", 17F);
            lblTongThuNhap.ForeColor = Color.Red;
            lblTongThuNhap.Location = new Point(0, 40);
            lblTongThuNhap.Name = "lblTongThuNhap";
            lblTongThuNhap.Size = new Size(110, 40);
            lblTongThuNhap.TabIndex = 1;
            lblTongThuNhap.Text = "Số Tiền";
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Image = Properties.Resources.favicon_32x32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(440, 468);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 70);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(654, 468);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(170, 70);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnThemThuNhap
            // 
            btnThemThuNhap.Font = new Font("Segoe UI", 10F);
            btnThemThuNhap.Image = Properties.Resources.favicon_32x322;
            btnThemThuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemThuNhap.Location = new Point(190, 468);
            btnThemThuNhap.Name = "btnThemThuNhap";
            btnThemThuNhap.Size = new Size(229, 70);
            btnThemThuNhap.TabIndex = 4;
            btnThemThuNhap.Text = "Thêm Thu Nhập";
            btnThemThuNhap.UseVisualStyleBackColor = true;
            btnThemThuNhap.Click += btnThemThuNhap_Click_1;
            // 
            // lblTongThu
            // 
            lblTongThu.AutoSize = true;
            lblTongThu.Font = new Font("Segoe UI", 17F);
            lblTongThu.Location = new Point(0, 0);
            lblTongThu.Name = "lblTongThu";
            lblTongThu.Size = new Size(215, 40);
            lblTongThu.TabIndex = 6;
            lblTongThu.Text = "Tổng Thu Nhập";
            // 
            // ucThuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTongThu);
            Controls.Add(btnThemThuNhap);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblTongThuNhap);
            Controls.Add(dgvThuNhap);
            Name = "ucThuNhap";
            Size = new Size(845, 553);
            Load += ucThuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvThuNhap;
        private Label lblTongThuNhap;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThemThuNhap;
        private Label lblTongThu;
    }
}
