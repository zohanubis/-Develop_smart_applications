﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThuVien
{
    public class SqlClass
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
            public bool ExcuteNonQueryWithParameters(string pQuery, SqlParameter[] parameters)
            {
                try
                {
                    SqlCommand command = new SqlCommand(pQuery, connection);
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL command excute with parameters failed", ex);
                }
                finally { connection.Close(); }
            }
            public DataTable ExecuteQueryWithParameters(string pQuery, SqlParameter[] parameters)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlCommand command = new SqlCommand(pQuery, connection);
                    command.Parameters.AddRange(parameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Query execution with parameters failed.", ex);
                }
                return dataTable;
            }

            public object ExecuteScalar(string pQuery)
            {
                try
                {
                    SqlCommand command = new SqlCommand(pQuery, connection);
                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL scalar query execution failed.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            public object ExecuteScalarWithParameters(string pQuery, SqlParameter[] parameters)
            {
                try
                {
                    SqlCommand command = new SqlCommand(pQuery, connection);
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL scalar query execution with parameters failed.", ex);
                }
                finally
                {
                    connection.Close();
                }
            }

            public DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlCommand command = new SqlCommand(procedureName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(parameters);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Stored Procedure execution failed.", ex);
                }
                return dataTable;
            }
        }
    }
