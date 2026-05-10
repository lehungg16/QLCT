namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ucChiTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucChiTieu));
            lblTongChi = new Label();
            lblTongChiTieu = new Label();
            dgvChiTieu = new DataGridView();
            btnThemChiTieu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).BeginInit();
            SuspendLayout();
            // 
            // lblTongChi
            // 
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new Font("Segoe UI", 17F);
            lblTongChi.Location = new Point(0, 0);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(192, 40);
            lblTongChi.TabIndex = 0;
            lblTongChi.Text = "Tổng Chi Tiêu";
            // 
            // lblTongChiTieu
            // 
            lblTongChiTieu.AutoSize = true;
            lblTongChiTieu.Font = new Font("Segoe UI", 17F);
            lblTongChiTieu.ForeColor = Color.Red;
            lblTongChiTieu.Location = new Point(0, 40);
            lblTongChiTieu.Name = "lblTongChiTieu";
            lblTongChiTieu.Size = new Size(110, 40);
            lblTongChiTieu.TabIndex = 1;
            lblTongChiTieu.Text = "Số Tiền";
            lblTongChiTieu.Click += lblTongChiTieu_Click;
            // 
            // dgvChiTieu
            // 
            dgvChiTieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTieu.Location = new Point(14, 83);
            dgvChiTieu.Name = "dgvChiTieu";
            dgvChiTieu.RowHeadersWidth = 51;
            dgvChiTieu.Size = new Size(810, 379);
            dgvChiTieu.TabIndex = 2;
            // 
            // btnThemChiTieu
            // 
            btnThemChiTieu.Font = new Font("Segoe UI", 10F);
            btnThemChiTieu.Image = (Image)resources.GetObject("btnThemChiTieu.Image");
            btnThemChiTieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemChiTieu.Location = new Point(211, 468);
            btnThemChiTieu.Name = "btnThemChiTieu";
            btnThemChiTieu.Size = new Size(194, 70);
            btnThemChiTieu.TabIndex = 3;
            btnThemChiTieu.Text = "Thêm Chi Tiêu";
            btnThemChiTieu.UseVisualStyleBackColor = true;
            btnThemChiTieu.Click += btnThemChiTieu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(440, 468);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(170, 70);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
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
            btnXoa.Click += btnXoa_Click;
            // 
            // ucChiTieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThemChiTieu);
            Controls.Add(dgvChiTieu);
            Controls.Add(lblTongChiTieu);
            Controls.Add(lblTongChi);
            Name = "ucChiTieu";
            Size = new Size(845, 553);
            Load += ucChiTieu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTieu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTongChi;
        private Label lblTongChiTieu;
        private DataGridView dgvChiTieu;
        private Button btnThemChiTieu;
        private Button btnSua;
        private Button btnXoa;
    }
}
