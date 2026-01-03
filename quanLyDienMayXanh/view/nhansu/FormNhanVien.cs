using quanLyDienMayXanh.Controller; // Kết nối Controller
using quanLyDienMayXanh.domain;   // Kết nối Domain Object
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.nhansu
{
    public partial class FormNhanVien : Form
    {
        private NhanVienController controller;

        public FormNhanVien()
        {
            InitializeComponent();

            // Khởi tạo Controller và truyền Form này vào
            // Controller sẽ tự động load danh sách chức vụ và nhân viên
            controller = new NhanVienController(this);
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // Các setup khác nếu cần
        }

        // =============================================================
        // 1. CÁC HÀM HỖ TRỢ GIAO DIỆN (VIEW LOGIC)
        // =============================================================

        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;

            // Đổi màu nút cho đẹp
            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray; // Xanh
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;   // Vàng
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;   // Đỏ
        }

        public void ResetForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";

            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;

            // Không xóa items của cboChucVu, chỉ chọn lại dòng đầu tiên
            if (cboChucVu.Items.Count > 0) cboChucVu.SelectedIndex = 0;

            txtMaNV.Enabled = true;
            txtMaNV.Focus();

            SetTrangThaiNut(false);
            dgvNhanVien.ClearSelection();
        }

        // =============================================================
        // 2. CÁC HÀM TRAO ĐỔI DỮ LIỆU VỚI CONTROLLER
        // =============================================================

        // Hàm này được Controller gọi để đổ danh sách Chức Vụ vào ComboBox
        public void SetDuLieuChucVu(List<ChucVu> listCV)
        {
            cboChucVu.DataSource = null; // Reset
            cboChucVu.DataSource = listCV;
            cboChucVu.DisplayMember = "TenCV"; // Hiển thị Tên
            cboChucVu.ValueMember = "MaCV";    // Giá trị ngầm là Mã
        }

        public NhanVien GetNhanVienFromInput()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text.Trim();
            nv.HoTen = txtHoTen.Text.Trim();
            nv.Sdt = txtSDT.Text.Trim();
            nv.Email = txtEmail.Text.Trim();

            // Lấy giới tính
            nv.GioiTinh = cboGioiTinh.SelectedItem != null ? cboGioiTinh.SelectedItem.ToString() : "Nam";

            // Lấy Mã Chức Vụ từ ValueMember của ComboBox (Quan trọng)
            if (cboChucVu.SelectedValue != null)
            {
                nv.MaCV = cboChucVu.SelectedValue.ToString();
            }
            else
            {
                nv.MaCV = ""; // Xử lý nếu chưa chọn gì
            }

            return nv;
        }

        public void FillFormTuBang()
        {
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.Index >= 0)
            {
                int row = dgvNhanVien.CurrentRow.Index;

                txtMaNV.Text = dgvNhanVien.Rows[row].Cells["colMaNV"].Value?.ToString();
                txtMaNV.Enabled = false; // Không cho sửa Mã NV

                txtHoTen.Text = dgvNhanVien.Rows[row].Cells["colHoTen"].Value?.ToString();
                cboGioiTinh.Text = dgvNhanVien.Rows[row].Cells["colGioiTinh"].Value?.ToString();

                // Chọn Chức vụ trong ComboBox dựa vào Mã hiển thị trên bảng
                string maCV = dgvNhanVien.Rows[row].Cells["colChucVu"].Value?.ToString();
                cboChucVu.SelectedValue = maCV;

                txtSDT.Text = dgvNhanVien.Rows[row].Cells["colSDT"].Value?.ToString();
                txtEmail.Text = dgvNhanVien.Rows[row].Cells["colEmail"].Value?.ToString();

                SetTrangThaiNut(true); // Chuyển sang chế độ Sửa/Xóa
            }
        }

        public string GetMaNVDangChon()
        {
            if (dgvNhanVien.CurrentRow != null && dgvNhanVien.CurrentRow.Index >= 0)
            {
                return dgvNhanVien.CurrentRow.Cells["colMaNV"].Value?.ToString();
            }
            return null;
        }
    }
}