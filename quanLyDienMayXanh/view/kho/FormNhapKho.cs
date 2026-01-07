using quanLyDienMayXanh.Controller.kho;
using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.domain.kho;
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

            // Sự kiện cập nhật tổng tiền mỗi khi lưới dữ liệu thay đổi (Load/Thêm/Xóa)
            dgvPhieuNhap.DataBindingComplete += (s, e) => CapNhatTongTienNhap();
        }

        // --- HÀM TÍNH TỔNG TIỀN MỚI THÊM ---
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

        // Đã bỏ hàm TinhThanhTien (vì không còn ô textbox để hiển thị)

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

            // LOGIC MỚI: Tự tính thành tiền ở đây
            pn.ThanhTien = sl * gia;

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
            // txtThanhTien.Text = "0"; // Đã bỏ
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
            cboNhaCungCap.Enabled = !dangChonHang;
            cboNhanVien.Enabled = !dangChonHang;
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
                    cboNhanVien.SelectedValue = pn.MaNV;
                    cboNhaCungCap.SelectedValue = pn.MaNCC;
                    cboSanPham.SelectedValue = pn.MaSP;

                    txtSoLuongNhap.Text = pn.SoLuong.ToString();
                    txtDonGia.Text = pn.DonGia.ToString("0.##");

                    // txtThanhTien.Text = ... // Đã bỏ hiển thị ô này

                    txtGhiChu.Text = pn.GhiChu;

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