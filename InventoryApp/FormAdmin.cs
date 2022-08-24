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
            DataTable userLevelLabel = helper.GetOneData("select level_user from users where id_user='" + FormLogin.id_user + "'");
            user.Text = userLevelLabel.Rows[0][0].ToString();

            dashboardUC1.Visible = true;
            dashboardUC1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboardUC1.Visible = true;
            dashboardUC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataBarangUC1.Visible = true;
            dataBarangUC1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            profilUC1.Visible = true;
            profilUC1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda akan log-out?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                FormLogin fl = new FormLogin();
                fl.Show();
                helper.LogActivity("logout");
            }
        }
    }
}
