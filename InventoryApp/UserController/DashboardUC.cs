using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp.UserController
{
    public partial class DashboardUC : UserControl
    {
        Helper helper = new Helper();
        public DashboardUC()
        {
            InitializeComponent();
        }

        public void DashboardUC_Load(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, username, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user and (tanggal='"+DateTime.Now+"')");
            dataGridView1.DataSource = dataLog.Tables[0];
            DataTable totalBarang = helper.GetOneData("select sum(stok_barang) from barang");
            label1.Text = totalBarang.Rows[0][0].ToString() + " Barang";
            DataTable dataJumlahPegawai = helper.GetOneData("select count(id_user) from users");
            label6.Text = dataJumlahPegawai.Rows[0][0].ToString() + " Pegawai";
            DataTable dataTotalLogAktifitas = helper.GetOneData("select count(id_log) from log_activity");
            label11.Text = dataTotalLogAktifitas.Rows[0][0].ToString() + " Log";
            DataTable barangMasuk = helper.GetOneData("select count(id_barang) from barang where status_barang='Masuk'");
            label8.Text = barangMasuk.Rows[0][0].ToString() + " Barang";
            DataTable barangKeluar = helper.GetOneData("select count(id_barang) from barang where status_barang='Keluar'");
            label14.Text = barangKeluar.Rows[0][0].ToString() + " Barang";
            DataTable barangRusak = helper.GetOneData("select count(id_barang) from barang where kondisi_barang='Rusak'");
            label3.Text = barangRusak.Rows[0][0].ToString() + " Barang";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user and (nama_user like '%"+txtSearch.Text+"%' or activity like '%"+txtSearch.Text+"%')");
            dataGridView1.DataSource = dataLog.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user and tanggal='" + dateTimePicker1.Text + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }
    }
}
