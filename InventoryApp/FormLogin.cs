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
    public partial class FormLogin : Form
    {
        Helper helper = new Helper();
        public static string id_user;
        public static string nama;
        public static string level_user;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataTable dt = helper.Login(txtUsername.Text, txtPassword.Text);
                if(dt.Rows.Count == 1)
                {
                    id_user = dt.Rows[0][0].ToString();
                    nama = dt.Rows[0][1].ToString();
                    level_user = dt.Rows[0][2].ToString();

                    if(level_user == "Admin")
                    {
                        FormAdmin fa = new FormAdmin();
                        this.Hide();
                        fa.Show();
                        helper.LogActivity("login");
                    } else if(level_user == "Manager")
                    {
                        FormManager fm = new FormManager();
                        this.Hide();
                        fm.Show();
                        helper.LogActivity("login");
                    } else if(level_user == "Karyawan Gudang")
                    {
                        FormKaryawanGudang fkg = new FormKaryawanGudang();
                        this.Hide();
                        fkg.Show();
                        helper.LogActivity("login");
                    } else if(level_user == "Karyawan Purchasing")
                    {
                        FormKaryawanPurchasing fkp = new FormKaryawanPurchasing();
                        this.Hide();
                        fkp.Show();
                        helper.LogActivity("login");
                    } else { }
                } else
                {
                    wrong.Visible = true;
                    txtUsername.Clear();
                    txtPassword.Clear();
                }

            } else
            {
                helper.FillAllFields();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            wrong.Visible = false;
        }
    }
}
