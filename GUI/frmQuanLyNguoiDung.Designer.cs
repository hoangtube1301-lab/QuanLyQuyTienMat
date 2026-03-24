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
            label3 = new Label();
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
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(cboVaiTro);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(130, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 176);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 5;
            label3.Text = "Vai trò:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(106, 77);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(187, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(106, 26);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(187, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Admin", "Kế toán" });
            cboVaiTro.Location = new Point(106, 128);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(187, 28);
            cboVaiTro.TabIndex = 2;
            cboVaiTro.SelectedIndexChanged += cboVaiTro_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(514, 100);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(125, 39);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(514, 190);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 39);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa ";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(514, 145);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(125, 39);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dgvNguoiDung
            // 
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiDung.BackgroundColor = SystemColors.Control;
            dgvNguoiDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNguoiDung.Dock = DockStyle.Bottom;
            dgvNguoiDung.GridColor = Color.Green;
            dgvNguoiDung.Location = new Point(0, 295);
            dgvNguoiDung.Name = "dgvNguoiDung";
            dgvNguoiDung.RowHeadersWidth = 51;
            dgvNguoiDung.Size = new Size(757, 155);
            dgvNguoiDung.TabIndex = 2;
            dgvNguoiDung.CellClick += dgvNguoiDung_CellClick;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = SystemColors.ControlLightLight;
            btnLamMoi.Location = new Point(514, 235);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(125, 39);
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
            BackgroundImage = Properties.Resources.quanlynguoidung;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(757, 450);
            Controls.Add(btnLamMoi);
            Controls.Add(dgvNguoiDung);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmQuanLyNguoiDung";
            Text = "frmQuanLyNguoiDung";
            Load += frmQuanLyNguoiDung_Load;
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
        private Label label3;
    }
}