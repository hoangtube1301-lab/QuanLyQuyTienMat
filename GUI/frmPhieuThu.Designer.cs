namespace GUI
{
    partial class frmPhieuThu
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label26 = new Label();
            label27 = new Label();
            TenDoiTuong = new TextBox();
            DiaChi = new TextBox();
            DienGiai = new TextBox();
            SoTien = new TextBox();
            SoTienBangChu = new TextBox();
            ChungTuGoc = new TextBox();
            label2 = new Label();
            NgayCt = new DateTimePicker();
            SoCt = new TextBox();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(656, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Mẫu 01 - TT";
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(333, 6);
            label5.Name = "label5";
            label5.Size = new Size(161, 38);
            label5.TabIndex = 4;
            label5.Text = "PHIẾU THU";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 64);
            label6.Name = "label6";
            label6.Size = new Size(132, 20);
            label6.TabIndex = 5;
            label6.Text = "Ngày/Tháng/Năm:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(373, 64);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ImageAlign = ContentAlignment.BottomLeft;
            label9.Location = new Point(63, 112);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 8;
            label9.Text = "Họ và tên người nộp tiền:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ImageAlign = ContentAlignment.BottomLeft;
            label10.Location = new Point(63, 145);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 9;
            label10.Text = "Địa chỉ:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ImageAlign = ContentAlignment.BottomLeft;
            label11.Location = new Point(63, 179);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 10;
            label11.Text = "Lý do nộp tiền:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ImageAlign = ContentAlignment.BottomLeft;
            label12.Location = new Point(63, 212);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 11;
            label12.Text = "Số tiền:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(310, 212);
            label13.Name = "label13";
            label13.Size = new Size(114, 20);
            label13.TabIndex = 12;
            label13.Text = "(Viết bằng chữ):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImageAlign = ContentAlignment.BottomLeft;
            label14.Location = new Point(64, 243);
            label14.Name = "label14";
            label14.Size = new Size(242, 20);
            label14.TabIndex = 13;
            label14.Text = "Kèm theo: ......................................................";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(310, 247);
            label15.Name = "label15";
            label15.Size = new Size(102, 20);
            label15.TabIndex = 14;
            label15.Text = "Chứng từ gốc:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label16.Location = new Point(102, 294);
            label16.Name = "label16";
            label16.Size = new Size(73, 20);
            label16.TabIndex = 15;
            label16.Text = "Giám đốc";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label17.Location = new Point(279, 294);
            label17.Name = "label17";
            label17.Size = new Size(112, 20);
            label17.TabIndex = 16;
            label17.Text = "Kế toán trưởng";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label18.Location = new Point(486, 294);
            label18.Name = "label18";
            label18.Size = new Size(112, 20);
            label18.TabIndex = 17;
            label18.Text = "Người nộp tiền";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label19.Location = new Point(702, 294);
            label19.Name = "label19";
            label19.Size = new Size(65, 20);
            label19.TabIndex = 18;
            label19.Text = "Thủ quỹ";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(494, 251);
            label22.Name = "label22";
            label22.Size = new Size(0, 20);
            label22.TabIndex = 19;
            label22.Click += label22_Click;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label23.Location = new Point(61, 315);
            label23.Name = "label23";
            label23.Size = new Size(149, 20);
            label23.TabIndex = 22;
            label23.Text = "(Ký, họ tên, đóng dấu)";
            label23.Click += label23_Click;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label24.Location = new Point(292, 315);
            label24.Name = "label24";
            label24.Size = new Size(82, 20);
            label24.TabIndex = 23;
            label24.Text = "(Ký, họ tên)";
            label24.Click += label24_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label26.Location = new Point(691, 315);
            label26.Name = "label26";
            label26.Size = new Size(82, 20);
            label26.TabIndex = 25;
            label26.Text = "(Ký, họ tên)";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label27.Location = new Point(500, 315);
            label27.Name = "label27";
            label27.Size = new Size(82, 20);
            label27.TabIndex = 26;
            label27.Text = "(Ký, họ tên)";
            // 
            // TenDoiTuong
            // 
            TenDoiTuong.Location = new Point(247, 109);
            TenDoiTuong.Name = "TenDoiTuong";
            TenDoiTuong.Size = new Size(493, 27);
            TenDoiTuong.TabIndex = 27;
            // 
            // DiaChi
            // 
            DiaChi.Location = new Point(127, 142);
            DiaChi.Name = "DiaChi";
            DiaChi.Size = new Size(613, 27);
            DiaChi.TabIndex = 28;
            // 
            // DienGiai
            // 
            DienGiai.Location = new Point(174, 176);
            DienGiai.Name = "DienGiai";
            DienGiai.Size = new Size(566, 27);
            DienGiai.TabIndex = 29;
            // 
            // SoTien
            // 
            SoTien.Location = new Point(127, 209);
            SoTien.Name = "SoTien";
            SoTien.Size = new Size(177, 27);
            SoTien.TabIndex = 30;
            // 
            // SoTienBangChu
            // 
            SoTienBangChu.Location = new Point(430, 209);
            SoTienBangChu.Name = "SoTienBangChu";
            SoTienBangChu.Size = new Size(310, 27);
            SoTienBangChu.TabIndex = 31;
            // 
            // ChungTuGoc
            // 
            ChungTuGoc.Location = new Point(418, 244);
            ChungTuGoc.Name = "ChungTuGoc";
            ChungTuGoc.Size = new Size(322, 27);
            ChungTuGoc.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(656, 50);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(29, 20);
            label2.TabIndex = 1;
            label2.Text = "Số:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Click += label2_Click;
            // 
            // NgayCt
            // 
            NgayCt.Location = new Point(348, 61);
            NgayCt.Name = "NgayCt";
            NgayCt.Size = new Size(250, 27);
            NgayCt.TabIndex = 35;
            // 
            // SoCt
            // 
            SoCt.Location = new Point(691, 47);
            SoCt.Name = "SoCt";
            SoCt.Size = new Size(69, 27);
            SoCt.TabIndex = 36;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Firebrick;
            button2.Location = new Point(523, 380);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 69;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Honeydew;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.ForestGreen;
            button1.Location = new Point(660, 380);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 68;
            button1.Text = "Lưu";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // frmPhieuThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SoCt);
            Controls.Add(NgayCt);
            Controls.Add(ChungTuGoc);
            Controls.Add(SoTienBangChu);
            Controls.Add(SoTien);
            Controls.Add(DienGiai);
            Controls.Add(DiaChi);
            Controls.Add(TenDoiTuong);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPhieuThu";
            Text = "frmPhieuThu";
            Load += frmPhieuThu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label26;
        private Label label27;
        private TextBox TenDoiTuong;
        private TextBox DiaChi;
        private TextBox DienGiai;
        private TextBox SoTien;
        private TextBox SoTienBangChu;
        private TextBox ChungTuGoc;
        private Label label2;
        private DateTimePicker NgayCt;
        private TextBox SoCt;
        private Button button2;
        private Button button1;
    }
}