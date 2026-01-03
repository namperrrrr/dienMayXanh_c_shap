using quanLyDienMayXanh.Controller;
using quanLyDienMayXanh.domain;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.kho
{
    public partial class FormSanPham : Form
    {
        private SanPhamController controller;
        public FormSanPham()
        {
            InitializeComponent();
            controller = new SanPhamController(this);
        }
        // Hàm lấy dữ liệu từ các ô input để tạo đối tượng SanPham
        public SanPham GetSanPhamFromInput()
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();

            if (cboDanhMuc.SelectedItem != null)
                sp.MaDanhMuc = ((DanhMuc)cboDanhMuc.SelectedItem).MaDanhMuc;

            sp.ThuongHieu = txtThuongHieu.Text.Trim();
            sp.DonViTinh = txtDVT.Text.Trim();

            decimal gNhap = 0; decimal.TryParse(txtGiaNhap.Text, out gNhap);
            sp.GiaNhap = gNhap;

            decimal gBan = 0; decimal.TryParse(txtGiaBan.Text, out gBan);
            sp.GiaBan = gBan;

            int baoHanh = 0; int.TryParse(txtBaoHanh.Text, out baoHanh);
            sp.ThoiGianBaoHanh = baoHanh;

            sp.TrangThaiHang = cboTrangThaiHang.Text;
            sp.MoTa = txtMoTa.Text;
            sp.HinhAnh = txtHinhAnh.Text;

            return sp;
        }

        // Hàm đổ dữ liệu 1 sản phẩm lên input (khi click vào bảng)
        public void FillFormTuBang()
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int index = dgvSanPham.CurrentRow.Index;
                txtMaSP.Text = dgvSanPham.Rows[index].Cells["colMaSP"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[index].Cells["colTenSP"].Value.ToString();

                // Xử lý ComboBox Danh Mục
                string tenDM = dgvSanPham.Rows[index].Cells["colDanhMuc"].Value.ToString();
                // Logic map lại ValueMember (nếu cần) hoặc chỉ hiển thị text
                // Ở đây ta gán Text cho nhanh, Controller sẽ xử lý chọn Item chuẩn
                cboDanhMuc.Text = tenDM;

                txtThuongHieu.Text = dgvSanPham.Rows[index].Cells["colThuongHieu"].Value.ToString();
                txtDVT.Text = dgvSanPham.Rows[index].Cells["colDVT"].Value.ToString();
                txtGiaBan.Text = dgvSanPham.Rows[index].Cells["colGiaBan"].Value.ToString();

                // Các cột ẩn không hiện trên bảng thì cần load lại từ DB hoặc lưu trong Tag nếu muốn chi tiết
                // Tạm thời set enable false cho mã
                SetTrangThaiNut(true);
            }
        }

        public string GetMaSPDangChon()
        {
            if (dgvSanPham.CurrentRow != null)
            {
                return dgvSanPham.CurrentRow.Cells["colMaSP"].Value.ToString();
            }
            return null;
        }

        public void ResetForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtThuongHieu.Clear();
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtBaoHanh.Clear();
            txtMoTa.Clear();
            txtHinhAnh.Clear();
            cboDanhMuc.SelectedIndex = -1;
            cboTrangThaiHang.SelectedIndex = 0;
            txtMaSP.Enabled = true;
            SetTrangThaiNut(false);
        }

        public void SetTrangThaiNut(bool dangChonHang)
        {
            // 1. Xử lý bật/tắt nút (như cũ)
            btnThem.Enabled = !dangChonHang;
            btnSua.Enabled = dangChonHang;
            btnXoa.Enabled = dangChonHang;
            txtMaSP.Enabled = !dangChonHang; // Giữ nguyên logic khóa mã SP khi đang chọn

            // 2. Xử lý màu sắc (Đồng bộ theo FormNhanVien của nhóm trưởng)
            // Nút Thêm: Màu xanh lá (khi active) - Xám (khi disable)
            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;

            // Nút Sửa: Màu vàng (khi active) - Xám (khi disable)
            btnSua.BackColor = dangChonHang ? Color.FromArgb(255, 193, 7) : Color.LightGray;

            // Nút Xóa: Màu đỏ (khi active) - Xám (khi disable)
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
        }

        public void SetDuLieuDanhMuc(List<DanhMuc> list)
        {
            cboDanhMuc.DataSource = new List<DanhMuc>(list); // Clone list để tránh binding chung ref
            cboDanhMuc.DisplayMember = "TenDanhMuc";
            cboDanhMuc.ValueMember = "MaDanhMuc";

            // List lọc
            List<DanhMuc> listLoc = new List<DanhMuc>(list);
            listLoc.Insert(0, new DanhMuc { MaDanhMuc = "", TenDanhMuc = "Tất cả" });
            cboLocDanhMuc.DataSource = listLoc;
            cboLocDanhMuc.DisplayMember = "TenDanhMuc";
            cboLocDanhMuc.ValueMember = "MaDanhMuc";
        }
    }
}

