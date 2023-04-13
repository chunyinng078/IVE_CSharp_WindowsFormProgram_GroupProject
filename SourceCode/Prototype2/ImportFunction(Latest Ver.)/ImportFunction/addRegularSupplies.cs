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

namespace ImportFunction
{
    public partial class AddRegularSupplies : Form
    {
        public String cusID;

        public AddRegularSupplies(String cusID)
        {
            this.cusID = cusID;
            InitializeComponent();
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("You Need to enter the Description");
            }
            else if (string.IsNullOrEmpty(tbID.Text))
            {
                MessageBox.Show("You Need to enter the Product ID");
            }
            else if (string.IsNullOrEmpty(tbReason.Text))
            {
                MessageBox.Show("You Need to enter the Reason");
            }
            else if (string.IsNullOrEmpty(tbValue.Text))
            {
                MessageBox.Show("You Need to enter the product unit Value");
            } else if (isExsits(tbID.Text))
            {
                MessageBox.Show("The product ID is already exsits if you want to edit the ");
            }
            else
            {
                addTodb();
            }


        }

        private void addTodb()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr);
            conn2.Open();
            MySqlDataReader reader2 = null;

            string selectCmd2 = "INSERT INTO `regularproduct`(`ProductID`, `Description`, `UnitValue`, `Reason`, `weight`, `cusID`) VALUES ('" + tbID.Text + "','" + tbDescription.Text + "','" + tbValue.Text + "','" + tbReason.Text + "','" + tbWeight.Text + "','" + cusID + "')";
            try
            {
                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                // ok message
                MessageBox.Show("supplier Created\n" + "\n", "Success");
                conn2.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException a)
            {
                MessageBox.Show("an error occure");

            }
        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblcode_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddRegularSupplies_Load(object sender, EventArgs e)
        {

        }

        private bool isExsits(String porductID)
        {
            string conString = "server=127.0.0.1;uid=root;pwd=;database=ede";
            string query = "SELECT * FROM `regularproduct` WHERE `ProductID`='" + porductID + "' AND cusID = '"+cusID+"';";
            // connection
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            databaseConnection.Open();
            MySqlDataReader reader;
            reader = commandDB.ExecuteReader();


            return (reader.HasRows);
        }
    }
}
