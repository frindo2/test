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
    public partial class CRUD2 : Form
    {
        //        public ClassConnection varableClassConnection = new ClassConnection();
        //        string outputMessage = string.Empty;

        //        #region Connection to DataBase
        //        private void tampilSemuaBaris()
        //        {
        //            string outputMessage = string.Empty;
        //            string namaStoreProcedure = "usp_MahasiswaList";
        //            DataTable dataTable = new DataTable(namaStoreProcedure);
        //            SqlConnection sqlConnection = varableClassConnection.bukaConnection(varableClassConnection.getConnectionString(), out outputMessage);
        //            SqlCommand sqlCommand = null;
        //            SqlDataReader sqlDataReader = null;

        //            if (sqlConnection != null)
        //            {
        //                sqlCommand = new SqlCommand(sql, sqlConnection);
        //                sqlCommand.CommandType = CommandType.Text;
        //                sqlDataReader = sqlCommand.ExecuteReader();
        //                dataTable.Load(sqlDataReader);

        //                tutupConnection(sqlConnection, sqlCommand, sqlDataReader);

        //                dataGridView1.Columns.Clear();
        //                dataGridView1.DataSource = dataTable;
        //            }
        //        }

        //        private void simpan()
        //        {
        //            SqlConnection sqlConnection = bukaConnection(getConnectionString());
        //            SqlCommand sqlCommand = null;
        //            string sql = @"INSERT INTO	dbo.Master_MataKuliah(MataKuliahID,KodeMataKuliah,NamaMataKuliah,Sks)
        //	                        VALUES ((SELECT TOP 1 ((ISNULL((MAX(F1.MataKuliahID)), 0)) + 1) FROM Master_MataKuliah AS F1) ,'"
        //                            + (kodeMataKuliahTextBox.Text.Trim()) + "','" + (namaMataKuliahTextBox.Text.Trim()) + "', " + (sksTextBox.Text.Trim()) + ");";

        //            if (sqlConnection != null)
        //            {
        //                sqlCommand = new SqlCommand(sql, sqlConnection);
        //                sqlCommand.CommandType = CommandType.Text;
        //                sqlCommand.ExecuteNonQuery(); ;

        //                tutupConnection(sqlConnection, sqlCommand, null);
        //            }

        //            tampilSemuaBaris();
        //        }

        //        private void ubah()
        //        {
        //            SqlConnection sqlConnection = bukaConnection(getConnectionString());
        //            SqlCommand sqlCommand = null;
        //            string sql = @"UPDATE dbo.Master_MataKuliah 
        //                            SET NamaMataKuliah = '" + (namaMataKuliahTextBox.Text.Trim()) + "' , Sks = " + (sksTextBox.Text.Trim())
        //                           + " WHERE KodeMataKuliah = " + (kodeMataKuliahTextBox.Text.Trim()) + "";

        //            if (sqlConnection != null)
        //            {
        //                sqlCommand = new SqlCommand(sql, sqlConnection);
        //                sqlCommand.CommandType = CommandType.Text;
        //                sqlCommand.ExecuteNonQuery(); ;

        //                tutupConnection(sqlConnection, sqlCommand, null);
        //            }

        //            tampilSemuaBaris();
        //        }

        //        private void hapus()
        //        {
        //            SqlConnection sqlConnection = bukaConnection(getConnectionString());
        //            SqlCommand sqlCommand = null;
        //            string sql = @"DELETE FROM dbo.Master_MataKuliah "
        //                           + " WHERE KodeMataKuliah = " + (kodeMataKuliahTextBox.Text.Trim()) + "";

        //            if (sqlConnection != null)
        //            {
        //                sqlCommand = new SqlCommand(sql, sqlConnection);
        //                sqlCommand.CommandType = CommandType.Text;
        //                sqlCommand.ExecuteNonQuery(); ;

        //                tutupConnection(sqlConnection, sqlCommand, null);
        //            }

        //            tampilSemuaBaris();
        //        }
        //        #endregion Connection to DataBase

        //        public CRUD2()
        //        {
        //            InitializeComponent();
        //        }

        private void CRUD2_Load(object sender, EventArgs e)
        {

        }
    }
}
