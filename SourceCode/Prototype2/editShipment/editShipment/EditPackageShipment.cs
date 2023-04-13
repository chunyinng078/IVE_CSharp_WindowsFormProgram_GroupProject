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

namespace editShipment
{
    public partial class EditPackageShipment : Form
    {
        String custID = EditShipment.cusID;
        List<Panel> listPanel = new List<Panel>();
        int index;
        public EditPackageShipment()
        {
            InitializeComponent();
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

        private void EditPackageShipment_Load(object sender, EventArgs e)
        {

            listPanel.Add(pnlReceiver);

            listPanel.Add(pnlShipmentDetails2);
            listPanel.Add(pnlSizeWeightAuthorization);
            listPanel[index].BringToFront();

            lblDate.Text = DateTime.Now.ToString();

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "select * from airwaybill where airwayBillID=" + EditShipment.airwaybillno;

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {

                int destination = (int)reader["destinationCountry"];
                if (destination == 0)
                {
                    cmbRecieverCountry.SelectedIndex = 0;
                }
                else if (destination == 2)
                {
                    cmbRecieverCountry.SelectedIndex = 1;
                }
                else if (destination == 3)
                {
                    cmbRecieverCountry.SelectedIndex = 2;
                }



                string deliveryAddress = reader["deliveryAddress"].ToString();
                txtDeliveryAddress.Text = deliveryAddress;

                string postCode = reader["postCode"].ToString();
                txtRecieverPostCode.Text = postCode;

                string receiverCompany = reader["receiverCompany"].ToString();
                txtReceiverCompanyName.Text = receiverCompany;

                string receiverName = reader["receiverName"].ToString();
                txtContactPerson.Text = receiverName;


                string Pieces = reader["Pieces"].ToString();
                txtPieces.Text = Pieces;

                string receiverContact = reader["receiverPhone"].ToString();
                txtReceiverContact.Text = receiverContact.Substring(receiverContact.Length - 8);

                Int64 length = (int)receiverContact.Length;
                int k = (int)length - 8;
                txtReceiverCountryCode.Text = receiverContact.Substring(0, k);



                string receiverEmail = reader["receiverEmail"].ToString();
                txtEmail.Text = receiverEmail;


                string contentDescription = reader["contentDescription"].ToString();
                txtContendDescription.Text = contentDescription;


                string declaredValue = reader["declaredValue"].ToString();
                txtDeclaredValue.Text = declaredValue;

                string weight = reader["weight"].ToString();
                txtWeight.Text = weight;

                string length2 = reader["length"].ToString();
                txtL.Text = length2;

                string width = reader["width"].ToString();
                txtW.Text = width;

                string height = reader["height"].ToString();
                txtH.Text = height;


            }
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string msg = "Please check the following data are filled and correctly:\n\n";

            if (txtWeight.Text == "")
            {
                msg = msg + "Weight\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    double tmp = double.Parse(txtWeight.Text);
                    if (tmp < 3 || tmp > 999)
                    {
                        msg = msg + "Weight, the format of weight should be a number and >=3 and <=999.\n\n";
                    }
                    else if (tmp <= 0)
                    {
                        msg = msg + "Weight, the shipment's weight cannot be <=0.\n\n";
                    }
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

            if (msg.Length != 59)
            {
                MessageBox.Show(msg, "Error");
            }
            else
            {
                double tmp = double.Parse(txtPieces.Text);
                double tmp2 = double.Parse(txtWeight.Text);
                double totalWeight = tmp * tmp2;

                string price = "";
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

                //Sql
                string airwayBillID = EditShipment.airwaybillno;

                insertDatabase(airwayBillID, expense);

            }
        }

        private void insertDatabase(String airwayBillID, double expense)
        {

            string destination="";
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
            string selectCmd2 = "UPDATE `airwaybill` SET " +
                "`destinationCountry`='" + destination + "',`deliveryAddress`='" + cmbRecieverCountry.SelectedIndex + "',`postCode`='" + txtRecieverPostCode.Text + "'," +
                "`receiverCompany`='" + txtReceiverCompanyName.Text + "',`receiverName`='" + txtContactPerson.Text + "',`receiverPhone`='" + (txtReceiverCountryCode.Text + txtReceiverContact.Text) + "'," +
                "`receiverEmail`='" + txtEmail.Text + "',`declaredValue`='" + txtDeclaredValue.Text + "',`contentDescription`='" + txtContendDescription.Text + "'," +
                "`weight`='" + txtWeight.Text + "',`length`='" + txtL.Text + "',`width`='" + txtW.Text + "',`height`='" + txtH.Text + "',`Pieces`='"+txtPieces.Text + "' WHERE airwayBillID=" + airwayBillID;

            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            /// payment table

            string connStr3 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn3 = new MySqlConnection(connStr);
            conn3.Open();
            MySqlDataReader reader3 = null;
         
            string selectCmd3 = "UPDATE `payment` SET `paymentAmount` ='" + expense + "' WHERE airwaybill_airwaybillID=" + airwayBillID;

            MySqlCommand command3 = new MySqlCommand(selectCmd3, conn3);
            reader3 = command3.ExecuteReader();

            // ok message
            MessageBox.Show("Update completed!\n" + "\n", "Success");
            conn3.Close();
            conn2.Close();
            this.Close();
        }

        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();

        }

        private void btnClearTransportCharges_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDestinationDutiesTaxes_Click(object sender, EventArgs e)
        {

        }

        private void rdoChargesPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoWorldMail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
          
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
                    msg = msg + "Email , format not right. \n\n";
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

        private void btnNext1_Click(object sender, EventArgs e)
        {
           
        }

        private void rdoOtherService_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void cbShipmentInsurance_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pnlReceiver_Paint(object sender, PaintEventArgs e)
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

        private void btnPrevious5_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }
    }
}
