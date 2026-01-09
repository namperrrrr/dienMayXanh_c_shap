using quanLyDienMayXanh.domain.kho;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.model.nhansu;
using quanLyDienMayXanh.view.kho;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.Controller.kho
{
    class PhieuNhapController
    {
        private FormNhapKho view;
        private PhieuNhapDAO dao;
        private SanPhamDAO spDao;
        private NhanVienDAO nvDao;

        public PhieuNhapController(FormNhapKho view)
        {
            this.view = view;
            this.dao = new PhieuNhapDAO();
            this.spDao = new SanPhamDAO();
            this.nvDao = new NhanVienDAO();

            LoadData();
        }

        public void LoadData()
        {
            // 1. Load Combobox Sản Phẩm
            view.SetDuLieuSanPham(spDao.GetAll());

            // 2. Load Combobox Nhân Viên
            view.SetDuLieuNhanVien(nvDao.GetAll());

            // ĐÃ XÓA bước Load Nhà Cung Cấp vì giờ là nhập tay

            // 3. Load DataGridView
            ShowBang(dao.GetAll());
        }

        public void ShowBang(List<PhieuNhap> list)
        {
            view.dgvPhieuNhap.DataSource = null;
            view.dgvPhieuNhap.DataSource = list;

            if (view.dgvPhieuNhap.Columns["MaSP"] != null) view.dgvPhieuNhap.Columns["MaSP"].Visible = false;
            if (view.dgvPhieuNhap.Columns["MaNV"] != null) view.dgvPhieuNhap.Columns["MaNV"].Visible = false;

            // Hiển thị cột TenNCC
            if (view.dgvPhieuNhap.Columns["TenNCC"] != null)
            {
                view.dgvPhieuNhap.Columns["TenNCC"].HeaderText = "Nhà cung cấp";
                view.dgvPhieuNhap.Columns["TenNCC"].Visible = true;
            }
        }
    
        public void ThemPhieu()
        {
            PhieuNhap pn = view.GetPhieuNhapFromInput();
            if (pn == null) return;
            if (!string.IsNullOrEmpty(pn.MaPhieu))
            {
                if (dao.CheckMaPhieu(pn.MaPhieu))
                {
                    MessageBox.Show($"Mã phiếu '{pn.MaPhieu}' đã tồn tại trong hệ thống!\nVui lòng nhập mã khác hoặc để trống để tự động tạo.",
                                    "Cảnh báo trùng mã",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    view.txtMaPhieu.Focus(); // Trỏ chuột lại vào ô mã
                    view.txtMaPhieu.SelectAll();
                    return; 
                }
            }
            else
            {
                
                pn.MaPhieu = "PN" + System.DateTime.Now.Ticks.ToString();
            }
           
            if (dao.Add(pn))
            {
                MessageBox.Show("Nhập kho thành công! Tồn kho đã được cập nhật.");
                view.ResetForm();
                ShowBang(dao.GetAll());
            }
        }

        public void SuaPhieu()
        {
            string idStr = view.GetIDPhieuDangChon();
            if (string.IsNullOrEmpty(idStr)) return;

            PhieuNhap pn = view.GetPhieuNhapFromInput();
            if (pn == null) return;

            pn.ID = int.Parse(idStr);

            if (MessageBox.Show("Bạn có chắc muốn sửa phiếu này? Tồn kho sẽ được cập nhật lại theo số lượng mới.",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dao.Update(pn))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    view.ResetForm();
                    ShowBang(dao.GetAll());
                }
            }
        }

        public void XoaPhieu()
        {
            string idStr = view.GetIDPhieuDangChon();
            if (string.IsNullOrEmpty(idStr)) return;

            int id = int.Parse(idStr);
            PhieuNhap pnCu = view.GetPhieuNhapFromInput();

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu này? Tồn kho sản phẩm sẽ bị trừ đi số lượng đã nhập!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dao.Delete(id, pnCu.MaSP, pnCu.SoLuong))
                {
                    MessageBox.Show("Đã xóa phiếu nhập.");
                    view.ResetForm();
                    ShowBang(dao.GetAll());
                }
            }
        }
    }
}