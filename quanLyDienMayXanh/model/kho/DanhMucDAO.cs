using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace quanLyDienMayXanh.model.kho
{
    public class DanhMucDAO
    {
        // Lấy tất cả danh mục
        public List<DanhMuc> GetAll()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            string sql = "SELECT * FROM DanhMuc";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return list;
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    using (MySqlDataReader rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            DanhMuc dm = new DanhMuc();
                            dm.MaDanhMuc = rs["MaDanhMuc"].ToString();
                            dm.TenDanhMuc = rs["TenDanhMuc"].ToString();
                            list.Add(dm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load danh mục: " + ex.Message);
                }
            }
            return list;
        }

        // Thêm mới
        public bool Add(DanhMuc dm)
        {
            string sql = "INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc) VALUES (@Ma, @Ten)";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", dm.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@Ten", dm.TenDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm danh mục: " + ex.Message);
                    return false;
                }
            }
        }

        // Cập nhật
        public bool Update(DanhMuc dm)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @Ten WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", dm.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@Ten", dm.TenDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa danh mục: " + ex.Message);
                    return false;
                }
            }
        }

        // Xóa
        public bool Delete(string maDM)
        {
            string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", maDM);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    // Lỗi này thường do danh mục đang được sử dụng ở bảng Sản Phẩm (Ràng buộc khóa ngoại)
                    if (ex.Message.Contains("foreign key constraint"))
                    {
                        MessageBox.Show("Không thể xóa danh mục này vì đang có sản phẩm thuộc danh mục đó!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi xóa danh mục: " + ex.Message);
                    }
                    return false;
                }
            }
        }

        public bool CheckMaDM(string maDM)
        {
            // Đếm xem có bao nhiêu dòng có mã này (nếu > 0 là trùng)
            string sql = "SELECT COUNT(*) FROM DanhMuc WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", maDM);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã tồn tại
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}