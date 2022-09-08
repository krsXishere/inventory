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
    public partial class DataBarangRusakUC : UserControl
    {
        Helper helper = new Helper();
        public DataBarangRusakUC()
        {
            InitializeComponent();
        }

        public void DataBarangRusakUC_Load(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            DataSet dataBarang = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where kondisi_barang='Rusak' and tanggal_barang='" + theDate + "'");
            dataGridView1.DataSource = dataBarang.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where kondisi_barang='Rusak' and (nama_barang like '%" + txtSearch.Text + "%' or kode_barang like '%" + txtSearch.Text + "%')");
            dataGridView1.DataSource = data.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select id_log_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from log_barang where kondisi_barang='Rusak' and tanggal_barang='" + theDate + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }
    }
}
