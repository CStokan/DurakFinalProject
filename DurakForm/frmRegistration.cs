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
    public partial class frmRegistration : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
       

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FinalDurakProject\DurakForm\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");

            if (txtConfirmPassword.Text != string.Empty || txtEmail.Text != string.Empty || txtFirstName.Text != string.Empty ||  txtLastName.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where email='" + txtEmail.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("This Email Address Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable(password,FirstName,LastName,email,l_date,e_date) values(@password,@FirstName,@LastName,@email,@l_date,@e_date)", cn);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("LastName", txtLastName.Text);

                        cmd.Parameters.AddWithValue("email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("l_date", sqlFormattedDate);
                        cmd.Parameters.AddWithValue("e_date", sqlFormattedDate);
                       

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                        frmLogin login = new frmLogin();
                        login.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
