using quanLyDienMayXanh.Controller.kho;
using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quanLyDienMayXanh.view.kho
{
    public partial class FormNhapKho : Form
    {
        private PhieuNhapController controller;
        private string idDangChon = null;
        private TaiKhoan taiKhoanHienTai; // Biến lưu tài khoản đăng nhập

        // Constructor nhận tham số TaiKhoan từ MainForm
        public FormNhapKho(TaiKhoan tk)
        {
            InitializeComponent();
            this.taiKhoanHienTai = tk; // Lưu tài khoản

            dgvPhieuNhap.AutoGenerateColumns = false;
            controller = new PhieuNhapController(this);

            // Event tính tổng tiền
            dgvPhieuNhap.DataBindingComplete += (s, e) => CapNhatTongTienNhap();

            // Hiển thị thông tin nhân viên đang đăng nhập ngay khi mở
            SetThongTinNhanVien();

            SetTrangThaiNut(false);
        }

        // Hàm hiển thị thông tin nhân viên lên TextBox (chỉ đọc)
        private void SetThongTinNhanVien()
        {
            if (taiKhoanHienTai != null)
            {
                // Hiển thị tên đăng nhập hoặc Mã NV. 
                // Nếu bạn muốn hiển thị Họ Tên đầy đủ, cần query thêm từ CSDL hoặc lưu trong TaiKhoan
                txtNhanVien.Text = string.IsNullOrEmpty(taiKhoanHienTai.MaNV)
                                    ? taiKhoanHienTai.TenDangNhap
                                    : taiKhoanHienTai.MaNV;
            }
        }

        private void CapNhatTongTienNhap()
        {
            decimal tongTien = 0;
            if (dgvPhieuNhap.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPhieuNhap.Rows)
                {
                    if (row.Cells["colThanhTien"].Value != null)
                    {
                        decimal val;
                        decimal.TryParse(row.Cells["colThanhTien"].Value.ToString(), out val);
                        tongTien += val;
                    }
                }
            }
            lblTongTienNhap.Text = "Tổng tiền nhập: " + tongTien.ToString("N0") + " VND";
        }

        public void SetDuLieuSanPham(List<SanPham> list)
        {
            cboSanPham.DataSource = list;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
            cboSanPham.SelectedIndex = -1;
        }

        // Hàm này giữ lại để tránh lỗi nếu Controller gọi, nhưng để rỗng vì không dùng ComboBox nữa
        public void SetDuLieuNhanVien(List<NhanVien> list)
        {
            // Không làm gì cả
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

        public PhieuNhap GetPhieuNhapFromInput()
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieu = txtMaPhieu.Text.Trim();

            // LOGIC MỚI: Lấy MaNV từ tài khoản đăng nhập, không lấy từ input
            if (taiKhoanHienTai == null || string.IsNullOrEmpty(taiKhoanHienTai.MaNV))
            {
                MessageBox.Show("Lỗi: Không xác định được nhân viên thực hiện!");
                return null;
            }
            pn.MaNV = taiKhoanHienTai.MaNV;

            if (string.IsNullOrWhiteSpace(txtNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");
                return null;
            }
            pn.TenNCC = txtNhaCungCap.Text.Trim();

            if (cboSanPham.SelectedValue == null) { MessageBox.Show("Chưa chọn sản phẩm"); return null; }
            pn.MaSP = cboSanPham.SelectedValue.ToString();

            int sl = 0;
            if (!int.TryParse(txtSoLuongNhap.Text, out sl) || sl <= 0) { MessageBox.Show("Số lượng nhập phải > 0"); return null; }
            pn.SoLuong = sl;

            decimal gia = 0;
            decimal.TryParse(txtDonGia.Text, out gia);
            pn.DonGia = gia;
            pn.ThanhTien = sl * gia;
            pn.GhiChu = txtGhiChu.Text;

            return pn;
        }

        public void ResetForm()
        {
            txtMaPhieu.Clear();
            cboSanPham.SelectedIndex = -1;
            txtNhaCungCap.Clear();

            // Reset về nhân viên đang đăng nhập
            SetThongTinNhanVien();

            txtTonHienTai.Text = "0";
            txtSoLuongNhap.Text = "0";
            txtDonGia.Text = "0";
            txtGhiChu.Clear();
            idDangChon = null;

            SetTrangThaiNut(false);
        }

        public void SetTrangThaiNut(bool dangChonHang)
        {
            btnThem.Enabled = !dangChonHang;
            btnXoa.Enabled = dangChonHang;
            btnSua.Enabled = dangChonHang;

            btnThem.BackColor = !dangChonHang ? Color.FromArgb(76, 175, 80) : Color.LightGray;
            btnXoa.BackColor = dangChonHang ? Color.FromArgb(244, 67, 54) : Color.LightGray;
            btnSua.BackColor = dangChonHang ? Color.Orange : Color.LightGray;

            cboSanPham.Enabled = !dangChonHang;
            txtNhaCungCap.Enabled = !dangChonHang;

            // Không cần xử lý enable cho txtNhanVien vì nó luôn ReadOnly

            txtMaPhieu.Enabled = !dangChonHang;

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

                if (row.DataBoundItem is PhieuNhap pn)
                {
                    idDangChon = pn.ID.ToString();

                    txtMaPhieu.Text = pn.MaPhieu;

                    // Khi xem phiếu cũ, hiển thị Mã NV của người tạo phiếu đó
                    txtNhanVien.Text = pn.MaNV;

                    txtNhaCungCap.Text = pn.TenNCC;

                    cboSanPham.SelectedValue = pn.MaSP;
                    txtSoLuongNhap.Text = pn.SoLuong.ToString();
                    txtDonGia.Text = pn.DonGia.ToString("0.##");
                    txtGhiChu.Text = pn.GhiChu;

                    SetTrangThaiNut(true);
                }
            }
        }

        // Các event click nút
        private void btnThem_Click(object sender, EventArgs e) { 
            controller.ThemPhieu();
        }
        private void btnXoa_Click(object sender, EventArgs e) { 
            controller.XoaPhieu(); 
        }

        // Nút làm mới sẽ gọi ResetForm -> Tự động điền lại tên NV đăng nhập
        private void btnLamMoi_Click(object sender, EventArgs e) { 
            ResetForm(); 
            controller.LoadData(); 
        }

        private void btnThoat_Click(object sender, EventArgs e) { 
            this.Close(); 
        }
        private void btnSua_Click(object sender, EventArgs e) {
            controller.SuaPhieu(); 
        }
    }
}