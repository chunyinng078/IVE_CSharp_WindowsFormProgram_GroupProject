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
    public partial class EditDocumentShipment : Form
    {
        String cusID = EditShipment.cusID;
        List<Panel> listPanel = new List<Panel>();
        int index;

        public EditDocumentShipment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(pnlReceiver);;
            listPanel.Add(pnlSizeWeightAuthorization);
            listPanel[index].BringToFront();

            lblDate.Text = DateTime.Now.ToString();

            cmbRecieverCountry.SelectedIndex = 0;

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

                string weight = reader["weight"].ToString();
                txtWeight.Text = weight;

                string contentDescription = reader["contentDescription"].ToString();
                txtContendDescription.Text = contentDescription;


            }
            conn.Close();
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

        private void btnNext1_Click(object sender, EventArgs e)
        {
           
        }

        private void pnlReceiver_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rdoOtherService_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbShipmentInsurance_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void rdoOther_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
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

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            
        }

        private void rdoChargesPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnClearTransportCharges_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDestinationDutiesTaxes_Click(object sender, EventArgs e)
        {
        
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
                    if (tmp >= 3)
                    {
                        msg = msg + "Weight, document shipment's weight cannot be over 3 kg.\n\n";
                    }
                    else if (tmp <= 0)
                    {
                        msg = msg + "Weight, document shipment's weight cannot be <=0.\n\n";
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

                    if (totalWeight >= 3)
                    {
                        msg = msg + "Total Weight, document shipment's weight cannot be over 3 kg, total weight = weight * pieces. If you want your shipment over 3kg, you should choose package shimpent. \n\n";
                    }
                    else if (totalWeight <= 0)
                    {
                        msg = msg + "Total Weight, document shipment's weight cannot be <=0. (total weight = weight * pieces)\n\n";
                    }

                }
                catch (System.FormatException)
                {
                    msg = msg + "Pieces, please enter Pieces with integer number.\n\n";
                }
            }


            if (txtContendDescription.Text == "")
            {
                msg = msg + "Content Description\n\n";

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
                //Calculate expense
                double tmp = double.Parse(txtPieces.Text);
                double tmp2 = double.Parse(txtWeight.Text);
                double totalWeight = tmp * tmp2;

                double price;
                if (totalWeight <= 0.5)
                {
                    price = 158;
                }
                else
                {
                    /*   (kg)       ($)
                         0.1-0.5	158
                         0.6-1.0	308
                         1.1-1.5	458
                         1.6-2.0	608
                         2.1-2.5	758
                         2.6-2.9	908
                     */
                    totalWeight = totalWeight - 0.5;
                    double count = 158;
                    while (totalWeight > 0)
                    {
                        totalWeight = totalWeight - 0.5;
                        count = count + 150;
                    }
                    price = count;
                }

                ///Sql


                string airwayBillID = EditShipment.airwaybillno;

                insertDatabase(airwayBillID, price);

            }
        }
        private void insertDatabase(string airwayBillID, double price)
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

            string selectCmd2 = "UPDATE `airwaybill` SET `destinationCountry`='"+ destination + "'," +
                "`deliveryAddress`='" + txtDeliveryAddress.Text + "',`postCode`='" + txtRecieverPostCode.Text + "',`receiverCompany`='" + txtReceiverCompanyName.Text + "',`receiverName`='" + txtContactPerson.Text + "',`receiverPhone`='" + (txtReceiverCountryCode.Text+txtReceiverContact.Text) + "'," +
                "`receiverEmail`='" + txtEmail.Text + "',`contentDescription`='" + txtContendDescription.Text + "',`weight`='" + txtWeight.Text+ "', `Pieces`='"+txtPieces.Text+"' WHERE airwayBillID=" + airwayBillID;

            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();

            /// payment table

            string connStr3 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn3 = new MySqlConnection(connStr);
            conn3.Open();
            MySqlDataReader reader3 = null;

            string selectCmd3 = "UPDATE `payment` SET `paymentAmount`='" + price + "' WHERE airwaybill_airwaybillID=" + airwayBillID;

            MySqlCommand command3 = new MySqlCommand(selectCmd3, conn3);
            reader3 = command3.ExecuteReader();



            // ok message
            MessageBox.Show("Update completed!\n" + "\n", "Success");
            conn2.Close();
            conn3.Close();
            this.Close();
        }

        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPieces_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
