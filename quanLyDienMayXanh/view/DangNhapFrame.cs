using quanLyDienMayXanh.controller.nhansu; // Import Controller
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view
{
    public partial class DangNhapFrame : Form
    {
        private DangNhapController controller;

        public DangNhapFrame()
        {
            InitializeComponent();
        }

        // ========================================================
        // VIEW LOGIC (API CHO CONTROLLER)
        // ========================================================

        public void ShowChangePassForm()
        {
            // Auto fill username nếu đã nhập bên login
            txtUserChange.Text = txtUser.Text.Trim();

            // Xóa trắng các ô pass
            txtOldPass.Text = "";
            txtNewPass.Text = "";
            txtConfirmPass.Text = "";

            pnlLogin.Visible = false;
            pnlChangePass.Visible = true;
            pnlChangePass.BringToFront();
        }

        public void ShowLoginForm()
        {
            txtPass.Text = ""; // Xóa pass login cũ

            pnlChangePass.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }
    }
}