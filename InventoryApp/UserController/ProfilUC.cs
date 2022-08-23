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
    public partial class ProfilUC : UserControl
    {
        Helper helper = new Helper();
        public ProfilUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            fa.Hide();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void ProfilUC_Load(object sender, EventArgs e)
        {
            DataTable dataNama = helper.GetOneData("select nama_user from users");
            name.Text = dataNama.Rows[0][0].ToString();
            greeting.Text = "Hai! " + dataNama.Rows[0][0].ToString();

            DataTable dataAlamat = helper.GetOneData("select alamat_user from users");
            alamatUser.Text = dataAlamat.Rows[0][0].ToString();

            DataTable dataTelfon = helper.GetOneData("select telfon_user from users");
            tlfn.Text = dataTelfon.Rows[0][0].ToString();

            DataTable dataTglBergabung = helper.GetOneData("select tanggal_bergabung from users");
            tglbergabung.Text = dataTglBergabung.Rows[0][0].ToString();

            DataTable dataUsername = helper.GetOneData("select username from users");
            userName.Text = dataUsername.Rows[0][0].ToString();

            DataTable dataPassword = helper.GetOneData("select pass from users");
            password.Text = dataPassword.Rows[0][0].ToString();

            DataTable dataJabatan = helper.GetOneData("select level_user from users");
            jabatan.Text = dataJabatan.Rows[0][0].ToString();
        }
    }
}
