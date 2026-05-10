namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ucDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lblTongThuNhap = new Label();
            lblTongChiTieu = new Label();
            lblSoDuHienTai = new Label();
            chartThuchi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvRecentTransactions = new DataGridView();
            lblTongThu = new Label();
            lblTongChi = new Label();
            lblSoDu = new Label();
            ((System.ComponentModel.ISupportInitialize)chartThuchi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
            SuspendLayout();
            // 
            // lblTongThuNhap
            // 
            lblTongThuNhap.AutoSize = true;
            lblTongThuNhap.Font = new Font("Segoe UI", 15F);
            lblTongThuNhap.ForeColor = Color.Green;
            lblTongThuNhap.Location = new Point(0, 40);
            lblTongThuNhap.Name = "lblTongThuNhap";
            lblTongThuNhap.Size = new Size(96, 35);
            lblTongThuNhap.TabIndex = 0;
            lblTongThuNhap.Text = "Số Tiền";
            // 
            // lblTongChiTieu
            // 
            lblTongChiTieu.AutoSize = true;
            lblTongChiTieu.Font = new Font("Segoe UI", 15F);
            lblTongChiTieu.ForeColor = Color.Red;
            lblTongChiTieu.Location = new Point(308, 40);
            lblTongChiTieu.Name = "lblTongChiTieu";
            lblTongChiTieu.Size = new Size(103, 35);
            lblTongChiTieu.TabIndex = 1;
            lblTongChiTieu.Text = "Số Tiền ";
            // 
            // lblSoDuHienTai
            // 
            lblSoDuHienTai.AutoSize = true;
            lblSoDuHienTai.Font = new Font("Segoe UI", 15F);
            lblSoDuHienTai.ForeColor = Color.Black;
            lblSoDuHienTai.Location = new Point(639, 40);
            lblSoDuHienTai.Name = "lblSoDuHienTai";
            lblSoDuHienTai.Size = new Size(96, 35);
            lblSoDuHienTai.TabIndex = 2;
            lblSoDuHienTai.Text = "Số Tiền";
            // 
            // chartThuchi
            // 
            chartArea1.Name = "ChartArea1";
            chartThuchi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartThuchi.Legends.Add(legend1);
            chartThuchi.Location = new Point(0, 169);
            chartThuchi.Name = "chartThuchi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartThuchi.Series.Add(series1);
            chartThuchi.Size = new Size(390, 308);
            chartThuchi.TabIndex = 3;
            chartThuchi.Text = "chart1";
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.Location = new Point(396, 169);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.RowHeadersWidth = 51;
            dgvRecentTransactions.Size = new Size(439, 308);
            dgvRecentTransactions.TabIndex = 4;
            // 
            // lblTongThu
            // 
            lblTongThu.AutoSize = true;
            lblTongThu.Font = new Font("Segoe UI", 17F);
            lblTongThu.Location = new Point(0, 0);
            lblTongThu.Name = "lblTongThu";
            lblTongThu.Size = new Size(215, 40);
            lblTongThu.TabIndex = 5;
            lblTongThu.Text = "Tổng Thu Nhập";
            // 
            // lblTongChi
            // 
            lblTongChi.AutoSize = true;
            lblTongChi.Font = new Font("Segoe UI", 17F);
            lblTongChi.Location = new Point(308, 0);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(192, 40);
            lblTongChi.TabIndex = 5;
            lblTongChi.Text = "Tổng Chi Tiêu";
            // 
            // lblSoDu
            // 
            lblSoDu.AutoSize = true;
            lblSoDu.Font = new Font("Segoe UI", 17F);
            lblSoDu.Location = new Point(639, 0);
            lblSoDu.Name = "lblSoDu";
            lblSoDu.Size = new Size(206, 40);
            lblSoDu.TabIndex = 5;
            lblSoDu.Text = "Số Dư Hiện Tại";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSoDu);
            Controls.Add(lblTongChi);
            Controls.Add(lblTongThu);
            Controls.Add(dgvRecentTransactions);
            Controls.Add(chartThuchi);
            Controls.Add(lblSoDuHienTai);
            Controls.Add(lblTongChiTieu);
            Controls.Add(lblTongThuNhap);
            Name = "ucDashboard";
            Size = new Size(845, 553);
            Load += ucDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)chartThuchi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTongThuNhap;
        private Label lblTongChiTieu;
        private Label lblSoDuHienTai;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThuchi;
        private DataGridView dgvRecentTransactions;
        private Label lblTongThu;
        private Label lblTongChi;
        private Label lblSoDu;
    }
}
