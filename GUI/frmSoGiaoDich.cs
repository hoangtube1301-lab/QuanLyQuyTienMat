using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSoGiaoDich : frmBase
    {
        private readonly SoGiaoDichBUS _bus = new SoGiaoDichBUS();
        public frmSoGiaoDich()
        {
            InitializeComponent();
        }

        private void frmSoGiaoDich_Load(object sender, EventArgs e)
        {

        }

        private void dptDenNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labDenNgay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ các ô bạn đã kéo thả
            DateTime tuNgay = dptTuNgay.Value.Date;
            DateTime denNgay = dptDenNgay.Value.AddDays(1);
          
            string tuKhoa = txtTimKiem.Text;

            // 2. Gọi hàm "LaySoQuy" thần thánh ở lớp BUS mà bạn vừa tạo
            var data = _bus.HienThiSoQuy(tuNgay, denNgay, tuKhoa);

            // 3. Đổ dữ liệu vào bảng DataGridView
            dgvSoGiaoDich.DataSource = data;

            // 4. (Tùy chọn) Thông báo nếu không tìm thấy gì
            if (data.Count == 0)
            {
                MessageBox.Show("Không có giao dịch nào trong khoảng thời gian này!", "Thông báo");
            }
        }

        private void dgvSoGiaoDich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

