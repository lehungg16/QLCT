namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class Quản_Lý_Chi_Tiêu
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
            panelMenu = new Panel();
            lblName = new Label();
            btnCategory = new Button();
            btnReport = new Button();
            btnSpending = new Button();
            btnIncome = new Button();
            btnDashboard = new Button();
            labelUsername = new Label();
            panelHeader = new Panel();
            labelQLCT = new Label();
            panelMain = new Panel();
            panelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ButtonFace;
            panelMenu.Controls.Add(lblName);
            panelMenu.Controls.Add(btnCategory);
            panelMenu.Controls.Add(btnReport);
            panelMenu.Controls.Add(btnSpending);
            panelMenu.Controls.Add(btnIncome);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(labelUsername);
            panelMenu.Location = new Point(2, 1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(325, 623);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F);
            lblName.Location = new Point(75, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(109, 46);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // btnCategory
            // 
            btnCategory.Font = new Font("Segoe UI", 10F);
            btnCategory.Location = new Point(0, 358);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(325, 66);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Danh Mục";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click_1;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 10F);
            btnReport.Location = new Point(0, 286);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(325, 66);
            btnReport.TabIndex = 2;
            btnReport.Text = "Báo Cáo";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click_1;
            // 
            // btnSpending
            // 
            btnSpending.Font = new Font("Segoe UI", 10F);
            btnSpending.Location = new Point(0, 214);
            btnSpending.Name = "btnSpending";
            btnSpending.Size = new Size(325, 66);
            btnSpending.TabIndex = 2;
            btnSpending.Text = "Chi Tiêu";
            btnSpending.UseVisualStyleBackColor = true;
            btnSpending.Click += btnSpending_Click_1;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI", 10F);
            btnIncome.Location = new Point(0, 142);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(325, 66);
            btnIncome.TabIndex = 2;
            btnIncome.Text = "Thu Nhập";
            btnIncome.UseVisualStyleBackColor = true;
            btnIncome.Click += btnIncome_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.Location = new Point(0, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(325, 66);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 20F);
            labelUsername.Location = new Point(0, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(79, 46);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Tên:";
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(labelQLCT);
            panelHeader.Location = new Point(333, 1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(845, 64);
            panelHeader.TabIndex = 1;
            panelHeader.Paint += panelHeader_Paint_1;
            // 
            // labelQLCT
            // 
            labelQLCT.AutoSize = true;
            labelQLCT.Font = new Font("Segoe UI", 20F);
            labelQLCT.Location = new Point(295, 8);
            labelQLCT.Name = "labelQLCT";
            labelQLCT.Size = new Size(269, 46);
            labelQLCT.TabIndex = 0;
            labelQLCT.Text = "Quản Lý Chi Tiêu";
            labelQLCT.Click += labelQLCT_Click;
            // 
            // panelMain
            // 
            panelMain.ImeMode = ImeMode.NoControl;
            panelMain.Location = new Point(333, 71);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(845, 553);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint_1;
            // 
            // Quản_Lý_Chi_Tiêu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 627);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Name = "Quản_Lý_Chi_Tiêu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản_Lý_Chi_Tiêu";
            Load += Quản_Lý_Chi_Tiêu_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelHeader;
        private Panel panelMain;
        private Button btnDashboard;
        private Label labelUsername;
        private Button btnCategory;
        private Button button4;
        private Button btnReport;
        private Button btnSpending;
        private Button btnIncome;
        private Label labelQLCT;
        private Label lblName;
    }
}