using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQLClass
{
    public class SqlClass
    {
        public class SqlHelper
        {
            private SqlConnection connection;

            public void CreateConnection(string pConnectionString)
            {
                connection = new SqlConnection(pConnectionString);
            }
            public bool TestConnection()
            {
                try
                {
                    connection.Open();
                    return true;

                }
                catch { return false; }
                finally { connection.Close(); }
            }
            public DataTable ExcuteQuery(string pQuery)
            {
                DataTable dataTable = new DataTable();

                try {
                    SqlCommand sqlCommand = new SqlCommand();
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    adapter.Fill(dataTable);
                }
                catch(Exception ex) { throw new Exception("Query excution failed : " ,ex); }
                return dataTable;
            }
            public bool Insert(string pQuery, SqlConnection pConnection)
            {
                return ExcuteNonQuery(pQuery, pConnection);
            }

            public bool Update(string pQuery, SqlConnection pConnection)
            {
                return ExcuteNonQuery(pQuery, pConnection);
            }
            public bool Delete(string pQuery, SqlConnection pConnection)
            {
                return ExcuteNonQuery(pQuery, pConnection);
            }

            public bool ExcuteNonQuery(string pQuery, SqlConnection pConnection)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    pConnection.Open();
                    int result = sqlCommand.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL command excution failed : ", ex);
                }
                finally { pConnection.Close(); }
            }
        }
       
    }
}
