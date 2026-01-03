using quanLyDienMayXanh.Controller;
using quanLyDienMayXanh.domain;
using System.IO;
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
        private string tenHinhAnhHienTai = "";
        public FormSanPham()
        {
            InitializeComponent();
            controller = new SanPhamController(this);

            // Đăng ký sự kiện để hiện ảnh lên bảng danh sách
            dgvSanPham.CellFormatting += dgvSanPham_CellFormatting;
            dgvSanPham.RowTemplate.Height = 80; // Chỉnh dòng cao lên để thấy ảnh
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

            decimal.TryParse(txtGiaNhap.Text, out decimal gNhap);
            sp.GiaNhap = gNhap;
            decimal.TryParse(txtGiaBan.Text, out decimal gBan);
            sp.GiaBan = gBan;
            int.TryParse(txtBaoHanh.Text, out int baoHanh);
            sp.ThoiGianBaoHanh = baoHanh;

            sp.TrangThaiHang = cboTrangThaiHang.Text;
            sp.MoTa = txtMoTa.Text;

            // Lấy tên ảnh từ biến tạm
            sp.HinhAnh = tenHinhAnhHienTai;

            return sp;
        }

        // Hàm đổ dữ liệu 1 sản phẩm lên input (khi click vào bảng)
        public void FillFormTuBang()
        {
            if (dgvSanPham.CurrentRow != null)
            {
                int index = dgvSanPham.CurrentRow.Index;
                txtMaSP.Text = dgvSanPham.Rows[index].Cells["colMaSP"].Value?.ToString();
                txtTenSP.Text = dgvSanPham.Rows[index].Cells["colTenSP"].Value?.ToString();
                cboDanhMuc.Text = dgvSanPham.Rows[index].Cells["colDanhMuc"].Value?.ToString();
                txtThuongHieu.Text = dgvSanPham.Rows[index].Cells["colThuongHieu"].Value?.ToString();
                txtDVT.Text = dgvSanPham.Rows[index].Cells["colDVT"].Value?.ToString();
                txtGiaBan.Text = dgvSanPham.Rows[index].Cells["colGiaBan"].Value?.ToString();

                // Hiển thị ảnh Preview
                if (dgvSanPham.Rows[index].Tag is SanPham sp)
                {
                    tenHinhAnhHienTai = sp.HinhAnh;
                    string path = GetImagePath(tenHinhAnhHienTai);
                    if (path != null) picHinhAnh.Image = Image.FromFile(path);
                    else picHinhAnh.Image = null;
                }
                else
                {
                    tenHinhAnhHienTai = "";
                    picHinhAnh.Image = null;
                }
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

            // Reset ảnh
            tenHinhAnhHienTai = "";
            picHinhAnh.Image = null;

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
        private string GetImagePath(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return null;

            // Tìm trong thư mục chạy (bin/Debug/...)
            string path = Path.Combine(Application.StartupPath, "icons", "demo", fileName);
            if (File.Exists(path)) return path;

            // Nếu đang code (tìm ngược ra thư mục source)
            try
            {
                // Lấy thư mục gốc: .../bin/Debug/net8.0-windows/
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                // Lùi ra 3 cấp để về thư mục Project: .../quanLyDienMayXanh/
                if (dir.Parent != null && dir.Parent.Parent != null && dir.Parent.Parent.Parent != null)
                {
                    string projectPath = dir.Parent.Parent.Parent.FullName;

                    // Tìm trong folder icons/demo của project
                    path = Path.Combine(projectPath, "icons", "demo", fileName);
                    if (File.Exists(path)) return path;
                }
            }
            catch { }

            return null;
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

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Lưu tên file vào biến
                tenHinhAnhHienTai = Path.GetFileName(open.FileName);

                // Hiển thị lên PictureBox
                picHinhAnh.Image = Image.FromFile(open.FileName);
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra đúng cột "colHinhAnh" và dòng hợp lệ
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinhAnh" && e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];

                // Lấy thông tin Sản phẩm từ Tag (Do Controller gán)
                if (row.Tag is SanPham sp && !string.IsNullOrEmpty(sp.HinhAnh))
                {
                    string path = GetImagePath(sp.HinhAnh);
                    if (path != null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(path);
                        }
                        catch { e.Value = null; } // Tránh lỗi nếu ảnh bị hỏng
                    }
                }
            }
        }
    }
}

