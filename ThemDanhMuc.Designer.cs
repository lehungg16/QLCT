namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ThemDanhMuc
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
            btnThemDanhMuc = new Button();
            tblLPKhung = new TableLayoutPanel();
            tblLPKhung2 = new TableLayoutPanel();
            btnLuu = new Button();
            btnBack = new Button();
            tblLPKhung3 = new TableLayoutPanel();
            groupBoxThem = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBoxDanhMuc = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tblLPKhung.SuspendLayout();
            tblLPKhung2.SuspendLayout();
            tblLPKhung3.SuspendLayout();
            groupBoxThem.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThemDanhMuc
            // 
            btnThemDanhMuc.Dock = DockStyle.Fill;
            btnThemDanhMuc.Location = new Point(311, 3);
            btnThemDanhMuc.Name = "btnThemDanhMuc";
            btnThemDanhMuc.Size = new Size(292, 37);
            btnThemDanhMuc.TabIndex = 0;
            btnThemDanhMuc.Text = "Thêm";
            btnThemDanhMuc.UseVisualStyleBackColor = true;
            btnThemDanhMuc.Click += btnThemDanhMuc_Click;
            // 
            // tblLPKhung
            // 
            tblLPKhung.ColumnCount = 1;
            tblLPKhung.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLPKhung.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblLPKhung.Controls.Add(tblLPKhung2, 1, 1);
            tblLPKhung.Controls.Add(tblLPKhung3, 0, 0);
            tblLPKhung.Dock = DockStyle.Fill;
            tblLPKhung.Location = new Point(0, 0);
            tblLPKhung.Name = "tblLPKhung";
            tblLPKhung.RowCount = 2;
            tblLPKhung.RowStyles.Add(new RowStyle(SizeType.Percent, 89.11111F));
            tblLPKhung.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8888893F));
            tblLPKhung.Size = new Size(800, 450);
            tblLPKhung.TabIndex = 1;
            // 
            // tblLPKhung2
            // 
            tblLPKhung2.ColumnCount = 3;
            tblLPKhung2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8F));
            tblLPKhung2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2F));
            tblLPKhung2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 187F));
            tblLPKhung2.Controls.Add(btnLuu, 0, 0);
            tblLPKhung2.Controls.Add(btnThemDanhMuc, 1, 0);
            tblLPKhung2.Controls.Add(btnBack, 2, 0);
            tblLPKhung2.Dock = DockStyle.Fill;
            tblLPKhung2.Location = new Point(3, 404);
            tblLPKhung2.Name = "tblLPKhung2";
            tblLPKhung2.RowCount = 1;
            tblLPKhung2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLPKhung2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLPKhung2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLPKhung2.Size = new Size(794, 43);
            tblLPKhung2.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.Dock = DockStyle.Fill;
            btnLuu.Location = new Point(3, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(302, 37);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBack
            // 
            btnBack.Dock = DockStyle.Fill;
            btnBack.Location = new Point(609, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(182, 37);
            btnBack.TabIndex = 2;
            btnBack.Text = "Quay Lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // tblLPKhung3
            // 
            tblLPKhung3.ColumnCount = 2;
            tblLPKhung3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLPKhung3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 396F));
            tblLPKhung3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblLPKhung3.Controls.Add(groupBoxThem, 0, 0);
            tblLPKhung3.Dock = DockStyle.Fill;
            tblLPKhung3.Location = new Point(3, 3);
            tblLPKhung3.Name = "tblLPKhung3";
            tblLPKhung3.RowCount = 1;
            tblLPKhung3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLPKhung3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLPKhung3.Size = new Size(794, 395);
            tblLPKhung3.TabIndex = 2;
            // 
            // groupBoxThem
            // 
            groupBoxThem.Controls.Add(tableLayoutPanel1);
            groupBoxThem.Dock = DockStyle.Fill;
            groupBoxThem.Font = new Font("Segoe UI", 16F);
            groupBoxThem.Location = new Point(3, 3);
            groupBoxThem.Name = "groupBoxThem";
            groupBoxThem.Size = new Size(392, 389);
            groupBoxThem.TabIndex = 0;
            groupBoxThem.TabStop = false;
            groupBoxThem.Text = "Thêm Danh Mục";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.2279778F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.7720222F));
            tableLayoutPanel1.Controls.Add(txtBoxDanhMuc, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.08642F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.91358F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 265F));
            tableLayoutPanel1.Size = new Size(386, 347);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBoxDanhMuc
            // 
            txtBoxDanhMuc.Dock = DockStyle.Fill;
            txtBoxDanhMuc.Location = new Point(165, 3);
            txtBoxDanhMuc.Multiline = true;
            txtBoxDanhMuc.Name = "txtBoxDanhMuc";
            txtBoxDanhMuc.Size = new Size(218, 37);
            txtBoxDanhMuc.TabIndex = 1;
            txtBoxDanhMuc.TextChanged += txtBoxDanhMuc_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 43);
            label1.TabIndex = 0;
            label1.Text = "Tên Danh Mục :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(156, 38);
            label2.TabIndex = 2;
            label2.Text = "Loại Danh Mục :";
            // 
            // ThemDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblLPKhung);
            Name = "ThemDanhMuc";
            Text = "ThemDanhMuc";
            Load += ThemDanhMuc_Load;
            tblLPKhung.ResumeLayout(false);
            tblLPKhung2.ResumeLayout(false);
            tblLPKhung3.ResumeLayout(false);
            groupBoxThem.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnThemDanhMuc;
        private TableLayoutPanel tblLPKhung;
        private TableLayoutPanel tblLPKhung2;
        private Button btnLuu;
        private Button btnBack;
        private TableLayoutPanel tblLPKhung3;
        private GroupBox groupBoxThem;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBoxDanhMuc;
        private Label label1;
        private Label label2;
    }
}