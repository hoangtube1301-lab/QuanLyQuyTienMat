namespace GUI
{
    partial class frmQuanLyNguoiDung
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
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            cboVaiTro = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dgvNguoiDung = new DataGridView();
            btnLamMoi = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(cboVaiTro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(228, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(110, 81);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 4;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(108, 26);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(125, 27);
            txtTenDangNhap.TabIndex = 3;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "Kế toán" });
            cboVaiTro.Location = new Point(14, 143);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(151, 28);
            cboVaiTro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(43, 260);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(123, 39);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(461, 260);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 39);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(251, 260);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(123, 39);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvNguoiDung
            // 
            dgvNguoiDung.BackgroundColor = SystemColors.Control;
            dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguoiDung.Dock = DockStyle.Bottom;
            dgvNguoiDung.Location = new Point(0, 353);
            dgvNguoiDung.Name = "dgvNguoiDung";
            dgvNguoiDung.RowHeadersWidth = 51;
            dgvNguoiDung.Size = new Size(800, 97);
            dgvNguoiDung.TabIndex = 2;
            dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ControlLightLight;
            btnLamMoi.Location = new Point(643, 260);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(124, 39);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // frmQuanLyNguoiDung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvNguoiDung);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Name = "frmQuanLyNguoiDung";
            Text = "frmQuanLyNguoiDung";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNguoiDung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private ComboBox cboVaiTro;
        private Label label2;
        private Label label1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView dgvNguoiDung;
        private Button btnLamMoi;
    }
}