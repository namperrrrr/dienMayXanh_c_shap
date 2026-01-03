using quanLyDienMayXanh.controller.nhansu;
using quanLyDienMayXanh.domain; // Nhớ import cái này để dùng class TaiKhoan
using quanLyDienMayXanh.view;
using System;
using System.Windows.Forms;

namespace quanLyDienMayXanh
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // =============================================================
            // CÁCH 1: CHẠY BÌNH THƯỜNG (CÓ ĐĂNG NHẬP) - ĐANG TẮT
            // =============================================================
            /*
            DangNhapFrame loginView = new DangNhapFrame();
            new DangNhapController(loginView);
            Application.Run(loginView);
            */

            // =============================================================
            // CÁCH 2: CHẠY DEV (VÀO THẲNG MAIN) - ĐANG BẬT
            // =============================================================

            // 1. Tạo một tài khoản Admin "giả" để không bị lỗi null bên Main
            TaiKhoan adminFake = new TaiKhoan();
            adminFake.TenDangNhap = "Developer_Mode";
            adminFake.MatKhau = "123";
            adminFake.CapDoQuyen = 3; // Level 3 (Admin) để hiện full chức năng
            adminFake.MaNV = "DEV001";
            adminFake.TrangThai = "Hoạt động";

            // 2. Chạy thẳng MainForm
            Application.Run(new MainForm(adminFake));
        }
    }
}