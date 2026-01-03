using quanLyDienMayXanh.controller.nhansu;
using quanLyDienMayXanh.controller; // Kết nối Controller
using quanLyDienMayXanh.domain;    // Kết nối Domain
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization; // Cần thêm thư viện này để format tiền tệ

namespace quanLyDienMayXanh.view.nhansu
{
    public partial class FormChucVu : Form
    {
        // Khai báo Controller
        private ChucVuController controller;

        public FormChucVu()
        {
            InitializeComponent();

            // QUAN TRỌNG: Khởi tạo Controller và truyền Form này (this) vào
            controller = new ChucVuController(this);

            // --- ĐĂNG KÝ SỰ KIỆN FORMAT TIỀN TỆ ---
            // Khi gõ phím, nó sẽ tự động thêm dấu chấm
            this.txtLuongCoBan.TextChanged += TxtLuongCoBan_TextChanged;
            // Chỉ cho nhập số, chặn chữ cái
            this.txtLuongCoBan.KeyPress += TxtLuongCoBan_KeyPress;

            // Cài đặt trạng thái ban đầu
            ResetForm();
        }

        private void FormChucVu_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc load thêm config nếu cần
        }

        // =============================================================
        // CÁC HÀM HỖ TRỢ GIAO DIỆN (API CHO CONTROLLER)
        // =============================================================

        // 1. Hàm khóa/mở nút và đổi màu
        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;

            // Đổi màu để giao diện trực quan hơn
            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
        }

        // 2. Hàm làm mới form (Xóa trắng ô nhập)
        public void ResetForm()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtLuongCoBan.Text = "";
            txtMoTa.Text = "";

            txtMaCV.Enabled = true; // Cho phép nhập lại Mã CV
            txtMaCV.Focus();        // Đặt con trỏ chuột vào ô đầu tiên

            SetTrangThaiNut(false); // Về trạng thái chờ Thêm
            dgvChucVu.ClearSelection();
        }

        // 3. Hàm lấy dữ liệu từ Form -> ChucVu Object
        public ChucVu GetChucVuFromInput()
        {
            ChucVu cv = new ChucVu();
            cv.MaCV = txtMaCV.Text.Trim();
            cv.TenCV = txtTenCV.Text.Trim();
            cv.MoTa = txtMoTa.Text.Trim();

            // Xử lý Lương: Loại bỏ dấu phân cách (dấu chấm hoặc phẩy) trước khi parse
            // Ví dụ giao diện hiển thị: "10.000.000" -> Code lấy về: "10000000"
            string luongRaw = txtLuongCoBan.Text.Trim()
                                .Replace(".", "")
                                .Replace(",", "");

            if (double.TryParse(luongRaw, out double luong))
            {
                cv.LuongCoBan = luong;
            }
            else
            {
                cv.LuongCoBan = 0; // Nếu nhập sai thì mặc định là 0
            }

            return cv;
        }

        // 4. Hàm đổ dữ liệu từ Bảng -> Form (Khi click vào dòng)
        public void FillFormTuBang()
        {
            if (dgvChucVu.CurrentRow != null && dgvChucVu.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvChucVu.CurrentRow;

                // Lấy dữ liệu theo tên cột (đã đặt trong Designer)
                txtMaCV.Text = row.Cells["colMaCV"].Value?.ToString();
                txtTenCV.Text = row.Cells["colTenCV"].Value?.ToString();

                // Lấy lương từ bảng (giả sử bảng lưu số thô hoặc đã format)
                // Ta lấy giá trị thô, sau đó gán vào TextBox, sự kiện TextChanged sẽ tự format lại
                string luongStr = row.Cells["colLuong"].Value?.ToString();

                // Mẹo: Gán vào TextBox, hàm TextChanged sẽ tự động thêm dấu chấm
                txtLuongCoBan.Text = luongStr;

                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString();

                // Khóa Mã CV không cho sửa
                txtMaCV.Enabled = false;

                // Bật trạng thái Sửa/Xóa
                SetTrangThaiNut(true);
            }
        }

        // 5. Lấy Mã CV của dòng đang chọn (Dùng cho chức năng Xóa)
        public string GetMaCVDangChon()
        {
            if (dgvChucVu.CurrentRow != null && dgvChucVu.CurrentRow.Index >= 0)
            {
                return dgvChucVu.CurrentRow.Cells["colMaCV"].Value?.ToString();
            }
            return null;
        }

        // =============================================================
        // LOGIC FORMAT TIỀN TỆ (THÊM MỚI)
        // =============================================================

        private void TxtLuongCoBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và phím điều khiển (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLuongCoBan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLuongCoBan.Text)) return;

                // 1. Lưu lại vị trí con trỏ hiện tại (để khi format xong không bị nhảy về đầu dòng)
                int cursorPosition = txtLuongCoBan.SelectionStart;
                int lengthBefore = txtLuongCoBan.Text.Length;

                // 2. Xóa hết dấu chấm/phẩy cũ để lấy số thô
                string rawValue = txtLuongCoBan.Text.Replace(".", "").Replace(",", "");

                // 3. Format lại số theo kiểu Việt Nam (có dấu chấm phân cách ngàn)
                if (long.TryParse(rawValue, out long value))
                {
                    // CultureInfo "vi-VN" dùng dấu chấm để ngăn cách hàng ngàn (1.000.000)
                    // Nếu máy bạn dùng chuẩn Mỹ (dấu phẩy), bạn có thể đổi thành "N0"
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtLuongCoBan.Text = String.Format(culture, "{0:N0}", value);

                    // 4. Tính toán lại vị trí con trỏ sau khi format
                    int lengthAfter = txtLuongCoBan.Text.Length;
                    // Nếu chuỗi dài ra (do thêm dấu chấm), dịch con trỏ sang phải tương ứng
                    txtLuongCoBan.SelectionStart = Math.Max(0, cursorPosition + (lengthAfter - lengthBefore));
                }
            }
            catch
            {
                // Bỏ qua lỗi nếu format thất bại
            }
        }
    }
}