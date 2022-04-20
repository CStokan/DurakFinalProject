using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DurakForm
{
    public partial class frmLogin : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != string.Empty || txtPassword.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where email='" + txtEmail.Text + "' and password='" + txtPassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
            
                    dr.Close();
                    this.Hide();
                    frmDurakGame home = new frmDurakGame();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Onur\Desktop\Durak\DurakForm\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }
    }
}
