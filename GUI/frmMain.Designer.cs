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
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            thuTiềnToolStripMenuItem = new ToolStripMenuItem();
            chiTiềnToolStripMenuItem = new ToolStripMenuItem();
            phiếuThuchiToolStripMenuItem = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            sổQuỹTiềnMặtToolStripMenuItem = new ToolStripMenuItem();
            báoCáoTồnQuỹToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUserStatus = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, nghiệpVụToolStripMenuItem, báoCáoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuQuanLyNguoiDung, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(89, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống ";
            // 
            // menuQuanLyNguoiDung
            // 
            menuQuanLyNguoiDung.Name = "menuQuanLyNguoiDung";
            menuQuanLyNguoiDung.Size = new Size(224, 26);
            menuQuanLyNguoiDung.Text = "Quản lý người dùng";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(224, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu ";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thuTiềnToolStripMenuItem, chiTiềnToolStripMenuItem, phiếuThuchiToolStripMenuItem });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(91, 24);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // thuTiềnToolStripMenuItem
            // 
            thuTiềnToolStripMenuItem.Name = "thuTiềnToolStripMenuItem";
            thuTiềnToolStripMenuItem.Size = new Size(178, 26);
            thuTiềnToolStripMenuItem.Text = "Thu tiền ";
            // 
            // chiTiềnToolStripMenuItem
            // 
            chiTiềnToolStripMenuItem.Name = "chiTiềnToolStripMenuItem";
            chiTiềnToolStripMenuItem.Size = new Size(178, 26);
            chiTiềnToolStripMenuItem.Text = "Chi tiền ";
            // 
            // phiếuThuchiToolStripMenuItem
            // 
            phiếuThuchiToolStripMenuItem.Name = "phiếuThuchiToolStripMenuItem";
            phiếuThuchiToolStripMenuItem.Size = new Size(178, 26);
            phiếuThuchiToolStripMenuItem.Text = "Phiếu thu/chi";
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sổQuỹTiềnMặtToolStripMenuItem, báoCáoTồnQuỹToolStripMenuItem });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // sổQuỹTiềnMặtToolStripMenuItem
            // 
            sổQuỹTiềnMặtToolStripMenuItem.Name = "sổQuỹTiềnMặtToolStripMenuItem";
            sổQuỹTiềnMặtToolStripMenuItem.Size = new Size(200, 26);
            sổQuỹTiềnMặtToolStripMenuItem.Text = "Sổ quỹ tiền mặt";
            // 
            // báoCáoTồnQuỹToolStripMenuItem
            // 
            báoCáoTồnQuỹToolStripMenuItem.Name = "báoCáoTồnQuỹToolStripMenuItem";
            báoCáoTồnQuỹToolStripMenuItem.Size = new Size(200, 26);
            báoCáoTồnQuỹToolStripMenuItem.Text = "Báo cáo tồn quỹ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUserStatus });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
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
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem menuQuanLyNguoiDung;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem thuTiềnToolStripMenuItem;
        private ToolStripMenuItem chiTiềnToolStripMenuItem;
        private ToolStripMenuItem phiếuThuchiToolStripMenuItem;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem sổQuỹTiềnMặtToolStripMenuItem;
        private ToolStripMenuItem báoCáoTồnQuỹToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUserStatus;
    }
}