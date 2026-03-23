namespace GUI
{
    partial class frmBaoCao
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
            label1 = new Label();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            btnThongKe = new Button();
            lblTonQuy = new Label();
            lblTongChi = new Label();
            lblTongThu = new Label();
            dgvBaoCao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 76);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(666, 125);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 0;
            label2.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(755, 70);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(250, 30);
            dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(755, 119);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(250, 30);
            dtpDenNgay.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(727, 180);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(191, 29);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "Xem báo cáo";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblTonQuy
            // 
            lblTonQuy.AutoSize = true;
            lblTonQuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTonQuy.ForeColor = SystemColors.HotTrack;
            lblTonQuy.Location = new Point(755, 307);
            lblTonQuy.Name = "lblTonQuy";
            lblTonQuy.Size = new Size(137, 23);
            lblTonQuy.TabIndex = 4;
            lblTonQuy.Text = "Tồn quỹ: 0 VNĐ";
            // 
            // lblTongChi
            // 
            lblTongChi.AutoSize = true;
            lblTongChi.Location = new Point(755, 242);
            lblTongChi.Name = "lblTongChi";
            lblTongChi.Size = new Size(135, 23);
            lblTongChi.TabIndex = 4;
            lblTongChi.Text = "Tổng chi: 0 VNĐ";
            // 
            // lblTongThu
            // 
            lblTongThu.AutoSize = true;
            lblTongThu.Location = new Point(755, 275);
            lblTongThu.Name = "lblTongThu";
            lblTongThu.Size = new Size(139, 23);
            lblTongThu.TabIndex = 4;
            lblTongThu.Text = "Tổng thu: 0 VNĐ";
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(8, 34);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.RowHeadersWidth = 51;
            dgvBaoCao.Size = new Size(633, 419);
            dgvBaoCao.TabIndex = 5;
            // 
            // frmBaoCao
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 486);
            Controls.Add(dgvBaoCao);
            Controls.Add(lblTongThu);
            Controls.Add(lblTongChi);
            Controls.Add(lblTonQuy);
            Controls.Add(btnThongKe);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBaoCao";
            Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private Button btnThongKe;
        private Label lblTonQuy;
        private Label lblTongChi;
        private Label lblTongThu;
        private DataGridView dgvBaoCao;
    }
}