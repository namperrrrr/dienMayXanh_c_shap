using MySql.Data.MySqlClient;
using quanLyDienMayXanh.domain;
using System;
using System.Collections.Generic;

namespace quanLyDienMayXanh.model.kho
{
    public class DanhMucDAO
    {
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
                catch (Exception) { }
            }
            return list;
        }
    }
}