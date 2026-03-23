using DAL.Models;
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
    public partial class frmPhieuChi : Form
    {

        TransactionService busGiaoDich = new TransactionService();
        public frmPhieuChi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra "Bắt buộc nhập đầy đủ"
            // Kiểm tra các ô quan trọng nhất theo thiết kế của bạn
            if (string.IsNullOrWhiteSpace(SoCt.Text) ||
                string.IsNullOrWhiteSpace(TenDoiTuong.Text) ||
                string.IsNullOrWhiteSpace(SoTienBangChu.Text))
            {
                MessageBox.Show("LỖI: Bạn phải nhập đầy đủ Số chứng từ, Họ tên và Số tiền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại ngay lập tức
            }

            // 2. Kiểm tra "Nhập đúng ký tự" cho Số tiền
            // Ràng buộc decimal(18,2) trong DB yêu cầu dữ liệu phải là số
            if (!decimal.TryParse(SoTien.Text, out decimal soTien))
            {
                MessageBox.Show("LỖI: Số tiền phải là ký tự số (ví dụ: 1000000)!", "Định dạng sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SoTien.Focus();
                return;
            }

            try
            {
                // 3. Khởi tạo đối tượng GiaoDich với các quy tắc từ Database
                var moi = new GiaoDich()
                {
                    SoCt = SoCt.Text.Trim(),        // Quy tắc: Không được trùng
                    NgayCt = NgayCt.Value,            // Ngày lập phiếu
                    DienGiai = DienGiai.Text,           // Lý do nộp/chi
                    SoTien = soTien,                   // Số tiền đã kiểm tra ở bước 2
                    TenDoiTuong = TenDoiTuong.Text,       // Tên người nộp/nhận
                    DiaChi = DiaChi.Text,
                    SoTienBangChu = SoTienBangChu.Text,
                    ChungTuGoc = ChungTuGoc.Text,

                    // Quy tắc Check Constraint: 1 là Thu, 0 là Chi
                    // Nếu bạn đang ở Form Phiếu Thu thì để là 1, Phiếu Chi để là 0
                    LoaiGiaoDich = 1
                };

                // 4. Gọi xuống lớp BUS để thực hiện lệnh INSERT vào SQL Server
                string ketQua = busGiaoDich.AddNewTransaction(moi);

                // Nếu lưu thành công (giả định)
                MessageBox.Show($"Đã lưu thành công chứng từ {SoCt.Text}!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi lưu xong, xóa trắng để nhập phiếu mới
                this.Close(); // Dòng lệnh giúp form tự đóng sau khi lưu xong
            }
            catch (Exception ex)
            {
                // Thông báo nếu vi phạm ràng buộc Unique (trùng SoCT) hoặc lỗi kết nối SQL
                MessageBox.Show("Không thể lưu dữ liệu! \nChi tiết lỗi: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        // Hàm hỗ trợ xóa trắng các ô nhập liệu
        private void LamMoiForm()
        {
            SoCt.Clear();
            TenDoiTuong.Clear();
            SoTien.Clear();
            DienGiai.Clear();
            DiaChi.Clear();
            SoTienBangChu.Clear();
            ChungTuGoc.Clear();
            NgayCt.Value = DateTime.Now;
            SoCt.Focus(); // Đưa con trỏ về ô đầu tiên
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng form hiện tại
        }
    }
}
