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

namespace Login_1
{
   
    public partial class forgetPassword : Form
    {
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";
        public forgetPassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("You need to enther a username");
            }
            else if (String.IsNullOrWhiteSpace(txtPWD.Text) || String.IsNullOrWhiteSpace(txtRePWD.Text))
            {
                MessageBox.Show("You need to enter a passowrd");
            }
            else if (txtPWD.Text != txtRePWD.Text)
            {
                MessageBox.Show("Two inputs for password are not identital");
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("You need to enther an Email address");
            }else if (!isUserExsits(txtUserName.Text, txtEmail.Text))
            {
                MessageBox.Show("The username or Email does not exsit. Please check again");
            }
            else
            {
                resetPassword();
            }
        }

        public void resetPassword()
        {
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            try
            {
                MessageBox.Show("Reset Password Now");
                string query ="UPDATE `customer` SET `cusPassword`='" + txtPWD.Text + "' WHERE `customer`.`CusUserName` ='" + txtUserName.Text+ "';"; 
                // connection
                databaseConnection.Open();
                MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
                commandDB.ExecuteNonQuery();
                databaseConnection.Close();
                MessageBox.Show("Finish");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        public bool isUserExsits(string username,string Email)
        {


            string query = "SELECT * FROM `customer` WHERE cusUserName='" + username + "' AND cusEmail ='"+Email+"';";
            // connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDB.ExecuteReader();


            return (reader.HasRows);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (txtPWD.PasswordChar == '\0')
            {
                label1.Text = "show password";
                txtPWD.PasswordChar = '*';
                txtRePWD.PasswordChar = '*';
            }
            else
            {
                label1.Text = "hide password";
                txtPWD.PasswordChar = '\0';
                txtRePWD.PasswordChar = '\0';
            }
        }

        private void txtRePWD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
