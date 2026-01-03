using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.model.nhansu;
using quanLyDienMayXanh.view.nhansu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.controller.nhansu
{
    internal class TaiKhoanController
    {
        private FormTaiKhoan view;
        private TaiKhoanDAO tkDao;
        private NhanVienDAO nvDao;

        // Cache danh sách nhân viên để tìm kiếm nhanh
        private List<NhanVien> listNhanVienCache;

        public TaiKhoanController(FormTaiKhoan view)
        {
            this.view = view;
            this.tkDao = new TaiKhoanDAO();
            this.nvDao = new NhanVienDAO();

            // Load cache nhân viên ngay khi khởi tạo
            this.listNhanVienCache = nvDao.GetAll();

            // --- ĐĂNG KÝ SỰ KIỆN (Events) ---

            // 1. Sự kiện nút bấm
            this.view.btnThem.Click += XuLyThem;
            this.view.btnSua.Click += XuLySua;
            this.view.btnXoa.Click += XuLyXoa;
            this.view.btnLamMoi.Click += XuLyLamMoi;

            // 2. Sự kiện click bảng (Fill form + Xóa trắng mật khẩu)
            this.view.dgvTaiKhoan.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    view.FillFormTuBang();
                    // Xóa trắng ô mật khẩu để ám chỉ: "Nhập thì đổi, không nhập thì giữ nguyên"
                    view.txtMatKhau.Text = "";
                }
            };

            // 3. Sự kiện tìm kiếm gợi ý (Khi gõ vào ô Mã NV)
            this.view.txtMaNV.TextChanged += (sender, e) =>
            {
                string input = view.txtMaNV.Text.Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    // Logic tìm kiếm: Không hiển thị gợi ý nếu đang click chọn từ bảng
                    // (Tránh việc click bảng -> điền text -> lại hiện gợi ý đè lên)
                    if (view.txtMaNV.Enabled)
                    {
                        List<string> suggestions = TimKiemMaNV(input);
                        view.HienThiGoiY(suggestions);
                    }
                }
            };

            // Nếu click chuột ra ngoài thì ẩn popup gợi ý (Optional logic)
            this.view.Click += (s, e) => view.popupGoiY.Hide();

            // Load dữ liệu ban đầu
            LoadData();
        }

        // --- CÁC HÀM LOGIC BỔ TRỢ ---

        private List<string> TimKiemMaNV(string keyword)
        {
            List<string> ketQua = new List<string>();
            string keywordLower = keyword.ToLower();

            // Reload cache nếu null (phòng hờ)
            if (listNhanVienCache == null || listNhanVienCache.Count == 0)
            {
                listNhanVienCache = nvDao.GetAll();
            }

            foreach (NhanVien nv in listNhanVienCache)
            {
                if (nv.MaNV.ToLower().Contains(keywordLower) ||
                    nv.HoTen.ToLower().Contains(keywordLower))
                {
                    ketQua.Add(nv.MaNV + " - " + nv.HoTen);
                }
            }
            return ketQua;
        }

        public void LoadData()
        {
            view.dgvTaiKhoan.Rows.Clear();
            List<TaiKhoan> list = tkDao.GetAll();

            foreach (TaiKhoan tk in list)
            {
                string quyenHienThi;
                switch (tk.CapDoQuyen)
                {
                    case 3: quyenHienThi = "Admin (Level 3)"; break;
                    case 2: quyenHienThi = "Quản lý (Level 2)"; break;
                    default: quyenHienThi = "Nhân viên"; break;
                }

                view.dgvTaiKhoan.Rows.Add(
                    tk.TenDangNhap,
                    tk.MaNV,
                    quyenHienThi,
                    tk.TrangThai
                );
            }
        }

        private string ExtractMaNV(string rawInput)
        {
            if (!string.IsNullOrEmpty(rawInput) && rawInput.Contains(" - "))
            {
                return rawInput.Split(new string[] { " - " }, StringSplitOptions.None)[0].Trim();
            }
            return rawInput != null ? rawInput.Trim() : "";
        }

        // --- CÁC HÀM XỬ LÝ SỰ KIỆN CHÍNH ---

        private void XuLyLamMoi(object sender, EventArgs e)
        {
            view.ResetForm();
            // Cập nhật lại cache nhân viên (phòng trường hợp có NV mới thêm)
            listNhanVienCache = nvDao.GetAll();
            LoadData();
        }

        private void XuLyThem(object sender, EventArgs e)
        {
            TaiKhoan tk = view.GetTaiKhoanFromInput();
            tk.MaNV = ExtractMaNV(tk.MaNV);

            // Validate
            if (string.IsNullOrEmpty(tk.TenDangNhap) || string.IsNullOrEmpty(tk.MatKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check mã NV tồn tại
            if (!nvDao.CheckTrungMa(tk.MaNV))
            {
                MessageBox.Show($"Mã nhân viên [{tk.MaNV}] không tồn tại trong hồ sơ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check trùng username
            if (tkDao.CheckTrungUsername(tk.TenDangNhap))
            {
                MessageBox.Show($"Tên đăng nhập [{tk.TenDangNhap}] đã được sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tkDao.Insert(tk) > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadData();
                view.ResetForm();
            }
        }

        private void XuLySua(object sender, EventArgs e)
        {
            // Kiểm tra chọn dòng
            string userCu = view.GetUsernameCu();
            if (string.IsNullOrEmpty(userCu))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa!");
                return;
            }

            TaiKhoan tkMoi = view.GetTaiKhoanFromInput();
            tkMoi.MaNV = ExtractMaNV(tkMoi.MaNV);
            string passMoi = tkMoi.MatKhau.Trim(); // Lấy mật khẩu từ ô nhập

            // 1. LOGIC BẢO VỆ ADMIN CUỐI CÙNG
            // Lấy quyền hiện tại từ bảng (cột index 2)
            string quyenCuStr = view.dgvTaiKhoan.CurrentRow.Cells["colQuyen"].Value.ToString();
            bool isCurrentAdmin = quyenCuStr.Contains("Admin") || quyenCuStr.Contains("Level 3");

            if (isCurrentAdmin)
            {
                if (tkDao.GetSoLuongAdmin() <= 1)
                {
                    // Nếu là Admin cuối cùng -> Cấm hạ quyền hoặc khóa
                    if (tkMoi.CapDoQuyen != 3 || tkMoi.TrangThai == "Đã khóa")
                    {
                        MessageBox.Show("CẢNH BÁO: Đây là tài khoản Admin duy nhất đang hoạt động.\nKhông thể hạ quyền hoặc khóa tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            // 2. CHECK TRÙNG USERNAME (Nếu đổi tên đăng nhập)
            if (!tkMoi.TenDangNhap.Equals(userCu))
            {
                if (tkDao.CheckTrungUsername(tkMoi.TenDangNhap))
                {
                    MessageBox.Show("Tên đăng nhập mới đã tồn tại, vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 3. THỰC HIỆN UPDATE
            // B1: Update thông tin chung
            bool kqUpdateInfo = tkDao.Update(tkMoi, userCu) > 0;

            // B2: Update mật khẩu (CHỈ KHI có nhập vào ô mật khẩu)
            bool kqUpdatePass = false;
            if (!string.IsNullOrEmpty(passMoi))
            {
                if (tkDao.ResetPassword(tkMoi.TenDangNhap, passMoi) > 0)
                {
                    kqUpdatePass = true;
                }
            }
            else
            {
                kqUpdatePass = true; // Không đổi pass thì coi như thành công
            }

            if (kqUpdateInfo && kqUpdatePass)
            {
                string msg = string.IsNullOrEmpty(passMoi) ? "Cập nhật thông tin thành công!" : "Cập nhật thông tin và đổi mật khẩu thành công!";
                MessageBox.Show(msg);
                LoadData();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLyXoa(object sender, EventArgs e)
        {
            string user = view.GetUsernameDangChon();
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
                return;
            }

            // 1. Logic bảo vệ Admin
            string quyenHienTai = view.dgvTaiKhoan.CurrentRow.Cells["colQuyen"].Value.ToString();
            if (quyenHienTai.Contains("Admin"))
            {
                if (tkDao.GetSoLuongAdmin() <= 1)
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!\nĐây là tài khoản Admin cuối cùng của hệ thống.", "Cấm", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản [{user}] không?\nHành động này không thể hoàn tác.", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (tkDao.Delete(user) > 0)
                {
                    MessageBox.Show("Đã xóa tài khoản thành công!");
                    LoadData();
                    view.ResetForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm Reset mật khẩu riêng (Nếu cần dùng nút riêng, hiện tại đã gộp vào Sửa)
        public void XuLyResetPass()
        {
            string user = view.GetUsernameDangChon();
            if (string.IsNullOrEmpty(user)) return;

            // Dùng InputBox giả lập (C# không có sẵn InputBox xịn như Java)
            string newPass = Microsoft.VisualBasic.Interaction.InputBox($"Nhập mật khẩu mới cho user [{user}]:", "Reset Password", "");

            if (!string.IsNullOrWhiteSpace(newPass))
            {
                if (tkDao.ResetPassword(user, newPass.Trim()) > 0)
                {
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
        }
    }
}
