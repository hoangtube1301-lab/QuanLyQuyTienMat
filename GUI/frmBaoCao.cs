using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaoCao : frmBase
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        // Khai báo lớp BUS ở đầu class
        BUS.GiaoDichBUS bus = new BUS.GiaoDichBUS();

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // 1. Lấy ngày từ giao diện
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date;

            // 2. Lấy dữ liệu từ BUS
            DataTable dt = bus.LayBangBaoCao(tu, den);

            // 3. Hiển thị lên bảng DataGridView
            dgvBaoCao.DataSource = dt;

            // 4. Tính toán số tiền
            decimal thu, chi;
            bus.TinhToanSoDu(dt, out thu, out chi);

            // 5. Hiển thị lên Label (Sử dụng Helper bạn đã làm)
            lblTongThu.Text = "Tổng thu: " + BUS.CurrencyHelper.FormatVND(thu);
            lblTongChi.Text = "Tổng chi: " + BUS.CurrencyHelper.FormatVND(chi);
            lblTonQuy.Text = "Tồn quỹ: " + BUS.CurrencyHelper.FormatVND(thu - chi);
        }
    }
}
