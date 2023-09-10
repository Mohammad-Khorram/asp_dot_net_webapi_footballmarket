using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace football_market.karafzar_tools
{
    public class karafzar
    {
        public static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionStringWeb"].ConnectionString);
        public static SqlCommand sqlCommand = new SqlCommand();
        public static SqlDataAdapter sqlDataAdapter;
        public static bool hasError = new bool();

        public static bool checkToken(string user, string pass)
        {
            sqlCommand.CommandText = "select [user],pass from base_info where [user]=@user and pass=@pass";
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@user", user);
            sqlCommand.Parameters.AddWithValue("@pass", pass);
            DataTable dataTable = SqlDataAdapter();

            if (dataTable.Rows.Count == 0)
                return false;

            if (user.Equals(dataTable.Rows[0]["user"].ToString()) && pass.Equals(dataTable.Rows[0]["pass"].ToString()))
                return true;
            else
                return false;
        }

        public static DataTable SqlDataAdapter()
        {
            DataTable dataTable = new DataTable();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Close();

            try
            {
                sqlDataAdapter = new SqlDataAdapter();
                sqlCommand.Connection = sqlConnection;
                sqlDataAdapter.SelectCommand = sqlCommand;
                dataTable.Clear();
                sqlConnection.Open();
                sqlDataAdapter.Fill(dataTable);
                hasError = false;
                return dataTable;
            }
            catch
            {
                hasError = true;
                return null;
            }
            finally
            {
                sqlConnection.Close();
                sqlCommand.Parameters.Clear();
            }
        }
    }
}