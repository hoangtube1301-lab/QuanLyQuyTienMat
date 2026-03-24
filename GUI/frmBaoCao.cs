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
            // 1. Lấy ngày thực tế (bao gồm cả ngày hôm nay)
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date.AddDays(1);
            // 2. Gọi BUS lấy data
            DataTable dt = bus.LayBangBaoCao(tu, den);

            // 3. Cập nhật giao diện - Dòng này là then chốt để thấy sự thay đổi
            dgvBaoCao.DataSource = null;
            dgvBaoCao.DataSource = dt;

            // 4. Tính toán lại các label
            decimal thu, chi;
            bus.TinhToanSoDu(dt, out thu, out chi);
            lblTongThu.Text = "Tổng thu: " + BUS.CurrencyHelper.FormatVND(thu);
            lblTongChi.Text = "Tổng chi: " + BUS.CurrencyHelper.FormatVND(chi);
            lblTonQuy.Text = "Tồn quỹ: " + BUS.CurrencyHelper.FormatVND(thu - chi);
        }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
