using quanLyDienMayXanh.domain.kho;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.view.kho;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.Controller
{
    public class DanhMucController
    {
        private FormDanhMuc view;
        private DanhMucDAO dao;

        public DanhMucController(FormDanhMuc view)
        {
            this.view = view;
            this.dao = new DanhMucDAO();
            LoadList();
        }

        public void LoadList()
        {
            List<DanhMuc> list = dao.GetAll();
            view.dgvDanhMuc.DataSource = list;
        }

        public void Add()
        {
            DanhMuc dm = view.GetDanhMucFromInput();
            if (string.IsNullOrEmpty(dm.MaDanhMuc) || string.IsNullOrEmpty(dm.TenDanhMuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dao.Insert(dm))
            {
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Mã danh mục có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update()
        {
            DanhMuc dm = view.GetDanhMucFromInput();
            if (dao.Update(dm))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();
                view.ResetForm();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete()
        {
            string ma = view.GetMaDMDangChon();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa danh mục {ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dao.Delete(ma))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                    view.ResetForm();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Danh mục này có thể đang chứa sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Search(string keyword)
        {
            view.dgvDanhMuc.DataSource = dao.Search(keyword);
        }
    }
}