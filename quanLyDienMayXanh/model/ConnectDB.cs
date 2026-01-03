using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace quanLyDienMayXanh.model
{
    internal class ConnectDB
    {
        private static readonly string HOST = "localhost";
        private static readonly string PORT = "3306";
        private static readonly string DBNAME = "dbdienmayxanh"; 
        private static readonly string USERNAME = "root";       
        private static readonly string PASSWORD = "";           

        private static readonly string ConnectionString =
            $"Server={HOST};Port={PORT};Database={DBNAME};Uid={USERNAME};Pwd={PASSWORD};Charset=utf8;";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection cons = null;
            try
            {
                cons = new MySqlConnection(ConnectionString);
                cons.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Lỗi kết nối XAMPP: ");
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi hệ thống: ");
                return null;
            }
            return cons;
        }
        public static void CloseConnection(MySqlConnection c)
        {
            try
            {
                if (c != null && c.State == ConnectionState.Open)
                {
                    c.Close();
                    c.Dispose(); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
