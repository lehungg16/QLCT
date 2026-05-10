namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ucDanhMuc
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
            dgvDanhMuc = new DataGridView();
            btnThemDanhMuc = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblnameDanhMuc = new Label();
            gBoxDanhMuc = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTenMuc = new Label();
            txbTenMuc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            gBoxDanhMuc.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Location = new Point(319, 20);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.Size = new Size(506, 443);
            dgvDanhMuc.TabIndex = 0;
            // 
            // btnThemDanhMuc
            // 
            btnThemDanhMuc.Image = Properties.Resources.favicon_32x322;
            btnThemDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemDanhMuc.Location = new Point(319, 485);
            btnThemDanhMuc.Name = "btnThemDanhMuc";
            btnThemDanhMuc.Size = new Size(181, 43);
            btnThemDanhMuc.TabIndex = 1;
            btnThemDanhMuc.Text = "Thêm Danh Mục";
            btnThemDanhMuc.UseVisualStyleBackColor = true;
            btnThemDanhMuc.Click += btnThemDanhMuc_Click;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.favicon_32x32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(525, 485);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(142, 43);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Image = Properties.Resources.favicon_32x321;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(688, 485);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(142, 43);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // lblnameDanhMuc
            // 
            lblnameDanhMuc.AutoSize = true;
            lblnameDanhMuc.Font = new Font("Segoe UI", 17F);
            lblnameDanhMuc.Location = new Point(0, 0);
            lblnameDanhMuc.Name = "lblnameDanhMuc";
            lblnameDanhMuc.Size = new Size(147, 40);
            lblnameDanhMuc.TabIndex = 2;
            lblnameDanhMuc.Text = "Danh Mục";
            lblnameDanhMuc.Click += lblnameDanhMuc_Click;
            // 
            // gBoxDanhMuc
            // 
            gBoxDanhMuc.Controls.Add(tableLayoutPanel1);
            gBoxDanhMuc.Font = new Font("Segoe UI", 15F);
            gBoxDanhMuc.Location = new Point(3, 43);
            gBoxDanhMuc.Name = "gBoxDanhMuc";
            gBoxDanhMuc.Size = new Size(310, 507);
            gBoxDanhMuc.TabIndex = 3;
            gBoxDanhMuc.TabStop = false;
            gBoxDanhMuc.Text = "Phân Loại";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.24461F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.75539F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblTenMuc, 0, 0);
            tableLayoutPanel1.Controls.Add(txbTenMuc, 1, 0);
            tableLayoutPanel1.Location = new Point(6, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(298, 90);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTenMuc
            // 
            lblTenMuc.AutoSize = true;
            lblTenMuc.Location = new Point(3, 0);
            lblTenMuc.Name = "lblTenMuc";
            lblTenMuc.Size = new Size(113, 35);
            lblTenMuc.TabIndex = 0;
            lblTenMuc.Text = "Tên Mục:";
            // 
            // txbTenMuc
            // 
            txbTenMuc.Location = new Point(134, 3);
            txbTenMuc.Name = "txbTenMuc";
            txbTenMuc.Size = new Size(161, 41);
            txbTenMuc.TabIndex = 1;
            // 
            // ucDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gBoxDanhMuc);
            Controls.Add(lblnameDanhMuc);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThemDanhMuc);
            Controls.Add(dgvDanhMuc);
            Name = "ucDanhMuc";
            Size = new Size(845, 553);
            Load += ucDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            gBoxDanhMuc.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhMuc;
        private Button btnThemDanhMuc;
        private Button btnSua;
        private Button btnXoa;
        private Label lblnameDanhMuc;
        private GroupBox gBoxDanhMuc;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTenMuc;
        private TextBox txbTenMuc;
    }
}
