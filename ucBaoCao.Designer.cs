namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class ucBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBaoCao));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnExportExcel = new Button();
            btnRefresh = new Button();
            dgvChiTiet = new DataGridView();
            chartBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvBaoCao = new DataGridView();
            lblBaoCao = new Label();
            btnInBaoCao = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBaoCao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // btnExportExcel
            // 
            btnExportExcel.Font = new Font("Segoe UI", 10F);
            btnExportExcel.Image = (Image)resources.GetObject("btnExportExcel.Image");
            btnExportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportExcel.Location = new Point(655, 490);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(170, 51);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Xuất Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 10F);
            btnRefresh.Location = new Point(479, 490);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(170, 51);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm Mới [F5]";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTiet.Location = new Point(479, 47);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.Size = new Size(346, 437);
            dgvChiTiet.TabIndex = 3;
            // 
            // chartBaoCao
            // 
            chartArea1.Name = "ChartArea1";
            chartBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBaoCao.Legends.Add(legend1);
            chartBaoCao.Location = new Point(175, 47);
            chartBaoCao.Name = "chartBaoCao";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBaoCao.Series.Add(series1);
            chartBaoCao.Size = new Size(298, 437);
            chartBaoCao.TabIndex = 4;
            chartBaoCao.Text = "chart1";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(3, 47);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.Size = new Size(166, 437);
            dgvBaoCao.TabIndex = 0;
            // 
            // lblBaoCao
            // 
            lblBaoCao.AutoSize = true;
            lblBaoCao.Font = new Font("Segoe UI", 17F);
            lblBaoCao.Location = new Point(0, 0);
            lblBaoCao.Name = "lblBaoCao";
            lblBaoCao.Size = new Size(124, 40);
            lblBaoCao.TabIndex = 5;
            lblBaoCao.Text = "Báo Cáo";
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.Font = new Font("Segoe UI", 10F);
            btnInBaoCao.Location = new Point(3, 490);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(170, 51);
            btnInBaoCao.TabIndex = 6;
            btnInBaoCao.Text = "In Báo Cáo";
            btnInBaoCao.UseVisualStyleBackColor = true;
            btnInBaoCao.Click += btnInBaoCao_Click;
            // 
            // ucBaoCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnInBaoCao);
            Controls.Add(lblBaoCao);
            Controls.Add(chartBaoCao);
            Controls.Add(dgvChiTiet);
            Controls.Add(btnRefresh);
            Controls.Add(dgvBaoCao);
            Controls.Add(btnExportExcel);
            Name = "ucBaoCao";
            Size = new Size(845, 553);
            Load += ucBaoCao_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBaoCao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExportExcel;
        private Button btnRefresh;
        private DataGridView dgvChiTiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBaoCao;
        private DataGridView dgvBaoCao;
        private Label lblBaoCao;
        private Button btnInBaoCao;
    }
}
