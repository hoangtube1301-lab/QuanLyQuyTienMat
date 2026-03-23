namespace GUI
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuQuanLyNguoiDung = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            thuTiềnToolStripMenuItem = new ToolStripMenuItem();
            chiTiềnToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            traCứuToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUserStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, nghiệpVụToolStripMenuItem, báoCáoToolStripMenuItem, traCứuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(791, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuQuanLyNguoiDung, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(89, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống ";
            // 
            // menuQuanLyNguoiDung
            // 
            menuQuanLyNguoiDung.Name = "menuQuanLyNguoiDung";
            menuQuanLyNguoiDung.Size = new Size(223, 26);
            menuQuanLyNguoiDung.Text = "Quản lý người dùng";
            menuQuanLyNguoiDung.Click += menuQuanLyNguoiDung_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(223, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuTiềnToolStripMenuItem, chiTiềnToolStripMenuItem });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(91, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // thuTiềnToolStripMenuItem
            // 
            thuTiềnToolStripMenuItem.Name = "thuTiềnToolStripMenuItem";
            thuTiềnToolStripMenuItem.Size = new Size(149, 26);
            thuTiềnToolStripMenuItem.Text = "Thu tiền ";
            thuTiềnToolStripMenuItem.Click += thuTiềnToolStripMenuItem_Click;
            // 
            // chiTiềnToolStripMenuItem
            // 
            chiTiềnToolStripMenuItem.Name = "chiTiềnToolStripMenuItem";
            chiTiềnToolStripMenuItem.Size = new Size(149, 26);
            chiTiềnToolStripMenuItem.Text = "Chi tiền ";
            chiTiềnToolStripMenuItem.Click += chiTiềnToolStripMenuItem_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(131, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo tồn quỹ";
            báoCáoToolStripMenuItem.Click += báoCáoToolStripMenuItem_Click;
            // 
            // traCứuToolStripMenuItem
            // 
            traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            traCứuToolStripMenuItem.Size = new Size(71, 24);
            traCứuToolStripMenuItem.Text = "Tra cứu";
            traCứuToolStripMenuItem.Click += traCứuToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUserStatus });
            statusStrip1.Location = new Point(0, 368);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(791, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUserStatus
            // 
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(151, 20);
            lblUserStatus.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 394);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem thuTiềnToolStripMenuItem;
        private ToolStripMenuItem chiTiềnToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUserStatus;
        private ToolStripMenuItem traCứuToolStripMenuItem;
        private ToolStripMenuItem menuQuanLyNguoiDung;
    }
}