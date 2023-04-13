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
    public partial class NewPickUpOrder : Form
    {
        int type = 2;
        String userid;
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";
        public NewPickUpOrder(String userid, bool isStaff)
        {
            InitializeComponent();
            this.userid = userid;
            lblUserID.Text = "UserID : " + userid;


            if (isStaff)
            {
                getStaffData();
            }
            else
            {
                getCusData();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        public void getCusData()
        {
            string query = "SELECT `cusName`FROM `customer` WHERE `cusID`='" + userid + "'";
            

            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            string name;
            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();
                while (reader.Read())
                {
                    name = (string)reader["cusName"];
                    lblUserName.Text = name;
                    lblUserName2.Text = name;
                    label1.Text = name;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void getStaffData()
        {
            string query = "SELECT `staffName` FROM `staff` WHERE `staffNo`='" + userid + "'";


            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            string name;
            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();
                while (reader.Read())
                {
                    name = (string)reader["staffName"];
                    lblUserName.Text = name;
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void NewPickUpOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet1.pickup' table. You can move, or remove it, as needed.
           
        }

        private void btnDocument_CheckedChanged(object sender, EventArgs e)
        {
            type = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            type = 1;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String time = DateTime.Now.ToString();
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("You need to enter the pickup address.");
            }else if (type == 2)
            {
                MessageBox.Show("You need to select the service type.");
            }else if(txtTime.Mask == txtTime.Text)
            {
                MessageBox.Show("You need to enter the time.");
            }
            else
            {
                addnewOrder();   
            }
        }

        
        public void addnewOrder()
        {
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            try
            {
                MessageBox.Show("adding new order.");
                string query = "INSERT INTO `pickup`(`pickupID`, `pickupDate`, `services`, `pickup_cusID`, `pickup_address`) VALUES('"+ findMaxID() +"', '"+convertTime()+"', '"+type+ "', '"+userid+"', '"+txtAddress.Text+"')";
                // connection
                databaseConnection.Open();
                MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
                commandDB.ExecuteNonQuery();
                MessageBox.Show("finish");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        private int findMaxID()
        {
            int orderId = 0;
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            string query = "SELECT MAX(pickupID) FROM `pickup`";
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            databaseConnection.Open();
            reader = commandDB.ExecuteReader();

            while(reader.Read())
            {
                orderId = (int)reader[0];
                orderId++;
            }

            return orderId;
            databaseConnection.Close();
        }
        public String convertTime()
        {
            String time = txtTime.Text;
            time = time.Replace("/","-");
            return time;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pickupTableAdapter.FillBy(this.edeDataSet1.pickup);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

  