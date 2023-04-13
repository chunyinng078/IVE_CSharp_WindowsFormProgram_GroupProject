using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CreateShipment
{
    public partial class CreatePackageShipment : Form
    {

        
        List<Panel> listPanel = new List<Panel>();
        int index;
        string custID = CreateShipments.custID;
        bool staff = CreateShipments.staff;
        public CreatePackageShipment()
        {
            InitializeComponent();
            InitializeComponent();
            if (staff == false)
            {
                cusFill1.Hide();
                cusFill2.Hide();
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.BringToFront();
            childForm.Show();
            
        }
        private void CreatePackageShipment_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlReceiver);
            listPanel.Add(pnlShipmentDetails2);
            listPanel.Add(pnlSizeWeightAuthorization);
            listPanel[index].BringToFront();

            lblDate.Text = DateTime.Now.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg = "Please check the following data are filled and correctly:\n\n";

            if (txtWeight.Text=="")
            {
                msg = msg + "Weight\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    double tmp = double.Parse(txtWeight.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Weight, please enter weight with number.\n\n";
                }
            }

            if (txtPieces.Text == "")
            {
                msg = msg + "Pieces\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtPieces.Text);
                    double tmp2 = double.Parse(txtWeight.Text);
                    double totalWeight = tmp * tmp2;

                    if (totalWeight > 999)
                    {
                        msg = msg + "Total Weight, package shipment's weight cannot be over 999 kg, total weight = weight * pieces. \n\n";
                    }
                    else if (totalWeight < 3)
                    {
                        msg = msg + "Total Weight, package shipment's weight cannot be <3. (total weight = weight * pieces), weight less than 3 please use document shipment services.\n\n";
                    }

                }
                catch (System.FormatException)
                {
                    msg = msg + "Pieces, please enter Pieces with integer number.\n\n";
                }
            }


            if (txtL.Text == "")
            {
                msg = msg + "Dimensions (L)\n\n";
            }
            else
            {
                try                 // check if L inputed as number
                {
                    int tmp = int.Parse(txtL.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Dimensions (L), please enter with number.\n\n";
                }
            }

            if (txtW.Text == "")
            {
                msg = msg + "Dimensions (W)\n\n";
            }
            else
            {
                try                 // check if W inputed as number
                {
                    int tmp = int.Parse(txtW.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Dimensions (W), please enter with number.\n\n";
                }
            }

            if (txtH.Text == "")
            {
                msg = msg + "Dimensions (H)\n\n";
            }
            else
            {
                try                 // check if H inputed as number
                {
                    int tmp = int.Parse(txtH.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Dimensions (H), please enter with number.\n\n";
                }
            }


            if (cbAgreement.Checked == false)
            {
                msg = msg + "Authorization, please tick the checkbox to agree the statment inorder to use out service.\n\n";
            }
            if (staff == true)
            {
                if (cusFill2.Text == "")
                {
                    msg = msg + "cusID, please enter the cusID.\n\n";
                }
                //db search cusID


                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();

                MySqlDataReader reader = null;
                custID = cusFill2.Text;

                //

            }


            if (msg.Length != 59)
            {
                MessageBox.Show(msg, "Error");
            }
            else
            {
                //Calculate expense
                double tmp = double.Parse(txtPieces.Text);
                double tmp2 = double.Parse(txtWeight.Text);
                double totalWeight = tmp * tmp2;

                string price="";
                if (totalWeight >= 3 && totalWeight <= 15)   //check what the expenses should be
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "75"; break;
                        case "JAPAN":
                            price = "75"; break;
                        case "China SHANGHAI":
                            price = "45"; break;
                    }
                }
                else if (totalWeight >= 16 && totalWeight <= 29)
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "70"; break;
                        case "JAPAN":
                            price = "70"; break;
                        case "China SHANGHAI":
                            price = "40"; break;
                    }
                }
                else if (totalWeight >= 30 && totalWeight <= 44)
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "65"; break;
                        case "JAPAN":
                            price = "65"; break;
                        case "China SHANGHAI":
                            price = "37"; break;
                    }
                }
                else if (totalWeight >= 45 && totalWeight <= 69)
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "62"; break;
                        case "JAPAN":
                            price = "62"; break;
                        case "China SHANGHAI":
                            price = "35"; break;
                    }
                }
                else if (totalWeight >= 70 && totalWeight <= 99)
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "61"; break;
                        case "JAPAN":
                            price = "61"; break;
                        case "China SHANGHAI":
                            price = "33"; break;
                    }
                }
                else
                {
                    switch (cmbRecieverCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            price = "58"; break;
                        case "JAPAN":
                            price = "58"; break;
                        case "China SHANGHAI":
                            price = "32"; break;
                    }
                }


                double expense = double.Parse(price);
                double kg = Math.Ceiling(totalWeight);
                expense = expense * kg;

                //sql payment 
                string connStr3 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn3 = new MySqlConnection(connStr3);

                conn3.Open();

                MySqlDataReader reader3 = null;
                string selectCmd3 = "SELECT MAX(paymentID) FROM payment";

                MySqlCommand command3 = new MySqlCommand(selectCmd3, conn3);
                reader3 = command3.ExecuteReader();

                int paymentID = 0;
                try
                {
                    while (reader3.Read())
                    {
                        paymentID = (int)reader3["MAX(paymentID)"];
                        paymentID = paymentID + 1;
                    }
                }
                catch (System.InvalidCastException v)
                {
                    paymentID = 1;
                }
                conn3.Close();


                //Sql
                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();

                MySqlDataReader reader = null;
                string selectCmd = "SELECT MAX(airwayBillID) FROM airwaybill";

                MySqlCommand command = new MySqlCommand(selectCmd, conn);
                reader = command.ExecuteReader();

                int airwayBillID=0;
                while (reader.Read())
                {
                    airwayBillID = (int)reader["MAX(airwayBillID)"];
                    airwayBillID = airwayBillID + 1;
                }
                conn.Close();

                insertDatabase(airwayBillID);

                String now = DateTime.Now.ToString("yyyy-MM-dd");
                string time = now.ToString();
                time = time.Replace("/", "-");
                time = time.Replace("PM", "");

                DateTime expires = DateTime.Now.AddDays(30);
                String dueDate = expires.ToString("yyyy-MM-dd HH:mm:ss");
                dueDate = dueDate.Replace("/", "-");
                dueDate = dueDate.Replace("PM", "");





                string connStr4 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn4 = new MySqlConnection(connStr4);

                conn4.Open();

                MySqlDataReader reader4 = null;
                string selectCmd4 = "INSERT INTO `payment` (`paymentID`, `paymentAmount`, `paymentDueDate`," +
                    " `paymentStatus`, `payment_cusID`, `airwaybill_airwayBillId`, `date`)" +
                    " VALUES ('" + paymentID + "', '" + expense + "', '" + dueDate + "', '0', '" + custID + "', '" + airwayBillID + "', '" + time + "')";

                try
                {
                    MySqlCommand command4 = new MySqlCommand(selectCmd4, conn4);
                    reader4 = command4.ExecuteReader();
                    conn4.Close();

                    this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException a)
                {


                }
            }
        }


        private void insertDatabase(int airwayBillID)
        {

            string destination = "";
            if (cmbRecieverCountry.SelectedIndex == 0)
            {
                destination = "0";
            }
            if (cmbRecieverCountry.SelectedIndex == 1)
            {
                destination = "2";
            }
            if (cmbRecieverCountry.SelectedIndex == 2)
            {
                destination = "3";
            }

            String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string time = now.ToString();
            time = time.Replace("/", "-");
            time = time.Replace("PM", "");

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr);
            conn2.Open();
            MySqlDataReader reader2 = null;
            string selectCmd2 = "INSERT INTO airwaybill(airwayBillID, services, " +
                            "destinationCountry, deliveryAddress, postCode, receiverCompany, receiverName," +
                            " receiverPhone, receiverEmail, declaredValue, contentDescription, weight, length, " +
                            "width, height, date, status, statusComment, cusID,Pieces) VALUES ('" + airwayBillID + "','" + 1
                            + "','" + destination + "','" + txtDeliveryAddress.Text + "','" +
                            txtRecieverPostCode.Text + "','" + txtReceiverCompanyName.Text + "','" + txtContactPerson.Text +
                            "','" + (txtReceiverCountryCode.Text + txtReceiverContact.Text) + "','" + txtEmail.Text + "','" + txtDeclaredValue.Text
                            + "','" + txtContendDescription.Text + "','" + txtWeight.Text + "','" + txtL.Text + "','" + txtW.Text + "','"
                            + txtH.Text + "','" + time + "','In Process','NULL','" + custID + "','"+ txtPieces.Text + "')";
            
            try
            {
                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                // ok message
                MessageBox.Show("Shipment Created\n" + "\n", "Success");
                conn2.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException a)
            {
                MessageBox.Show("No such cusID");

            }

        }
        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }






     

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();

        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            string msg = "Please check the following data are filled and correctly:\n\n";

            if (txtReceiverCompanyName.Text == "")
            {
                msg = msg + "Company name\n\n";
            }


            if (txtDeliveryAddress.Text == "")
            {
                msg = msg + "Address\n\n";
            }

            if (txtRecieverPostCode.Text == "")
            {
                msg = msg + "Postcode\n\n";
            }

            if (cmbRecieverCountry.Text == "")
            {
                msg = msg + "Country\n\n";
            }

            if (txtContactPerson.Text == "")
            {
                msg = msg + "Contact Person\n\n";
            }

            //

            if (txtReceiverCountryCode.Text == "")
            {
                msg = msg + "Country Code. \n\n";

            }
            else if (txtReceiverCountryCode.Text == "0" || txtReceiverCountryCode.Text == "00" || txtReceiverCountryCode.Text == "000")
            {
                msg = msg + "Contact country code, please enter country code in number and cannot be zero.\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtReceiverCountryCode.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Contact country code, please enter country code in number and cannot be zero.\n\n";
                }
            }



            if (txtReceiverContact.Text == "")
            {
                msg = msg + "Contact number \n\n";
            }
            else if (txtReceiverContact.Text == "00000000")
            {
                msg = msg + "Contact number, phone number cannot be all zero.\n\n";
            }
            else if (txtReceiverContact.Text.Length != 8)
            {
                msg = msg + "Contact number, please enter contact number with eight number.\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtReceiverContact.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Contact number, please enter contact number with eight number.\n\n";
                }
            }

            if (txtEmail.Text == "")
            {
                msg = msg + "Email. \n\n";

            }
            else
            {
                bool IsValid = false;
                Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                if (!r.IsMatch(txtEmail.Text))
                {
                    msg = msg + "Email , format not right. e.g: tom@gmail.com  \n\n";
                }

            }

            if (msg.Length != 59)
            {
                MessageBox.Show(msg, "Error");
            }
            else
            {
                
                listPanel[++index].BringToFront();
            }
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
           if (index > 0)
                listPanel[--index].BringToFront();
        }





        

        private void pnlReceiver_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnPrevious4_Click_1(object sender, EventArgs e)
        {
            //if (index > 0)
                listPanel[--index].BringToFront();

        }

        private void pnlShipmentDetails2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
            string msg = "Please check the following data are filled and correctly:\n\n";
            if (txtDeclaredValue.Text == "")
            {
                msg = msg + "Declared value\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtDeclaredValue.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Declared Value, please enter the value with number.\n\n";
                }

            }

            if (txtContendDescription.Text == "")
            {
                msg = msg + "Content Description\n\n";
            }


            if (txtHarmonizedCommodityCode.Text != "")
            {
                try                 // check if Harmonized Commodity Code inputed as number
                {
                    int tmp = int.Parse(txtHarmonizedCommodityCode.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Harmonized Commodity Code, please enter the code with number.\n\n";
                }
            }

            if (msg.Length != 59)
            {
                MessageBox.Show(msg, "Error");
            }
            else if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
