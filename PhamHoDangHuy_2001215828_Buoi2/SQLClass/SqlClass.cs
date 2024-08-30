using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlClass
{
    public class SqlHelper
    {
        private SqlConnection _connection;

        // Hàm tạo đối tượng SqlConnection với chuỗi kết nối truyền vào
        public void CreateConnection(string pConnectionString)
        {
            _connection = new SqlConnection(pConnectionString);
        }

        // Hàm kiểm tra kết nối SQL
        public bool TestConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi một câu truy vấn trả về kết quả dưới dạng DataTable
        public DataTable ExecuteQuery(string pQuery)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log)
                throw new Exception("Query execution failed.", ex);
            }
            return dataTable;
        }

        // Hàm thực thi lệnh INSERT SQL
        public bool Insert(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }

        // Hàm thực thi lệnh UPDATE SQL
        public bool Update(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }

        // Hàm thực thi lệnh DELETE SQL
        public bool Delete(string pQuery)
        {
            return ExecuteNonQuery(pQuery);
        }

        // Hàm thực thi lệnh non-query SQL (INSERT, UPDATE, DELETE)
        private bool ExecuteNonQuery(string pQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                _connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log)
                throw new Exception("SQL command execution failed.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi câu lệnh SQL có tham số
        public bool ExecuteNonQueryWithParameters(string pQuery, SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                command.Parameters.AddRange(parameters);
                _connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("SQL command execution with parameters failed.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi một câu truy vấn có tham số trả về DataTable
        public DataTable ExecuteQueryWithParameters(string pQuery, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("Query execution with parameters failed.", ex);
            }
            return dataTable;
        }

        // Hàm thực thi một câu lệnh SQL trả về giá trị đầu tiên của cột đầu tiên
        public object ExecuteScalar(string pQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                _connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("SQL scalar query execution failed.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi một câu lệnh SQL có tham số trả về giá trị đầu tiên của cột đầu tiên
        public object ExecuteScalarWithParameters(string pQuery, SqlParameter[] parameters)
        {
            try
            {
                SqlCommand command = new SqlCommand(pQuery, _connection);
                command.Parameters.AddRange(parameters);
                _connection.Open();
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("SQL scalar query execution with parameters failed.", ex);
            }
            finally
            {
                _connection.Close();
            }
        }

        // Hàm thực thi một câu lệnh Stored Procedure
        public DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand(procedureName, _connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                throw new Exception("Stored Procedure execution failed.", ex);
            }
            return dataTable;
        }
    }
}
