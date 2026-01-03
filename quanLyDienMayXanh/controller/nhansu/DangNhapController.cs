using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.model.nhansu;
using quanLyDienMayXanh.view;
using System;
using System.Windows.Forms;

namespace quanLyDienMayXanh.controller.nhansu
{
    public class DangNhapController
    {
        private DangNhapFrame view;
        private TaiKhoanDAO dao;

        public DangNhapController(DangNhapFrame view)
        {
            this.view = view;
            this.dao = new TaiKhoanDAO();

            // Đăng ký sự kiện
            this.view.btnLogin.Click += XuLyDangNhap;
            this.view.btnExit.Click += (s, e) => Application.Exit();

            this.view.chkShowPass.CheckedChanged += (s, e) => {
                view.txtPass.PasswordChar = view.chkShowPass.Checked ? '\0' : '*';
            };

            this.view.lblQuenMatKhau.Click += (s, e) => view.ShowChangePassForm();
            this.view.btnConfirm.Click += XuLyDoiMatKhau;
            this.view.btnBack.Click += (s, e) => view.ShowLoginForm();
        }

        // ========================================================
        // LOGIC ĐĂNG NHẬP (ẨN LOGIN -> HIỆN MAIN)
        // ========================================================
        private void XuLyDangNhap(object sender, EventArgs e)
        {
            string user = view.txtUser.Text.Trim();
            string pass = view.txtPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoan tk = dao.CheckLogin(user, pass);

            // Trong hàm XuLyDangNhap
            if (tk != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                view.Hide(); // Ẩn Login

                MainForm main = new MainForm(tk);

                // Treo code ở đây chờ Main đóng
                main.ShowDialog();

                // --- KHI MAIN ĐÓNG, KIỂM TRA LÝ DO ---

                // Nếu Form đóng vì bấm nút Đăng xuất (DialogResult là OK)
                if (main.DialogResult == DialogResult.OK)
                {
                    view.Show();
                    view.ShowLoginForm();
                    view.txtUser.Focus();
                    view.txtPass.Text = "";
                }
                // Nếu Form đóng vì bấm nút X (DialogResult là Cancel - mặc định)
                else
                {
                    Application.Exit(); // Tắt toàn bộ ứng dụng luôn
                }
            }
        }

        // --- XỬ LÝ ĐỔI MẬT KHẨU ---
        private void XuLyDoiMatKhau(object sender, EventArgs e)
        {
            string user = view.txtUserChange.Text.Trim();
            string oldPass = view.txtOldPass.Text.Trim();
            string newPass = view.txtNewPass.Text.Trim();
            string confirmPass = view.txtConfirmPass.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (!newPass.Equals(confirmPass))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            TaiKhoan check = dao.CheckLogin(user, oldPass);
            if (check == null)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (dao.ResetPassword(user, newPass) > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại.");
                view.ShowLoginForm();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}