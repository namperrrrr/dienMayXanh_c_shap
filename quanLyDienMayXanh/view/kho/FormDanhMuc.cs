using quanLyDienMayXanh.controller.kho;
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

            // Khởi tạo Controller và truyền Form hiện tại vào
            controller = new DanhMucController(this);

            ResetForm();
        }

        // ===========================================
        // CÁC HÀM API CHO CONTROLLER GỌI
        // ===========================================

        // 1. Lấy dữ liệu từ ô nhập
        public DanhMuc GetDanhMucFromInput()
        {
            DanhMuc dm = new DanhMuc();
            dm.MaDanhMuc = txtMaDM.Text.Trim();
            dm.TenDanhMuc = txtTenDM.Text.Trim();
            return dm;
        }

        // 2. Đổ dữ liệu từ bảng lên ô nhập
        public void FillFormTuBang()
        {
            if (dgvDanhMuc.CurrentRow != null && dgvDanhMuc.CurrentRow.Index >= 0)
            {
                DataGridViewRow row = dgvDanhMuc.CurrentRow;
                // Lấy dữ liệu từ DataPropertyName hoặc Cells index
                // Lưu ý: Đảm bảo DataPropertyName trong Designer khớp với Class Domain
                txtMaDM.Text = row.Cells["colMaDM"].Value?.ToString();
                txtTenDM.Text = row.Cells["colTenDM"].Value?.ToString();

                // Chế độ xem/sửa: Khóa Mã, mở nút Sửa/Xóa
                txtMaDM.Enabled = false;
                SetTrangThaiNut(true);
            }
        }

        // 3. Reset form về trạng thái thêm mới
        public void ResetForm()
        {
            txtMaDM.Clear();
            txtTenDM.Clear();

            txtMaDM.Enabled = true; // Cho nhập lại mã
            txtMaDM.Focus();

            dgvDanhMuc.ClearSelection();
            SetTrangThaiNut(false);
        }

        // 4. Lấy mã đang chọn để xóa
        public string GetMaDMDangChon()
        {
            if (dgvDanhMuc.CurrentRow != null)
            {
                return dgvDanhMuc.CurrentRow.Cells["colMaDM"].Value?.ToString();
            }
            return null;
        }

        // 5. Điều khiển trạng thái nút bấm và màu sắc
        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;

            // Đổi màu cho đồng bộ với FormChucVu và FormSanPham
            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
        }
    }
}