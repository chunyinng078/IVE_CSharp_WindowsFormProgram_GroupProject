using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Common;

namespace Login_1
{
    public partial class Login : Form
    {
        int role = 0;
        public Login()
        {
            InitializeComponent();
        }
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

        public void loginCustomer()
        {
            string query = "SELECT * FROM `customer` WHERE `cusUserName`='" + txtUserName.Text + "'AND `cusPassword`='" + txtPWD.Text +"'";
            //login connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Boolean isStaff = false;
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Portal portal = new Portal(txtUserName.Text,isStaff);
                        portal.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password or userID");
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void loginStaff()
        {
            string query = "SELECT * FROM `staff` WHERE `staffUserName` = '" + txtUserName.Text + "'AND `staffPwd`='" + txtPWD.Text + "'";
            //login connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Boolean isStaff = true;
                        MessageBox.Show("Welcome staff");
                        this.Hide();
                        Portal portal = new Portal(txtUserName.Text, isStaff);
                        portal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect password or username");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
   

            if(String.IsNullOrWhiteSpace(txtUserName.Text) ){ MessageBox.Show("You need to fill in Username"); }
            else if(string.IsNullOrWhiteSpace(txtPWD.Text)) { MessageBox.Show("You need to fill in Password"); } 
            else
            {
                if(role == 0) { MessageBox.Show("You need to select a role!"); }
                if (role == 1) { loginStaff(); }
                else if (role == 2) { loginCustomer(); }
                
            }

           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnstaff_CheckedChanged(object sender, EventArgs e)
        {
            role = 1;
        }

        private void btnCus_CheckedChanged(object sender, EventArgs e)
        {
            role = 2;
        }

        private void lblpassword_Click(object sender, EventArgs e)
        {
            


            if (txtPWD.PasswordChar == '\0')
            {
                lblshowpassword.Text = "show password";
                txtPWD.PasswordChar = '*';
            }else
            {
                lblshowpassword.Text = "hide password";
                txtPWD.PasswordChar = '\0';
            }
        }

  
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblforgotPassWord_Click(object sender, EventArgs e)
        {
            forgetPassword forgetPassword = new forgetPassword();
            forgetPassword.ShowDialog();
        }
    }
}
