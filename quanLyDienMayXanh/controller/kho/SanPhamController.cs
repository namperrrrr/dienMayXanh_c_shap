using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.view.kho;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing; // Để load ảnh nếu cần

namespace quanLyDienMayXanh.Controller
{
    public class SanPhamController
    {
        private FormSanPham view;
        private SanPhamDAO spDao;
        private DanhMucDAO dmDao;

        public SanPhamController(FormSanPham view)
        {
            this.view = view;
            this.spDao = new SanPhamDAO();
            this.dmDao = new DanhMucDAO();

            // Đăng ký sự kiện
            this.view.Load += (s, e) => { LoadDataDanhMuc(); LoadDataLenBang(); };
            this.view.btnThem.Click += XuLyThem;
            this.view.btnSua.Click += XuLySua;
            this.view.btnXoa.Click += XuLyXoa;
            this.view.btnLamMoi.Click += XuLyLamMoi;
            this.view.btnTimKiem.Click += XuLyTimKiem;

            this.view.dgvSanPham.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    this.view.FillFormTuBang();
                    // Load chi tiết đầy đủ hơn nếu cần (vì bảng không hiện hết cột)
                    LoadChiTietSanPham(this.view.GetMaSPDangChon());
                }
            };
        }

        public void LoadDataDanhMuc()
        {
            List<DanhMuc> listDM = dmDao.GetAll();
            view.SetDuLieuDanhMuc(listDM);
        }

        public void LoadDataLenBang()
        {
            view.dgvSanPham.Rows.Clear();
            List<SanPham> list = spDao.GetAll();
            HienThiListLenBang(list);
        }

        private void HienThiListLenBang(List<SanPham> list)
        {
            view.dgvSanPham.Rows.Clear();
            foreach (SanPham sp in list)
            {
                if (sp.TrangThaiKinhDoanh == "NGUNG_KINH_DOANH") continue; // Ẩn sp đã xóa

                // Load ảnh từ URL (Optional - Cần xử lý bất đồng bộ hoặc try catch để tránh treo)
                // Tạm thời để null hoặc ảnh mặc định
                Image img = null;

                view.dgvSanPham.Rows.Add(
                    sp.MaSP,
                    img,
                    sp.TenSP,
                    sp.MaDanhMuc, // Hoặc tên danh mục nếu join
                    sp.ThuongHieu,
                    sp.TonKho,
                    sp.DonViTinh,
                    sp.GiaBan.ToString("N0") // Format tiền
                );
            }
        }

        private void LoadChiTietSanPham(string maSP)
        {
            // Logic lấy lại data từ List đã load hoặc query DB để fill nốt các ô GiaNhap, BaoHanh, MoTa
            List<SanPham> list = spDao.Search(maSP, "");
            if (list.Count > 0)
            {
                SanPham sp = list[0];
                view.txtGiaNhap.Text = sp.GiaNhap.ToString("0.##");
                view.txtBaoHanh.Text = sp.ThoiGianBaoHanh.ToString();
                view.txtMoTa.Text = sp.MoTa;
                view.txtHinhAnh.Text = sp.HinhAnh;
                view.cboTrangThaiHang.Text = sp.TrangThaiHang;
                // Set combobox Danh mục
                foreach (DanhMuc item in view.cboDanhMuc.Items)
                {
                    if (item.MaDanhMuc == sp.MaDanhMuc)
                    {
                        view.cboDanhMuc.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void XuLyLamMoi(object sender, EventArgs e)
        {
            view.ResetForm();
            LoadDataLenBang();
        }

        private void XuLyThem(object sender, EventArgs e)
        {
            SanPham sp = view.GetSanPhamFromInput();

            if (string.IsNullOrEmpty(sp.MaSP) || string.IsNullOrEmpty(sp.TenSP))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (spDao.CheckTrungMa(sp.MaSP))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (spDao.Insert(sp) > 0)
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadDataLenBang();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLySua(object sender, EventArgs e)
        {
            SanPham sp = view.GetSanPhamFromInput();
            if (spDao.Update(sp) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataLenBang();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLyXoa(object sender, EventArgs e)
        {
            string maSP = view.GetMaSPDangChon();
            if (maSP == null)
            {
                MessageBox.Show("Chưa chọn sản phẩm để xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa/ngừng kinh doanh sản phẩm {maSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (spDao.Delete(maSP) > 0)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    LoadDataLenBang();
                    view.ResetForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void XuLyTimKiem(object sender, EventArgs e)
        {
            string keyword = view.txtTimKiem.Text.Trim();
            string maDM = "";
            if (view.cboLocDanhMuc.SelectedItem != null)
            {
                maDM = ((DanhMuc)view.cboLocDanhMuc.SelectedItem).MaDanhMuc;
            }

            List<SanPham> list = spDao.Search(keyword, maDM);
            HienThiListLenBang(list);
        }
    }
}