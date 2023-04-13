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
using System.Text.RegularExpressions;

namespace Login_1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

      
        public void registNewaccount()
        {
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            try
            {
                MessageBox.Show("register now");
                string query = "INSERT INTO `customer`(`cusID`,`CusUserName`, `cusName`, `cusPhone`, `cusPassword`, `cusAddress`,`cusEmail`) VALUES ('"+ GetMaxcusID() + "','" + txtUserName.Text + "','"+txtLastName.Text +" " + TxtFirstName.Text+ "','"+Int64.Parse(txtPhoneNumber.Text)
                    +"','"+txtPWD.Text+"','"+txtAddress.Text+"','"+txtEmail.Text+"')";
                // connection
                databaseConnection.Open();
                MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
                commandDB.ExecuteNonQuery();
                MessageBox.Show("finish");
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("You need to enter a username");
            }else if (isUserNameUsed(txtUserName.Text))
            {
                MessageBox.Show("The username has already been used");
            }
            else if (txtPWD.Text != txtRePWD.Text)
            {
                MessageBox.Show("Two inpiuts for the password are not the identical !");
            }
            else if (String.IsNullOrWhiteSpace(TxtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("You need to enther your Frist name and your last name");
            }
            else if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("The Email format is not correct. The Correct Email format should be xxx@xxx.xx ");
            }
            else if (!IsValid(txtEmail.Text))
            {
                MessageBox.Show("The Email format in not valid");
            }
            else if (isEmailUsed(txtEmail.Text))
            {
                MessageBox.Show("The Email has already been used");
            }
            else if (String.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("You need to enter the a Phone Number");
            }
             else if (!isPhoneNumber(txtPhoneNumber.Text)) 
            {
                    MessageBox.Show("The Phone number should be 8 digits ");
            }
            else if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("The Address field must not be empty");
            }
            else
            {
                   registNewaccount();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public static bool isPhoneNumber(String number)
        {
            Regex phone = new Regex(@"^\d{8}");
            
            return phone.IsMatch(number);
        }
        public static bool IsValid(string emailaddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
           
            return regex.IsMatch(emailaddress);
        }

        public bool isUserNameUsed(string username)
        {


            string query = "SELECT * FROM `customer` WHERE `cusUserName`='" + username + "'";
            // connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDB.ExecuteReader();


            return (reader.HasRows);
        }
        public bool isEmailUsed(string emailaddress)
        {

            
            string query = "SELECT * FROM `customer` WHERE `cusEmail`='" + emailaddress + "'";
            // connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDB.ExecuteReader();


            return (reader.HasRows);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            

            if (txtPWD.PasswordChar == '\0')
            {
                lblShowPassword.Text = "show password";
                txtPWD.PasswordChar = '*';
                txtRePWD.PasswordChar = '*';
            }
            else
            {
                lblShowPassword.Text = "hide password";
                txtPWD.PasswordChar = '\0';
                txtRePWD.PasswordChar = '\0';
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private int GetMaxcusID()
        {
            int CusID=1;
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "SELECT MAX(cusID) FROM customer";

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                CusID = (int)reader["MAX(cusID)"];
                CusID = CusID + 1;
                
            }
            conn.Close();
            return CusID;
            
            
        }
    }
}
