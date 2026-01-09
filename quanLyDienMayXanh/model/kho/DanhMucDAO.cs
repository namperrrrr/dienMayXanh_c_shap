using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Collections.Generic;
// Thêm thư viện này để debug lỗi nếu cần
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

            // ConnectDB.GetConnection() đã mở kết nối rồi, không cần Open lại
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return list; // Kiểm tra nếu kết nối thất bại
                try
                {
                    // cons.Open();  <-- XÓA HOẶC COMMENT DÒNG NÀY

                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    using (MySqlDataReader rs = cmd.ExecuteReader())
                    {
                        while (rs.Read())
                        {
                            DanhMuc dm = new DanhMuc();
                            // Đảm bảo tên cột trong database khớp chính xác (MaDanhMuc, TenDanhMuc)
                            dm.MaDanhMuc = rs["MaDanhMuc"].ToString();
                            dm.TenDanhMuc = rs["TenDanhMuc"].ToString();
                            list.Add(dm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Nên hiện lỗi để biết tại sao không load được
                    MessageBox.Show("Lỗi load danh mục: " + ex.Message);
                }
            }
            return list;
        }

        // Thêm danh mục mới
        public bool Insert(DanhMuc dm)
        {
            string sql = "INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc) VALUES (@Ma, @Ten)";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    // cons.Open(); <-- XÓA DÒNG NÀY
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", dm.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@Ten", dm.TenDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                    return false;
                }
            }
        }

        // Cập nhật danh mục
        public bool Update(DanhMuc dm)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @Ten WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    // cons.Open(); <-- XÓA DÒNG NÀY
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", dm.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@Ten", dm.TenDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception) { return false; }
            }
        }

        // Xóa danh mục
        public bool Delete(string maDM)
        {
            string sql = "DELETE FROM DanhMuc WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return false;
                try
                {
                    // cons.Open(); <-- XÓA DÒNG NÀY
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", maDM);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception) { return false; }
            }
        }

        // Tìm kiếm danh mục
        public List<DanhMuc> Search(string keyword)
        {
            List<DanhMuc> list = new List<DanhMuc>();
            string sql = "SELECT * FROM DanhMuc WHERE MaDanhMuc LIKE @Key OR TenDanhMuc LIKE @Key";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                if (cons == null) return list;
                try
                {
                    // cons.Open(); <-- XÓA DÒNG NÀY
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Key", "%" + keyword + "%");
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
                catch (Exception) { }
            }
            return list;
        }
    }
}