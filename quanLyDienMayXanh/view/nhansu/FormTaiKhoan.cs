using quanLyDienMayXanh.controller.nhansu;
using quanLyDienMayXanh.controller; // Kết nối với Controller
using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.domain;    // Kết nối với Domain Object
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.nhansu
{
    public partial class FormTaiKhoan : Form
    {
        private TaiKhoanController controller;
        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new TaiKhoanController(this);
            ResetForm();
        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            // Có thể load thêm dữ liệu phụ nếu cần (VD: Combobox nâng cao)
        }
        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;

            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
        }
        public void ResetForm()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
            txtMaNV.Text = "";

            if (cboQuyen.Items.Count > 0) cboQuyen.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            txtTenDangNhap.Enabled = true; // Cho phép nhập User
            txtMaNV.Enabled = true;        // Cho phép nhập Mã NV

            SetTrangThaiNut(false); // Về trạng thái chờ Thêm
            dgvTaiKhoan.ClearSelection();
        }
        public TaiKhoan GetTaiKhoanFromInput()
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = txtTenDangNhap.Text.Trim();
            tk.MatKhau = txtMatKhau.Text.Trim();
            tk.MaNV = txtMaNV.Text.Trim();

            string quyenStr = cboQuyen.SelectedItem?.ToString() ?? "";
            if (quyenStr.Contains("Admin")) tk.CapDoQuyen = 3;
            else if (quyenStr.Contains("Quản lý")) tk.CapDoQuyen = 2;
            else tk.CapDoQuyen = 1; // Mặc định là Nhân viên

            tk.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Hoạt động";

            return tk;
        }
        public void FillFormTuBang()
        {
            if (dgvTaiKhoan.CurrentRow != null && dgvTaiKhoan.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.CurrentRow;

                txtTenDangNhap.Text = row.Cells["colUser"].Value?.ToString();
                txtMaNV.Text = row.Cells["colMaNV"].Value?.ToString();

                string quyenHienThi = row.Cells["colQuyen"].Value?.ToString(); // VD: "Admin (Level 3)"
                foreach (var item in cboQuyen.Items)
                {
                    if (quyenHienThi.Contains("Admin") && item.ToString().Contains("Admin"))
                    {
                        cboQuyen.SelectedItem = item; break;
                    }
                    else if (quyenHienThi.Contains("Quản lý") && item.ToString().Contains("Quản lý"))
                    {
                        cboQuyen.SelectedItem = item; break;
                    }
                    else if (quyenHienThi.Contains("Nhân viên") && item.ToString().Contains("Nhân viên"))
                    {
                        cboQuyen.SelectedItem = item; break;
                    }
                }
                string trangThai = row.Cells["colTrangThai"].Value?.ToString();
                cboTrangThai.SelectedItem = trangThai;
                SetTrangThaiNut(true);
            }
        }
        public void HienThiGoiY(List<string> suggestions)
        {
            popupGoiY.Items.Clear(); 

            if (suggestions == null || suggestions.Count == 0) return;

            foreach (string s in suggestions)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(s);
                item.Click += (sender, e) => {
                    // VD: "NV01 - Nguyen Van A" -> Lấy "NV01"
                    if (s.Contains(" - "))
                        txtMaNV.Text = s.Split(new string[] { " - " }, StringSplitOptions.None)[0];
                    else
                        txtMaNV.Text = s;
                };
                popupGoiY.Items.Add(item);
            }
            popupGoiY.Show(txtMaNV, 0, txtMaNV.Height);
            txtMaNV.Focus();
        }

        public string GetUsernameDangChon()
        {
            if (dgvTaiKhoan.CurrentRow != null && dgvTaiKhoan.CurrentRow.Index >= 0)
            {
                return dgvTaiKhoan.CurrentRow.Cells["colUser"].Value?.ToString();
            }
            return null;
        }
        public string GetUsernameCu()
        {
            return GetUsernameDangChon();
        }
    }
}