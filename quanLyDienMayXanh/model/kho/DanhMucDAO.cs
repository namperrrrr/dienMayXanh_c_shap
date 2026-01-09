using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain.kho;
using System;
using System.Collections.Generic;

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
                    cons.Open();
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
                catch (Exception) { }
            }
            return list;
        }

        // Thêm danh mục mới
        public bool Insert(DanhMuc dm)
        {
            string sql = "INSERT INTO DanhMuc (MaDanhMuc, TenDanhMuc) VALUES (@Ma, @Ten)";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    cons.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", dm.MaDanhMuc);
                    cmd.Parameters.AddWithValue("@Ten", dm.TenDanhMuc);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception) { return false; }
            }
        }

        // Cập nhật danh mục
        public bool Update(DanhMuc dm)
        {
            string sql = "UPDATE DanhMuc SET TenDanhMuc = @Ten WHERE MaDanhMuc = @Ma";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    cons.Open();
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
                try
                {
                    cons.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, cons);
                    cmd.Parameters.AddWithValue("@Ma", maDM);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception) { return false; }
            }
        }

        // Tìm kiếm danh mục theo tên hoặc mã
        public List<DanhMuc> Search(string keyword)
        {
            List<DanhMuc> list = new List<DanhMuc>();
            string sql = "SELECT * FROM DanhMuc WHERE MaDanhMuc LIKE @Key OR TenDanhMuc LIKE @Key";
            using (MySqlConnection cons = ConnectDB.GetConnection())
            {
                try
                {
                    cons.Open();
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