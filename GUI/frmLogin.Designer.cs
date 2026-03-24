namespace GUI
{
    partial class frmLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Location = new Point(367, 228);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 30);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(367, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(229, 30);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.Honeydew;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.ForestGreen;
            btnLogin.Location = new Point(378, 353);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 56);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseMnemonic = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.UseWaitCursor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(233, 230);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(275, 277);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            label2.Click += label2_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Green_and_White_Illustrative_Finance_Presentation;
            ClientSize = new Size(900, 518);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
    }
}