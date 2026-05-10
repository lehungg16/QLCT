namespace Quản_Lý_Chi_Tiêu_Thương_Mại
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnExit = new Button();
            btnEnter = new Button();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            txtPass = new Label();
            txtuser = new Label();
            txtLogin = new Label();
            checkBoxShowPass = new CheckBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Location = new Point(248, 174);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnEnter
            // 
            btnEnter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEnter.Location = new Point(79, 174);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(133, 36);
            btnEnter.TabIndex = 5;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPass.Location = new Point(146, 122);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(202, 27);
            textBoxPass.TabIndex = 4;
            textBoxPass.UseSystemPasswordChar = true;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxUser.Location = new Point(146, 79);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(202, 27);
            textBoxUser.TabIndex = 3;
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPass.AutoEllipsis = true;
            txtPass.AutoSize = true;
            txtPass.Location = new Point(65, 125);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(75, 20);
            txtPass.TabIndex = 2;
            txtPass.Text = "Mật Khẩu:";
            // 
            // txtuser
            // 
            txtuser.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtuser.AutoEllipsis = true;
            txtuser.AutoSize = true;
            txtuser.Location = new Point(64, 82);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(76, 20);
            txtuser.TabIndex = 1;
            txtuser.Text = "Tài Khoản:";
            // 
            // txtLogin
            // 
            txtLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.AutoEllipsis = true;
            txtLogin.AutoSize = true;
            txtLogin.Font = new Font("Segoe UI", 16F);
            txtLogin.Location = new Point(164, 28);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(153, 37);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "Đăng Nhập";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Location = new Point(354, 128);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(18, 17);
            checkBoxShowPass.TabIndex = 8;
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged_1;
            // 
            // Login
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(466, 260);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textBoxUser);
            Controls.Add(btnExit);
            Controls.Add(textBoxPass);
            Controls.Add(txtLogin);
            Controls.Add(btnEnter);
            Controls.Add(txtPass);
            Controls.Add(txtuser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtPass;
        private Label txtuser;
        private Label txtLogin;
        private TextBox textBoxUser;
        private Button btnEnter;
        private TextBox textBoxPass;
        private Button btnExit;
        private CheckBox checkBoxShowPass;
    }
}
