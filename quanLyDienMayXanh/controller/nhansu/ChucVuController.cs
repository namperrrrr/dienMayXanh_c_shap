using quanLyDienMayXanh.domain;
using quanLyDienMayXanh.model.nhansu;
using quanLyDienMayXanh.view.nhansu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanLyDienMayXanh.controller.nhansu
{
    public class ChucVuController
    {
        private FormChucVu view;
        private ChucVuDAO dao;

        public ChucVuController(FormChucVu view)
        {
            this.view = view;
            this.dao = new ChucVuDAO();

            // --- ĐĂNG KÝ SỰ KIỆN (Thay cho ActionListener) ---

            // 1. Sự kiện nút bấm
            this.view.btnThem.Click += XuLyThem;
            this.view.btnSua.Click += XuLySua;
            this.view.btnXoa.Click += XuLyXoa;
            this.view.btnLamMoi.Click += XuLyLamMoi;

            // 2. Sự kiện click bảng
            this.view.dgvChucVu.CellClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    view.FillFormTuBang();
                }
            };

            // Load dữ liệu khi khởi tạo
            LoadData();
        }

        // --- CÁC HÀM LOGIC ---

        public void LoadData()
        {
            view.dgvChucVu.Rows.Clear();
            List<ChucVu> list = dao.GetAll();

            foreach (ChucVu cv in list)
            {
                // Format lương hiển thị (1000000 -> 1,000,000 hoặc 1.000.000 tùy máy)
                // "N0" là định dạng số nguyên có dấu phân cách hàng nghìn

                view.dgvChucVu.Rows.Add(
                    cv.MaCV,
                    cv.TenCV,
                    cv.LuongCoBan, // DataGridView sẽ tự format theo DefaultCellStyle đã set ở View ("N0")
                    cv.MoTa
                );
            }
        }

        // --- XỬ LÝ SỰ KIỆN ---

        private void XuLyLamMoi(object sender, EventArgs e)
        {
            view.ResetForm();
            LoadData();
        }

        private void XuLyThem(object sender, EventArgs e)
        {
            ChucVu cv = view.GetChucVuFromInput();

            // 1. Validate nhập liệu
            if (string.IsNullOrEmpty(cv.MaCV))
            {
                MessageBox.Show("Chưa nhập mã chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Check lương > 100 Triệu
            if (cv.LuongCoBan > 100000000)
            {
                MessageBox.Show("Lương cơ bản không được vượt quá 100.000.000 VND!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Check trùng mã
            if (dao.CheckTrungMa(cv.MaCV))
            {
                MessageBox.Show($"Mã chức vụ [{cv.MaCV}] đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Insert
            if (dao.Insert(cv) > 0)
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLySua(object sender, EventArgs e)
        {
            // Kiểm tra xem có đang chọn dòng nào không
            string maCVDangChon = view.GetMaCVDangChon();
            if (string.IsNullOrEmpty(maCVDangChon))
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần sửa!");
                return;
            }

            ChucVu cv = view.GetChucVuFromInput();

            // Check lương > 100 Triệu khi sửa
            if (cv.LuongCoBan > 100000000)
            {
                MessageBox.Show("Lương cơ bản không được vượt quá 100.000.000 VND!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi Update
            if (dao.Update(cv) > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XuLyXoa(object sender, EventArgs e)
        {
            string maCV = view.GetMaCVDangChon();
            if (string.IsNullOrEmpty(maCV))
            {
                MessageBox.Show("Vui lòng chọn chức vụ cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa chức vụ [{maCV}] không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (dao.Delete(maCV) > 0)
                {
                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
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
