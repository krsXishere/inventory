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
    public partial class DataBarangKeluarUC : UserControl
    {
        Helper helper = new Helper();
        public DataBarangKeluarUC()
        {
            InitializeComponent();
        }

        public void DataBarangKeluarUC_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where status_barang='Keluar'");
            dataGridView1.DataSource = dataBarang.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where status_barang='Keluar' and (nama_barang like '%" + txtSearch.Text + "%' or kode_barang like '%" + txtSearch.Text + "%')");
            dataGridView1.DataSource = data.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where and status_barang='Keluar' and tanggal_barang='" + dateTimePicker1.Text + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }
    }
}
