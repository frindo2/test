using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    public class ClassConnection
    {
        public string getConnectionString()
        {
            //return @"Data Source=AHO-NB-IT-09;Initial Catalog=DB_Test;integrated security=sspi"; //tidak menggunakan password
            return @"Data Source=.;Initial Catalog=DB_Test;User ID=sa;Password=itadmin";
        }

        public SqlConnection bukaConnection(string _ConnectionString, out string outMessage)
        {
            SqlConnection sqlConn = null;
            outMessage = string.Empty;
            try
            {
                sqlConn = new SqlConnection(_ConnectionString);
                if (sqlConn.State != ConnectionState.Open)
                {
                    sqlConn.Open();
                }
                else
                {
                    sqlConn.Close();
                    sqlConn.Open();
                }
            }
            catch (Exception ex)
            {
                sqlConn = null;
                outMessage = string.Format("Koneksi gagal.\n\nDetail :\n{0}", (ex.Message));
            }

            return sqlConn;
        }

        public void tutupConnection(SqlConnection sqlConn, SqlCommand cmd, SqlDataReader reader)
        {
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
            if (sqlConn != null)
            {
                sqlConn.Close();
                sqlConn = null;
            }
            if (reader != null)
            {
                reader.Close();
                reader = null;
            }
        }
    }
}
