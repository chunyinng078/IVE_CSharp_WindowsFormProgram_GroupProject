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
    public partial class ProcessShipmentStaff : Form
    {

        public String tmpText;
        public String tmpBillNo;
        public String tmpEmail;

        public ProcessShipmentStaff()
        {
            InitializeComponent();
        }

        public ProcessShipmentStaff(bool isStaff)
        {
            InitializeComponent();
            if (isStaff)
            {
                btnUpdateShipmentStatus.Hide();
                txtBoxShipmentStatus.ReadOnly = true;
                txtBoxShipmentStatus.BackColor = Color.Gray;
            }
        }



        private void btnAirwayBill_Click(object sender, EventArgs e)
        {

            if (txtBoxAirwayBillID.Text == "") // if no bill number is supplied
            {
                txtBoxShipmentStatus.Text = "Please eneter an airway bill number";
                btnUpdateShipmentStatus.Enabled = false;
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
                    tmpText = txtBoxShipmentStatus.Text;
                    tmpBillNo = txtBoxAirwayBillID.Text;
                    tmpEmail = reader["receiverEmail"].ToString();
                    btnUpdateShipmentStatus.Enabled = true;
                }
                else
                {
                    string newLine = Environment.NewLine;
                    btnUpdateShipmentStatus.Enabled = false;
                    txtBoxShipmentStatus.Text = "No record found!" + newLine + "Please check again the airway bill number"; // if inputed value does not match data stored in database
                }
                conn.Close();
            }
        }

        private void btnUpdateShipmentStatus_Click(object sender, EventArgs e)
        {
            if (txtBoxShipmentStatus.Text != tmpText)
            {
                string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";
                MySqlConnection conn = new MySqlConnection(conString);
                conn.Open();
                MySqlDataReader reader = null;

                try
                {
                    // read current time and match MySQL format
                    String now = DateTime.Now.ToString("yyyy-MM-dd               HH:mm:ss");
                    string time = now.ToString();
                    time = time.Replace("/", "-");
                    time = time.Replace("PM", "");
                    
                    // update shipment status and the coresponding update time
                    string query = "UPDATE `airwaybill` SET `statusComment`='" + txtBoxShipmentStatus.Text + "',`date`='" + time + "'WHERE `airwayBillID` ='" + tmpBillNo + "'";

                    MySqlCommand commandDB = new MySqlCommand(query, conn);
                    reader = commandDB.ExecuteReader();

                    // send E-mail message to receiver with .Net Service
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("edecourier@gmail.com");
                    if (tmpEmail == "")
                    {
                        tmpEmail = "edecourier@gmail.com";
                    }
                    msg.To.Add(tmpEmail);
                    msg.Subject = "EDE Status Update";
                    msg.Body = "Please note that your item has: " + txtBoxShipmentStatus.Text + " (Last Update: " + time + ")";

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "edecourier@gmail.com";
                    ntcd.Password = "ITP4915mSDP";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Status Updated and Alerted Receiver of Airway Bill " + tmpBillNo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void txtBoxShipmentStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessShipmentStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
