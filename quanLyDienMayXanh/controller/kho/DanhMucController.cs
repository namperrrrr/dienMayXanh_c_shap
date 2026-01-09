using quanLyDienMayXanh.domain.kho;
using quanLyDienMayXanh.model.kho;
using quanLyDienMayXanh.view.kho;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.controller.kho
{
    public class DanhMucController
    {
        private FormDanhMuc view;
        private DanhMucDAO dao;

        public DanhMucController(FormDanhMuc view)
        {
            this.view = view;
            this.dao = new DanhMucDAO();

            // Đăng ký sự kiện
            this.view.Load += LoadData;
            this.view.btnThem.Click += BtnThem_Click;
            this.view.btnSua.Click += BtnSua_Click;
            this.view.btnXoa.Click += BtnXoa_Click;
            this.view.btnLamMoi.Click += BtnLamMoi_Click;
            this.view.dgvDanhMuc.CellClick += DgvDanhMuc_CellClick;
        }

        private void LoadData(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            List<DanhMuc> list = dao.GetAll();
            view.dgvDanhMuc.DataSource = list;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            DanhMuc dm = view.GetDanhMucFromInput();

            // 1. Kiểm tra nhập trống
            if (string.IsNullOrEmpty(dm.MaDanhMuc) || string.IsNullOrEmpty(dm.TenDanhMuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. KIỂM TRA TRÙNG MÃ (Code mới thêm)
            if (dao.CheckMaDM(dm.MaDanhMuc))
            {
                MessageBox.Show($"Mã danh mục '{dm.MaDanhMuc}' đã tồn tại trong hệ thống!\nVui lòng nhập mã khác.", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                view.txtMaDM.Focus(); // Đưa con trỏ chuột về lại ô mã để sửa ngay
                view.txtMaDM.SelectAll(); // Bôi đen mã cũ để nhập đè cho nhanh
                return; // Dừng lại, không thêm nữa
            }

            // 3. Nếu không trùng thì mới thêm
            if (dao.Add(dm))
            {
                MessageBox.Show("Thêm danh mục thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();       // Load lại bảng
                view.ResetForm(); // Xóa trắng form
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            DanhMuc dm = view.GetDanhMucFromInput();
            if (dao.Update(dm))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadList();
                view.ResetForm();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string ma = view.GetMaDMDangChon();
            if (string.IsNullOrEmpty(ma)) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa danh mục {ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (dao.Delete(ma))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadList();
                    view.ResetForm();
                }
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            view.ResetForm();
            LoadList();
        }

        private void DgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            view.FillFormTuBang();
        }
    }
}