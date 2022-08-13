using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class FormAdmin : Form
    {
        Helper helper = new Helper();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DataSet dataLog = helper.GetData("select nama_user, activity, tanggal from log_activity, users where log_activity.id_user = users.id_user");
            dataGridView1.DataSource = dataLog.Tables[0];
            DataTable dataTotalPenjualan = helper.GetOneData("select sum(total_bayar) from detail_transaksi, transaksi, barang where detail_transaksi.id_transaksi = transaksi.id_transaksi and detail_transaksi.id_barang = barang.id_barang");
            label1.Text = dataTotalPenjualan.Rows[0][0].ToString();
            DataTable dataTotalTransaksi = helper.GetOneData("select count(total_bayar) from detail_transaksi");
            label2.Text = dataTotalTransaksi.Rows[0][0].ToString();
            DataTable dataJumlahCustomer = helper.GetOneData("select count(id_customer) from customer");
            label3.Text = dataJumlahCustomer.Rows[0][0].ToString();
        }
    }
}
