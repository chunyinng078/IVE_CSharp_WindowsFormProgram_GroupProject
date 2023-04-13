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
    public partial class EditRegularSupplies : Form
    {
        String productID;
        public EditRegularSupplies(String ProductID)
        {
            this.productID = ProductID;
            InitializeComponent();
            lblProductID.Text = productID;


            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "select * from `regularproduct` where ProductID='" + ProductID+"';";

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                String Value = reader["UnitValue"].ToString();
                tbValue.Text = Value;

               


                String Description = reader["Description"].ToString();
                tbDescription.Text = Description;

                String Reason = reader["Reason"].ToString();
                tbReason.Text = Reason;


            }
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("You Need to enter the Description");
            }
            else if (string.IsNullOrEmpty(tbReason.Text))
            {
                MessageBox.Show("You Need to enter the Reason");
            }
            else if (string.IsNullOrEmpty(tbValue.Text))
            {
                MessageBox.Show("You Need to enter the product unit Value");
            }else if (string.IsNullOrEmpty(tbWeight.Text)) { 
                MessageBox.Show("You Need to enter the product unit Value");
            }
            else
            {
                updateDB();
                this.Close();
            }
        }

        private void updateDB()
        {
            try
            {
                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn2 = new MySqlConnection(connStr);
                conn2.Open();
                MySqlDataReader reader2 = null;


                string selectCmd2 = "UPDATE `regularproduct` SET `Description`= '" + tbDescription.Text + "',`UnitValue`= '" + tbValue.Text + "',`Reason`= '" + tbReason.Text + "',`weight`= '" + tbWeight.Text + "' WHERE `ProductID` = '" + productID + "'";

                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                // ok message
                MessageBox.Show("Update completed!\n" + "\n", "Success");
                conn2.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void tbWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditRegularSupplies_Load(object sender, EventArgs e)
        {

        }
    }
}
