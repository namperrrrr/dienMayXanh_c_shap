using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.model.nhansu; // Dùng NhanVienDAO có sẵn
using quanLyDienMayXanh.view.kho;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.Controller.kho
{
    class PhieuNhapController
    {
        private FormNhapKho view;
        private PhieuNhapDAO dao;
        private SanPhamDAO spDao; // Để lấy tồn kho hiện tại
        private NhanVienDAO nvDao; // Lấy danh sách nhân viên

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

            // 2. Load Combobox Nhà Cung Cấp
            view.SetDuLieuNCC(dao.GetDSNhaCungCap());

            // 3. Load Combobox Nhân Viên (Để chọn người nhập)
            view.SetDuLieuNhanVien(nvDao.GetAll());

            // 4. Load DataGridView
            ShowBang(dao.GetAll());
        }

        public void ShowBang(List<PhieuNhap> list)
        {
            view.dgvPhieuNhap.DataSource = null;
            view.dgvPhieuNhap.DataSource = list;

            // Ẩn cột thừa nếu cần
            if (view.dgvPhieuNhap.Columns["MaSP"] != null) view.dgvPhieuNhap.Columns["MaSP"].Visible = false;
            if (view.dgvPhieuNhap.Columns["MaNV"] != null) view.dgvPhieuNhap.Columns["MaNV"].Visible = false;
            if (view.dgvPhieuNhap.Columns["MaNCC"] != null) view.dgvPhieuNhap.Columns["MaNCC"].Visible = false;
        }

        public void ThemPhieu()
        {
            PhieuNhap pn = view.GetPhieuNhapFromInput();
            if (pn == null) return; // Validate lỗi ở View

            // Tạo mã phiếu tự động nếu chưa có (Ví dụ: PN + Timestamp)
            if (string.IsNullOrEmpty(pn.MaPhieu))
                pn.MaPhieu = "PN" + System.DateTime.Now.Ticks.ToString();

            if (dao.Add(pn))
            {
                MessageBox.Show("Nhập kho thành công! Tồn kho đã được cập nhật.");
                view.ResetForm();
                ShowBang(dao.GetAll());
            }
        }
        // Thêm vào class PhieuNhapController
        public void SuaPhieu()
        {
            // Lấy ID phiếu đang chọn
            string idStr = view.GetIDPhieuDangChon();
            if (string.IsNullOrEmpty(idStr)) return;

            // Lấy dữ liệu mới từ giao diện
            PhieuNhap pn = view.GetPhieuNhapFromInput();
            if (pn == null) return;

            pn.ID = int.Parse(idStr);

            if (MessageBox.Show("Bạn có chắc muốn sửa phiếu này? Tồn kho sẽ được cập nhật lại theo số lượng mới.",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dao.Update(pn))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    view.ResetForm(); // Xóa trắng form và reset trạng thái nút
                    ShowBang(dao.GetAll()); // Load lại bảng
                }
            }
        }
        public void XoaPhieu()
        {
            // Cần ID, MaSP, SoLuong đã nhập để trừ lại kho
            string idStr = view.GetIDPhieuDangChon();
            if (string.IsNullOrEmpty(idStr)) return;

            int id = int.Parse(idStr);
            // Lấy thông tin phiếu cũ từ input (vì đã fill form)
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