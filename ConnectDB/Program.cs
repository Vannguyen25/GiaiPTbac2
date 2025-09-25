using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace WinAPP1
{
    internal class ConnectDB
    {
        static void Main(string[] args)
        {
            string connStr = "server=127.0.0.1;port=3306;user=root;password=@Vanmontri123;database=csdl_thuy;";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Kết nối thành công!");

                    string sql = "SELECT id, name FROM users";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["id"]} - {reader["name"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            } // tự động đóng connection
        }

    }
}
