using quanLyDienMayXanh.domain.kho;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.view.kho;
using System;
using System.Collections.Generic;
using System.Drawing; // Để load ảnh nếu cần
using System.Windows.Forms;

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
            this.view.Load += (s, e) => { LoadDataDanhMuc(); LoadDataLenBang(); this.view.ResetForm(); };
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
                //if (sp.TrangThaiKinhDoanh == "NGUNG_KINH_DOANH") continue; // Ẩn sp đã xóa
                int index = view.dgvSanPham.Rows.Add(
                    sp.MaSP,
                    null,
                    sp.TenSP,
                    sp.MaDanhMuc,
                    sp.ThuongHieu,
                    sp.TonKho,
                    sp.DonViTinh,
                    sp.GiaBan.ToString("N0")
                        );
                view.dgvSanPham.Rows[index].Tag = sp;
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

            // Đổi câu thông báo cho phù hợp với xóa vĩnh viễn
            if (MessageBox.Show($"CẢNH BÁO: Bạn có chắc muốn xóa VĨNH VIỄN sản phẩm {maSP}?\nDữ liệu không thể khôi phục sau khi xóa.",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (spDao.Delete(maSP) > 0)
                {
                    MessageBox.Show("Đã xóa sản phẩm thành công!");
                    LoadDataLenBang();
                    view.ResetForm();
                }
                else
                {
                    // Thông báo rõ ràng hơn vì xóa cứng thường thất bại do ràng buộc dữ liệu
                    MessageBox.Show("Xóa thất bại!\n\nNguyên nhân phổ biến: Sản phẩm này đã có trong Đơn hàng, Phiếu nhập hoặc Phiếu bảo hành nên không thể xóa hẳn khỏi CSDL.",
                        "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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