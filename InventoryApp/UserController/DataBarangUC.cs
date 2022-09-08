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
    public partial class DataBarangUC : UserControl
    {
        Helper helper = new Helper();
        int id;
        public DataBarangUC()
        {
            InitializeComponent();
        }

        public void DataBarangUC_Load(object sender, EventArgs e)
        {
            DataSet dataBarang = helper.GetData("select id_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang");
            dataGridView1.DataSource = dataBarang.Tables[0];
        }

        private void ClearAll()
        {
            txtKodeBarang.Clear();
            txtNamaBarang.Clear();
            txtStatusBarang.Text = "";
            txtStatusBarang.SelectedIndex = -1;
            txtStokBarang.Clear();
            txtKondisiBarang.Text = "";
            txtKondisiBarang.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtStatusBarang.Text != "" && txtStokBarang.Text != "" && txtKondisiBarang.Text != "")
            {
                if (MessageBox.Show("Simpan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    helper.SetData("insert into barang(kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang) values('" + txtKodeBarang.Text + "', '" + txtNamaBarang.Text + "', '" + txtStatusBarang.Text + "', '" + txtStokBarang.Text + "', '" + txtKondisiBarang.Text + "')", "Berhasil menambahkan data barang.");
                    DataBarangUC_Load(this, null);
                    ClearAll();
                    helper.LogActivity("menambahkan data barang");
                }
            } else
            {
                helper.FillAllFields();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtStatusBarang.Text != "" && txtStokBarang.Text != "" && txtKondisiBarang.Text != "")
            {
                if (MessageBox.Show("Simpan perubahan data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    DataTable namaBarangDB = helper.GetOneData("select nama_barang from barang where id_barang='" + id + "'");
                    String getNamaBarangDB = namaBarangDB.Rows[0][0].ToString();
                    DataTable stok = helper.GetOneData("select stok_barang from barang where id_barang='" + id + "'");
                    DataTable namaBarang = helper.GetOneData("select nama_barang from barang where id_barang='" + id + "'");
                    String getNamaBarang = namaBarang.Rows[0][0].ToString();
                    int jumlahStokAwal = int.Parse(stok.Rows[0][0].ToString());
                    int inputJumlahStokBaru = int.Parse(txtStokBarang.Text);

                    if (txtStatusBarang.Text == "Keluar")
                    {
                        if (jumlahStokAwal >= inputJumlahStokBaru)
                        {
                            int jumlahStokBaru = jumlahStokAwal - inputJumlahStokBaru;

                            helper.SetData("update barang set stok_barang='" + jumlahStokBaru + "' where id_barang='" + id + "'", "Berhasil mengeluarkan stok barang.");
                            helper.SetDataWithOutMessageBox("insert into log_barang(kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang) values('" + txtKodeBarang.Text + "', '" + txtNamaBarang.Text + "', '" + txtStatusBarang.Text + "', '" + txtStokBarang.Text + "', '" + txtKondisiBarang.Text + "')");
                            DataBarangUC_Load(this, null);
                            ClearAll();
                            helper.LogActivity("mengeluarkan " + getNamaBarang + " dengan jumlah stok " + inputJumlahStokBaru + "");
                        }
                        else
                        {
                            MessageBox.Show("Stok untuk keluar tidak boleh lebih besar dari stok dalam database.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClearAll();
                        }
                    }
                    else if (txtStatusBarang.Text == "Masuk" && txtNamaBarang.Text == getNamaBarangDB)
                    {
                        int jumlahStokBaruTambah = jumlahStokAwal + inputJumlahStokBaru;

                        helper.SetData("update barang set stok_barang='" + jumlahStokBaruTambah + "' where id_barang='" + id + "'", "Berhasil menambah stok barang.");
                        helper.SetDataWithOutMessageBox("insert into log_barang(kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang) values('" + txtKodeBarang.Text + "', '" + txtNamaBarang.Text + "', '" + txtStatusBarang.Text + "', '" + txtStokBarang.Text + "', '" + txtKondisiBarang.Text + "')");
                        DataBarangUC_Load(this, null);
                        ClearAll();
                        helper.LogActivity("menambahkan " + getNamaBarang + " dengan jumlah stok " + inputJumlahStokBaru + "");
                    }
                    else
                    {
                        helper.SetData("update barang set kode_barang='" + txtKodeBarang.Text + "', nama_barang='" + txtNamaBarang.Text + "', status_barang='" + txtStatusBarang.Text + "', stok_barang='" + txtStokBarang.Text + "', kondisi_barang='" + txtKondisiBarang.Text + "' where id_barang='" + id + "'", "Berhasil mengedit data barang.");
                        DataBarangUC_Load(this, null);
                        ClearAll();
                        helper.LogActivity("mengedit data barang");
                    }
                }

            } else
            {
                MessageBox.Show("Pilih data untuk diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtKodeBarang.Text != "" && txtNamaBarang.Text != "" && txtStatusBarang.Text != "" && txtStokBarang.Text != "" && txtKondisiBarang.Text != "")
            {
                if (MessageBox.Show("Hapus data?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    helper.SetData("delete from barang where id_barang='" + id + "'", "Berhasil menghapus data barang.");
                    DataBarangUC_Load(this, null);
                    ClearAll();
                    helper.LogActivity("menghapus data barang");
                }

            } else
            {
                MessageBox.Show("Pilih data untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtStokBarang_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtStokBarang.Text, "[^0-9]"))
            {
                MessageBox.Show("Data stok harus diisi dengan nomor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStokBarang.Text = txtStokBarang.Text.Remove(txtStokBarang.Text.Length - 1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtKodeBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNamaBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtStatusBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStokBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtKondisiBarang.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataSet data = helper.GetData("select id_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang where nama_barang like '%" + txtSearch.Text + "%' or kode_barang like '%" + txtSearch.Text + "%' or status_barang like '%" + txtSearch.Text + "%' or kondisi_barang like '%" + txtSearch.Text + "%'");
            dataGridView1.DataSource = data.Tables[0];
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(theDate);
            DataSet dataLog = helper.GetData("select id_barang, kode_barang, nama_barang, status_barang, stok_barang, kondisi_barang, tanggal_barang from barang where tanggal_barang='" + theDate + "'");
            dataGridView1.DataSource = dataLog.Tables[0];
        }
    }
}
