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
    }
}
