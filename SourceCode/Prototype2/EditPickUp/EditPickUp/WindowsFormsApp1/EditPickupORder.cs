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

namespace WindowsFormsApp1
{
    public partial class EditPickupORder : Form
    {
        String pickupID;
        public EditPickupORder(String pickupID)
        {
            this.pickupID = pickupID;
            String cusID = EditPickUp.cusID;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EditPickupORder_Load(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "select * from pickup where pickupID=" + EditPickUp.pickupId;

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                String cusID = reader["pickup_cusID"].ToString();
                label1.Text = cusID;

                lblpickupIDS.Text = pickupID;


                String pickupAddress = reader["pickup_address"].ToString();
                txtAddress.Text = pickupAddress;

                int services = Int32.Parse(reader["services"].ToString());
                if (services == 0)
                {
                    btnDocument.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }

                string time = reader["pickupDate"].ToString();
                time = time.Replace("-", "/");

            }
            conn.Close();
        }
        private Form activeForm = null;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            insertDatabase();
            this.Close();
        }
        private void insertDatabase()
        {
            int services;
            String time = txtTime.Text;
            time = time.Replace("/", "-");

            if (btnDocument.Checked)
            {
                 services = 0;
            }
            else
            {
                services = 1;
            }
            

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr);
            conn2.Open();
            MySqlDataReader reader2 = null;
            

            string selectCmd2 = "UPDATE `pickup` SET `pickupDate`= '"+time+"',`services`= '"+ services + "',`pickup_address`= '"+txtAddress.Text+"' WHERE pickupID=" + EditPickUp.pickupId;

            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            // ok message
            MessageBox.Show("Update completed!\n" + "\n", "Success");
            conn2.Close();

        }
    }
}
