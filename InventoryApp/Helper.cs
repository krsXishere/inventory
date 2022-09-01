using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    internal class Helper
    {
        public SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=DESKTOP-5DHI6E5\MSSQLSERVER01;Initial Catalog=inventory;Integrated Security=True";

            return connection;
        }

        public DataSet GetData(String query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            sqlDataAdapter.Fill(data);

            return data;
        }

        public DataTable GetOneData(String query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            sqlDataAdapter.Fill(data);

            return data;
        }

        public void SetData(String query, String message)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show(""+message+"", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DataTable Login(String username, String password)
        {
            SqlConnection connection = GetConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select id_user, nama_user, level_user from users where username='"+username+"' and pass='"+password+"'", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            return dt;
        }

        public void LogActivity(String logActivity)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into log_activity (id_user, activity) values('"+FormLogin.id_user+"', '"+logActivity+"')";
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void FillAllFields()
        {
            MessageBox.Show("Isi Semua Data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
