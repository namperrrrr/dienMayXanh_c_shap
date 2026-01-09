using quanLyDienMayXanh.Controller;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.kho
{
    public partial class FormDanhMuc : Form
    {
        private DanhMucController controller;

        public FormDanhMuc()
        {
            InitializeComponent();
            controller = new DanhMucController(this);

            // Đăng ký sự kiện
            btnThem.Click += (s, e) => controller.Add();
            btnSua.Click += (s, e) => controller.Update();
            btnXoa.Click += (s, e) => controller.Delete();
            btnLamMoi.Click += (s, e) => ResetForm();
            btnTimKiem.Click += (s, e) => controller.Search(txtTimKiem.Text.Trim());

            dgvDanhMuc.CellClick += DgvDanhMuc_CellClick;

            ResetForm();
        }

        private void DgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDanhMuc.CurrentRow != null)
            {
                txtMaDanhMuc.Text = dgvDanhMuc.CurrentRow.Cells["colMaDanhMuc"].Value?.ToString();
                txtTenDanhMuc.Text = dgvDanhMuc.CurrentRow.Cells["colTenDanhMuc"].Value?.ToString();

                // Khóa mã khi chọn
                txtMaDanhMuc.Enabled = false;
                SetTrangThaiNut(true);
            }
        }

        public DanhMuc GetDanhMucFromInput()
        {
            return new DanhMuc
            {
                MaDanhMuc = txtMaDanhMuc.Text.Trim(),
                TenDanhMuc = txtTenDanhMuc.Text.Trim()
            };
        }

        public string GetMaDMDangChon()
        {
            if (dgvDanhMuc.CurrentRow != null)
            {
                return dgvDanhMuc.CurrentRow.Cells["colMaDanhMuc"].Value.ToString();
            }
            return null;
        }

        public void ResetForm()
        {
            txtMaDanhMuc.Clear();
            txtTenDanhMuc.Clear();
            txtTimKiem.Clear();

            txtMaDanhMuc.Enabled = true; // Mở lại ô mã

            controller.LoadList();
            SetTrangThaiNut(false);
        }

        // Logic đổi màu nút y hệt form Nhân sự
        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;

            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
        }
    }
}