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
using System.Net;
using System.Net.Mail;

namespace ProcessShipment
{
    public partial class ProcessShipmentCustomer : Form
    {

        public ProcessShipmentCustomer()
        {
            InitializeComponent();
        }


        private void btnAirwayBill_Click(object sender, EventArgs e)
        {
            if (txtBoxAirwayBillID.Text == "") // if no bill number is supplied
            {
                txtBoxShipmentStatus.Text = "Please eneter an airway bill number";
            }
            else 
            {
                string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";
                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();

                MySqlDataReader reader = null;

                string query = "SELECT * FROM `airwayBill` WHERE `airwayBillID` ='" + txtBoxAirwayBillID.Text + "'";
                MySqlCommand commandDB = new MySqlCommand(query, conn);

                reader = commandDB.ExecuteReader();

                if (reader.Read())
                {
                    txtBoxShipmentStatus.Text = reader["statusComment"].ToString();
                }
                else
                {
                    string newLine = Environment.NewLine;
                    txtBoxShipmentStatus.Text = "No record found!" + newLine + "Please check again the airway bill number"; // if inputed value does not match data stored in database
                }
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
