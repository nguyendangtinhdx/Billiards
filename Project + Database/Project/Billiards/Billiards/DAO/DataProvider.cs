using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billiards.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E    // 5 (Singleton:tại 1 thời điểm chỉ duy nhất 1 intern của thằng nào đó được tạo ra)
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set { DataProvider.instance = value; } // chỉ có nội bộ trong class mới được set dữ liệu vào, nếu ở ngoài thì không được đụng vào
        }
        private DataProvider() { } // hàng dựng

        private string connectSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=Billiards;Integrated Security=True";
        //private string connectSTR = "Data Source=DESKTOP-264SA00\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //private string connectSTR = "Data Source=.;Initial Catalog=QuanLyQuanCafe;Integrated Security=True"; // bản thường
        public DataTable ExecuteQuery(string query, object[] parameter = null) // trả ra các dòng kết quả
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null) // có parameter
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) // có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);// trung gian truy vấn lấy giữ liệu

                adapter.Fill(data); // đổ dữ liệu lấy ra vào data

                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) // trả ra số dòng được thực thi: Insert, Update, Delete sẽ trả ra số dòng thành công
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null) // có parameter
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) // có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null) // trả ra kết quả: thực hiện đếm số lượng
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null) // có parameter
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@')) // có chứa parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
