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

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user");
            dataGridView1.DataSource = dataLog.Tables[0];
            DataTable dataTotalPenjualan = helper.GetOneData("select sum(total_bayar) from detail_transaksi, transaksi, barang where detail_transaksi.id_transaksi = transaksi.id_transaksi and detail_transaksi.id_barang = barang.id_barang");
            label1.Text = "Rp. " + dataTotalPenjualan.Rows[0][0].ToString();
            DataTable dataTotalTransaksi = helper.GetOneData("select count(total_bayar) from detail_transaksi");
            label2.Text = dataTotalTransaksi.Rows[0][0].ToString() + " Transaksi";
            DataTable dataJumlahCustomer = helper.GetOneData("select count(id_customer) from customer");
            label3.Text = dataJumlahCustomer.Rows[0][0].ToString() + " Customer";
            DataTable dataJumlahPegawai = helper.GetOneData("select count(id_user) from users");
            label6.Text = dataJumlahPegawai.Rows[0][0].ToString() + " Pegawai";
            DataTable dataTotalLogAktifitas = helper.GetOneData("select count(id_log) from log_activity");
            label11.Text = dataTotalLogAktifitas.Rows[0][0].ToString() + " Log";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
