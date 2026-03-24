namespace GUI
{
    partial class frmSoGiaoDich
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            grbDieuKienTraCuu = new GroupBox();
            btnTraCuu = new Button();
            txtTimKiem = new TextBox();
            labDenNgay = new Label();
            label1 = new Label();
            labTuNgay = new Label();
            dptDenNgay = new DateTimePicker();
            dptTuNgay = new DateTimePicker();
            dgvSoGiaoDich = new DataGridView();
            colNgay = new DataGridViewTextBoxColumn();
            colSoHieu = new DataGridViewTextBoxColumn();
            colDienGiai = new DataGridViewTextBoxColumn();
            colSoTienThu = new DataGridViewTextBoxColumn();
            colSoTienChi = new DataGridViewTextBoxColumn();
            colTonQuy = new DataGridViewTextBoxColumn();
            grbDieuKienTraCuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoGiaoDich).BeginInit();
            SuspendLayout();
            // 
            // grbDieuKienTraCuu
            // 
            grbDieuKienTraCuu.Anchor = AnchorStyles.None;
            grbDieuKienTraCuu.BackColor = SystemColors.ButtonHighlight;
            grbDieuKienTraCuu.Controls.Add(btnTraCuu);
            grbDieuKienTraCuu.Controls.Add(txtTimKiem);
            grbDieuKienTraCuu.Controls.Add(labDenNgay);
            grbDieuKienTraCuu.Controls.Add(label1);
            grbDieuKienTraCuu.Controls.Add(labTuNgay);
            grbDieuKienTraCuu.Controls.Add(dptDenNgay);
            grbDieuKienTraCuu.Controls.Add(dptTuNgay);
            grbDieuKienTraCuu.Location = new Point(235, 227);
            grbDieuKienTraCuu.Name = "grbDieuKienTraCuu";
            grbDieuKienTraCuu.Size = new Size(726, 175);
            grbDieuKienTraCuu.TabIndex = 0;
            grbDieuKienTraCuu.TabStop = false;
            grbDieuKienTraCuu.Text = "Điều kiện tra cứu";
            // 
            // btnTraCuu
            // 
            btnTraCuu.Cursor = Cursors.Hand;
            btnTraCuu.Location = new Point(322, 124);
            btnTraCuu.Name = "btnTraCuu";
            btnTraCuu.Size = new Size(167, 34);
            btnTraCuu.TabIndex = 3;
            btnTraCuu.Text = "Tra Cứu";
            btnTraCuu.UseVisualStyleBackColor = true;
            btnTraCuu.Click += btnTraCuu_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Cursor = Cursors.IBeam;
            txtTimKiem.Location = new Point(532, 84);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(167, 30);
            txtTimKiem.TabIndex = 2;
            // 
            // labDenNgay
            // 
            labDenNgay.AutoSize = true;
            labDenNgay.ImeMode = ImeMode.NoControl;
            labDenNgay.Location = new Point(22, 87);
            labDenNgay.Name = "labDenNgay";
            labDenNgay.Size = new Size(87, 23);
            labDenNgay.TabIndex = 1;
            labDenNgay.Text = "Đến ngày:";
            labDenNgay.Click += labDenNgay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(532, 58);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm chứa:";
            label1.Click += label1_Click;
            // 
            // labTuNgay
            // 
            labTuNgay.AutoSize = true;
            labTuNgay.Location = new Point(34, 44);
            labTuNgay.Name = "labTuNgay";
            labTuNgay.Size = new Size(75, 23);
            labTuNgay.TabIndex = 1;
            labTuNgay.Text = "Từ ngày:";
            // 
            // dptDenNgay
            // 
            dptDenNgay.Cursor = Cursors.Hand;
            dptDenNgay.Format = DateTimePickerFormat.Short;
            dptDenNgay.Location = new Point(115, 84);
            dptDenNgay.Name = "dptDenNgay";
            dptDenNgay.Size = new Size(165, 30);
            dptDenNgay.TabIndex = 0;
            dptDenNgay.ValueChanged += dptDenNgay_ValueChanged;
            // 
            // dptTuNgay
            // 
            dptTuNgay.Cursor = Cursors.Hand;
            dptTuNgay.Format = DateTimePickerFormat.Short;
            dptTuNgay.Location = new Point(115, 38);
            dptTuNgay.Name = "dptTuNgay";
            dptTuNgay.Size = new Size(167, 30);
            dptTuNgay.TabIndex = 0;
            // 
            // dgvSoGiaoDich
            // 
            dgvSoGiaoDich.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSoGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoGiaoDich.BackgroundColor = SystemColors.MenuBar;
            dgvSoGiaoDich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoGiaoDich.Columns.AddRange(new DataGridViewColumn[] { colNgay, colSoHieu, colDienGiai, colSoTienThu, colSoTienChi, colTonQuy });
            dgvSoGiaoDich.GridColor = Color.ForestGreen;
            dgvSoGiaoDich.Location = new Point(170, 426);
            dgvSoGiaoDich.Name = "dgvSoGiaoDich";
            dgvSoGiaoDich.RowHeadersWidth = 62;
            dgvSoGiaoDich.Size = new Size(866, 260);
            dgvSoGiaoDich.TabIndex = 1;
            dgvSoGiaoDich.CellContentClick += dgvSoGiaoDich_CellContentClick;
            // 
            // colNgay
            // 
            colNgay.DataPropertyName = "Ngay";
            colNgay.HeaderText = "Ngày Chứng Từ";
            colNgay.MinimumWidth = 8;
            colNgay.Name = "colNgay";
            // 
            // colSoHieu
            // 
            colSoHieu.DataPropertyName = "SoPhieu";
            colSoHieu.HeaderText = "Số Hiệu";
            colSoHieu.MinimumWidth = 8;
            colSoHieu.Name = "colSoHieu";
            // 
            // colDienGiai
            // 
            colDienGiai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDienGiai.DataPropertyName = "NoiDung";
            colDienGiai.HeaderText = "Diễn Giải";
            colDienGiai.MinimumWidth = 8;
            colDienGiai.Name = "colDienGiai";
            // 
            // colSoTienThu
            // 
            colSoTienThu.DataPropertyName = "TienThu";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSoTienThu.DefaultCellStyle = dataGridViewCellStyle1;
            colSoTienThu.HeaderText = "Số Tiền Thu";
            colSoTienThu.MinimumWidth = 8;
            colSoTienThu.Name = "colSoTienThu";
            // 
            // colSoTienChi
            // 
            colSoTienChi.DataPropertyName = "TienChi";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSoTienChi.DefaultCellStyle = dataGridViewCellStyle2;
            colSoTienChi.HeaderText = "Số Tiền Chi";
            colSoTienChi.MinimumWidth = 8;
            colSoTienChi.Name = "colSoTienChi";
            // 
            // colTonQuy
            // 
            colTonQuy.DataPropertyName = "TonQuy";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTonQuy.DefaultCellStyle = dataGridViewCellStyle3;
            colTonQuy.HeaderText = "Tồn Quỹ";
            colTonQuy.MinimumWidth = 8;
            colTonQuy.Name = "colTonQuy";
            // 
            // frmSoGiaoDich
            // 
            AcceptButton = btnTraCuu;
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.tracuu1;
            ClientSize = new Size(1158, 708);
            Controls.Add(dgvSoGiaoDich);
            Controls.Add(grbDieuKienTraCuu);
            Name = "frmSoGiaoDich";
            ShowIcon = false;
            Text = "Sổ Quỹ Tiền Mặt";
            Load += frmSoGiaoDich_Load;
            grbDieuKienTraCuu.ResumeLayout(false);
            grbDieuKienTraCuu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSoGiaoDich).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDieuKienTraCuu;
        private DateTimePicker dptDenNgay;
        private DateTimePicker dptTuNgay;
        private DataGridView dgvSoGiaoDich;
        private Label labDenNgay;
        private Label labTuNgay;
        private TextBox txtTimKiem;
        private Label label1;
        private Button btnTraCuu;
        private DataGridViewTextBoxColumn colNgay;
        private DataGridViewTextBoxColumn colSoHieu;
        private DataGridViewTextBoxColumn colDienGiai;
        private DataGridViewTextBoxColumn colSoTienThu;
        private DataGridViewTextBoxColumn colSoTienChi;
        private DataGridViewTextBoxColumn colTonQuy;
    }
}