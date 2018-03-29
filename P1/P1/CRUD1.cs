using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class CRUD1 : Form
    {
        #region Connection to DataBase
        private string getConnectionString()
        {
            //return @"Data Source=AHO-NB-IT-09;Initial Catalog=DB_Test;integrated security=sspi"; //tidak menggunakan password
            return @"Data Source=.;Initial Catalog=DB_Test;User ID=sa;Password=itadmin";
        }

        private SqlConnection bukaConnection(string _ConnectionString)
        {
            SqlConnection sqlConn = null;
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
                MessageBox.Show(string.Format("Koneksi gagal.\n\nDetail :\n{0}", (ex.Message)), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sqlConn;
        }

        private void tutupConnection(SqlConnection sqlConn, SqlCommand cmd, SqlDataReader reader)
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

        private void tampilSemuaBaris()
        {
            DataTable dataTable = new DataTable("tempDataTable");
            SqlConnection sqlConnection = bukaConnection(getConnectionString());
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            string sql = "SELECT MataKuliahID,KodeMataKuliah,NamaMataKuliah,Sks FROM dbo.Master_MataKuliah;";

            if (sqlConnection != null)
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);

                tutupConnection(sqlConnection, sqlCommand, sqlDataReader);

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dataTable;
            }
        }

        private void simpan()
        {
            SqlConnection sqlConnection = bukaConnection(getConnectionString());
            SqlCommand sqlCommand = null;
            string sql = @"INSERT INTO	dbo.Master_MataKuliah(MataKuliahID,KodeMataKuliah,NamaMataKuliah,Sks)
	                        VALUES ((SELECT TOP 1 ((ISNULL((MAX(F1.MataKuliahID)), 0)) + 1) FROM Master_MataKuliah AS F1) ,'"
                            + (kodeMataKuliahTextBox.Text.Trim()) + "','" + (namaMataKuliahTextBox.Text.Trim()) + "', " + (sksTextBox.Text.Trim()) + ");";

            if (sqlConnection != null)
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery(); ;

                tutupConnection(sqlConnection, sqlCommand, null);
            }

            tampilSemuaBaris();
        }

        private void ubah()
        {
            SqlConnection sqlConnection = bukaConnection(getConnectionString());
            SqlCommand sqlCommand = null;
            string sql = @"UPDATE dbo.Master_MataKuliah 
                            SET NamaMataKuliah = '" + (namaMataKuliahTextBox.Text.Trim()) + "' , Sks = " + (sksTextBox.Text.Trim())
                           + " WHERE KodeMataKuliah = " + (kodeMataKuliahTextBox.Text.Trim()) + "";

            if (sqlConnection != null)
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery(); ;

                tutupConnection(sqlConnection, sqlCommand, null);
            }

            tampilSemuaBaris();
        }

        private void hapus()
        {
            SqlConnection sqlConnection = bukaConnection(getConnectionString());
            SqlCommand sqlCommand = null;
            string sql = @"DELETE FROM dbo.Master_MataKuliah "
                           + " WHERE KodeMataKuliah = " + (kodeMataKuliahTextBox.Text.Trim()) + "";

            if (sqlConnection != null)
            {
                sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.ExecuteNonQuery(); ;

                tutupConnection(sqlConnection, sqlCommand, null);
            }

            tampilSemuaBaris();
        }
        #endregion Connection to DataBase

        public CRUD1()
        {
            InitializeComponent();
        }

        private void CRUD1_Load(object sender, EventArgs e)
        {
            tampilSemuaBaris();
        }

        private void simpanButton_Click(object sender, EventArgs e)
        {
            simpan();
        }

        private void ubahButton_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void hapusButton_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}
