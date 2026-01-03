using quanLyDienMayXanh.domain;
 // Chú ý: Kiểm tra lại namespace Domain hay domain trong project của bạn
using quanLyDienMayXanh.model.nhansu;

using quanLyDienMayXanh.view.nhansu; // Namespace chứa FormNhanVien
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.Controller // Hoặc quanLyDienMayXanh.controller.nhansu tùy bạn đặt
{
    public class NhanVienController
    {
        private FormNhanVien view;
        private NhanVienDAO nvDao;
        private ChucVuDAO cvDao; // 1. Khai báo thêm DAO Chức vụ

        public NhanVienController(FormNhanVien view)
        {
            this.view = view;
            this.nvDao = new NhanVienDAO();
            this.cvDao = new ChucVuDAO(); // 2. Khởi tạo

            // Đăng ký sự kiện
            this.view.btnThem.Click += XuLyThem;
            this.view.btnSua.Click += XuLySua;
            this.view.btnXoa.Click += XuLyXoa;
            this.view.btnLamMoi.Click += XuLyLamMoi;

            this.view.dgvNhanVien.CellClick += (sender, e) => {
                if (e.RowIndex >= 0)
                {
                    this.view.FillFormTuBang();
                }
            };

            // 3. Gọi hàm load dữ liệu
            LoadDataChucVu();
            LoadDataLenBang();

            this.view.SetTrangThaiNut(false);
        }

        // 4. Hàm load danh sách chức vụ vào ComboBox
        public void LoadDataChucVu()
        {
            List<ChucVu> listCV = cvDao.GetAll();
            view.SetDuLieuChucVu(listCV); // Truyền list sang View
        }

        public void LoadDataLenBang()
        {
            view.dgvNhanVien.Rows.Clear();
            List<NhanVien> list = nvDao.GetAll();
            foreach (NhanVien nv in list)
            {
                view.dgvNhanVien.Rows.Add(
                    nv.MaNV,
                    nv.HoTen,
                    nv.GioiTinh,
                    nv.MaCV, // Hiển thị Mã CV lên bảng
                    nv.Sdt,
                    nv.Email
                );
            }
        }

        private void XuLyLamMoi(object sender, EventArgs e)
        {
            view.ResetForm();
            LoadDataChucVu(); // Load lại cả chức vụ phòng khi có thay đổi
            LoadDataLenBang();
        }

        private void XuLyThem(object sender, EventArgs e)
        {
            NhanVien nv = view.GetNhanVienFromInput();

            if (string.IsNullOrEmpty(nv.MaNV))
            {
                MessageBox.Show("Chưa nhập Mã NV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nvDao.CheckTrungMa(nv.MaNV))
            {
                MessageBox.Show("Mã NV đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nvDao.Insert(nv) > 0)
            {
                MessageBox.Show("Thêm thành công!");
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
            NhanVien nv = view.GetNhanVienFromInput();
            if (nvDao.Update(nv) > 0)
            {
                MessageBox.Show("Sửa thành công!");
                LoadDataLenBang();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Lỗi khi sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLyXoa(object sender, EventArgs e)
        {
            string maNV = view.GetMaNVDangChon();
            if (maNV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {maNV}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nvDao.Delete(maNV) > 0)
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
    }
}