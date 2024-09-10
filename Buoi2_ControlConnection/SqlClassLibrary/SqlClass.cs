using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlClassLibrary
{
    public class SqlClass
    {
        public SqlConnection _connection;

        // Hàm tạo đối tượng SqlConnection
        public void CreateConnection(string pConnectionString)
        {
            _connection = new SqlConnection(pConnectionString);
        }

        // Hàm TestConnection
        public bool TestConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi câu truy vấn trả về danh sách kết quả
        public DataTable ExecuteQuery(string pQuery)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(pQuery, _connection))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
                }
            }
            return dataTable;
        }


        // Hàm thực thi thêm dữ liệu
        public bool Insert(string pQuery, SqlConnection pConnection)
        {
            return ExecuteNonQuery(pQuery, pConnection);
        }

        public bool Insert(string pQuery, Dictionary<string, object> parameters)
        {
            using (SqlCommand command = new SqlCommand(pQuery, _connection))
            {
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
                try
                {
                    _connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
                }
                finally
                {
                    _connection.Close();
                }
            }
        }

        // Hàm thực thi cập nhật dữ liệu
        public bool Update(string pQuery, SqlConnection pConnection)
        {
            return ExecuteNonQuery(pQuery, pConnection);
        }

        // Hàm thực thi xóa dữ liệu
        public bool Delete(string pQuery, SqlConnection pConnection)
        {
            return ExecuteNonQuery(pQuery, pConnection);
        }

        // Hàm thực thi các lệnh không trả về dữ liệu (thêm, xóa, sửa)
        private bool ExecuteNonQuery(string pQuery, SqlConnection pConnection)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, pConnection);
                pConnection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thực thi truy vấn: " + ex.Message);
            }
            finally
            {
                pConnection.Close();
            }
        }
    }
}
