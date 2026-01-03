using quanLyDienMayXanh.Controller.kho;
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
    public partial class FormNhapKho : Form
    {
        private PhieuNhapController controller;
        private string idDangChon = null; // Lưu ID dòng đang chọn để xóa
        public FormNhapKho()
        {
            InitializeComponent();
            // Cấu hình DataGridView
            dgvPhieuNhap.AutoGenerateColumns = false;

            // Gọi Controller
            controller = new PhieuNhapController(this);

            // Sự kiện tính tiền tự động
            txtSoLuongNhap.TextChanged += TinhThanhTien;
            txtDonGia.TextChanged += TinhThanhTien;
        }
        public void SetDuLieuSanPham(List<SanPham> list)
        {
            cboSanPham.DataSource = list;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.SelectedIndex = -1;
        }

        public void SetDuLieuNCC(List<NhaCungCap> list)
        {
            cboNhaCungCap.DataSource = list;
            cboNhaCungCap.DisplayMember = "TenNCC";
            cboNhaCungCap.ValueMember = "MaNCC";
        }

        public void SetDuLieuNhanVien(List<NhanVien> list)
        {
            cboNhanVien.DataSource = list;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedItem != null)
            {
                SanPham sp = (SanPham)cboSanPham.SelectedItem;
                txtTonHienTai.Text = sp.TonKho.ToString();
            }
            else
            {
                txtTonHienTai.Text = "0";
            }
        }
        private void TinhThanhTien(object sender, EventArgs e)
        {
            decimal sl = 0, gia = 0;
            decimal.TryParse(txtSoLuongNhap.Text, out sl);
            decimal.TryParse(txtDonGia.Text, out gia);
            txtThanhTien.Text = (sl * gia).ToString("N0"); // Format số đẹp
        }
        public PhieuNhap GetPhieuNhapFromInput()
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieu = txtMaPhieu.Text.Trim();

            if (cboNhanVien.SelectedValue == null) { MessageBox.Show("Chưa chọn nhân viên"); return null; }
            pn.MaNV = cboNhanVien.SelectedValue.ToString();

            if (cboNhaCungCap.SelectedValue == null) { MessageBox.Show("Chưa chọn nhà cung cấp"); return null; }
            pn.MaNCC = cboNhaCungCap.SelectedValue.ToString();

            if (cboSanPham.SelectedValue == null) { MessageBox.Show("Chưa chọn sản phẩm"); return null; }
            pn.MaSP = cboSanPham.SelectedValue.ToString();

            int sl = 0;
            if (!int.TryParse(txtSoLuongNhap.Text, out sl) || sl <= 0) { MessageBox.Show("Số lượng nhập phải > 0"); return null; }
            pn.SoLuong = sl;

            decimal gia = 0;
            decimal.TryParse(txtDonGia.Text, out gia);
            pn.DonGia = gia;

            decimal tt = 0;
            decimal.TryParse(txtThanhTien.Text, out tt);
            pn.ThanhTien = tt;

            pn.GhiChu = txtGhiChu.Text;

            return pn;
        }

        public void ResetForm()
        {
            txtMaPhieu.Clear();
            cboSanPham.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtTonHienTai.Text = "0";
            txtSoLuongNhap.Text = "0";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            txtGhiChu.Clear();
            idDangChon = null;

            SetTrangThaiNut(false);
        }

        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnXoa.Enabled = dangChonHang;

            // MỞ khóa nút Sửa khi đang chọn hàng
            btnSua.Enabled = dangChonHang;

            // Màu sắc nút
            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
            // Thêm màu cho nút Sửa (ví dụ màu cam)
            btnSua.BackColor = dangChonHang ? Color.Orange : Color.LightGray;

            // --- LOGIC QUAN TRỌNG: KHÓA/MỞ Ô NHẬP LIỆU ---

            // Các thông tin KHÔNG được sửa khi đang chọn phiếu (để đảm bảo toàn vẹn dữ liệu)
            cboSanPham.Enabled = !dangChonHang;     // Không cho đổi sản phẩm
            cboNhaCungCap.Enabled = !dangChonHang;  // Không cho đổi NCC
            cboNhanVien.Enabled = !dangChonHang;    // Không cho đổi nhân viên
            txtMaPhieu.Enabled = !dangChonHang;     // Không cho sửa mã phiếu

            // Các thông tin ĐƯỢC PHÉP sửa
            // Luôn luôn cho phép nhập liệu ở các ô này (dù là Thêm mới hay Sửa)
            txtSoLuongNhap.Enabled = true;
            txtDonGia.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        public string GetIDPhieuDangChon() => idDangChon;

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];

                // Ép kiểu dữ liệu của dòng đang chọn về đối tượng PhieuNhap
                // Cách này an toàn tuyệt đối, không lo sai tên cột trên giao diện
                if (row.DataBoundItem is PhieuNhap pn)
                {
                    // 1. Lưu ID để dùng cho việc Xóa
                    idDangChon = pn.ID.ToString();

                    // 2. Đổ dữ liệu lên các ô nhập liệu
                    txtMaPhieu.Text = pn.MaPhieu;

                    // ComboBox sẽ tự nhảy về mục có ValueMember trùng khớp
                    cboNhanVien.SelectedValue = pn.MaNV;
                    cboNhaCungCap.SelectedValue = pn.MaNCC;
                    cboSanPham.SelectedValue = pn.MaSP;

                    txtSoLuongNhap.Text = pn.SoLuong.ToString();

                    // Format đơn giá về dạng số hoặc để nguyên tùy ý
                    txtDonGia.Text = pn.DonGia.ToString("0.##");

                    // Thành tiền sẽ tự nhảy nhờ sự kiện TextChanged của DonGia/SoLuong
                    // Hoặc gán trực tiếp:
                    txtThanhTien.Text = pn.ThanhTien.ToString("N0");

                    txtGhiChu.Text = pn.GhiChu;

                    // 3. Bật sáng các nút chức năng
                    SetTrangThaiNut(true);
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            controller.ThemPhieu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            controller.XoaPhieu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            controller.LoadData();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            controller.SuaPhieu();
        }
    }
}
