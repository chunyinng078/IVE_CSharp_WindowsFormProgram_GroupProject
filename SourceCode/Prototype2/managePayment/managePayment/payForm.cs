using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managePayment
{
    public partial class payForm : Form
    {
        public payForm()
        {
            InitializeComponent();
        }

        private void individualPayment_Load(object sender, EventArgs e)
        {
            rdoCheque.Checked = false;
            grpCreditCard.Enabled = true;
            grpCheque.Enabled = false;
            txtPaymentType.Text = paymentSelector.paymentType;
            txtTotalAmout.Text = paymentSelector.num_price.ToString();
            txtTotalAmout.Text = paymentSelector.price.ToString();
        }





        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = open.FileName;

            }
        }

        private void rdoCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCheque.Checked == true)
            {
                grpCreditCard.Enabled = false;
                grpCheque.Enabled = true;
            }
            if (rdoCreditCard.Checked == true)
            {
                grpCreditCard.Enabled = true;
                grpCheque.Enabled = false;
            }
            if (radioButton1.Checked == true)
            {
                grpCheque.Enabled = false;
                grpCreditCard.Enabled = false;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFilePath.Text="";
            txtCreditCard.Text = "";
            txtCVV.Text = "";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked == true)
            {
                string msg = "Please check the following data are inputed and correctly:\n\n";

                if (txtCreditCard.Text == "")
                {
                    msg = msg + "Credit Card Number \n\n";
                }
                else if (txtCreditCard.Text == "0000000000000000")
                {
                    msg = msg + "Credit Card Number, card number cannot be all zero.\n\n";
                }
                else if (txtCreditCard.Text.Length != 16)
                {
                    msg = msg + "Credit Card Number, please enter contact number with 16 number.\n\n";
                }
                else
                {
                    try                 // check if account no. inputed as number
                    {
                        Int64 tmp = Int64.Parse(txtCreditCard.Text);
                    }
                    catch (System.FormatException)
                    {
                        msg = msg + "Credit Card Number, please enter contact number with 16 number.\n\n";
                    }
                }


                if (txtCVV.Text == "")
                {
                    msg = msg + "CVV \n\n";
                }
                else if (txtCVV.Text == "000")
                {
                    msg = msg + "CVV, CVV code cannot be all zero.\n\n";
                }
                else if (txtCVV.Text.Length != 3)
                {
                    msg = msg + "CVV, please enter CVV with 3 number.\n\n";
                }
                else
                {
                    try                 // check if account no. inputed as number
                    {
                        int tmp = int.Parse(txtCVV.Text);
                    }
                    catch (System.FormatException)
                    {
                        msg = msg + "CVV, please enter CVV with 3 number.\n\n";
                    }
                }

                if (msg.Length != 60)
                {
                    MessageBox.Show(msg, "Error");
                }
                else
                {
                    if (txtPaymentType.Text == "Individual")
                    {
                        //SQL
                        loading aa = new loading();
                        aa.Show();
                        this.Close();
                        string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                        MySqlConnection conn = new MySqlConnection(connStr);

                        conn.Open();

                        MySqlDataReader reader = null;
                        string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='2' WHERE paymentID=" + paymentSelector.paymentID;

                        MySqlCommand command = new MySqlCommand(selectCmd, conn);
                        reader = command.ExecuteReader();
                    }
                    else if (txtPaymentType.Text == "Monthly")
                    {
                        loading aa = new loading();
                        aa.Show();
                        this.Close();
                        string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                        MySqlConnection conn = new MySqlConnection(connStr);

                        conn.Open();

                        MySqlDataReader reader = null;
                        string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='2' WHERE payment_cusID=" + paymentSelector.cusID + " and MONTH(paymentDueDate) = " +
paymentSelector.month + " AND YEAR(paymentDueDate) = " + paymentSelector.year + "";


                        MySqlCommand command = new MySqlCommand(selectCmd, conn);
                        reader = command.ExecuteReader();

                    }

                    //Monthly


                }
            }

            if (rdoCheque.Checked == true)
            {

                string msg = "Please check the following data are inputed and correctly:\n\n";

                if (txtFilePath.Text == "")
                {
                    msg = msg + "Cheque, please upload the cheque.\n\n";
                }

                if (msg.Length != 60)
                {
                    MessageBox.Show(msg, "Error");
                }
                else
                {
                    //SQL
                    if (txtPaymentType.Text == "Individual")
                    {
                        loading aa = new loading();
                        aa.Show();
                        this.Close();
                        string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                        MySqlConnection conn = new MySqlConnection(connStr);

                        conn.Open();

                        MySqlDataReader reader = null;
                        string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='1' WHERE paymentID=" + paymentSelector.paymentID;

                        MySqlCommand command = new MySqlCommand(selectCmd, conn);
                        reader = command.ExecuteReader();

                    }
                    else if (txtPaymentType.Text == "Monthly")
                    {

                        loading aa = new loading();
                        aa.Show();
                        this.Close();
                        string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                        MySqlConnection conn = new MySqlConnection(connStr);

                        conn.Open();

                        MySqlDataReader reader = null;
                        string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='1' WHERE payment_cusID=" + paymentSelector.cusID + " and MONTH(paymentDueDate) = " +
paymentSelector.month + " AND YEAR(paymentDueDate) = " + paymentSelector.year + "";


                        MySqlCommand command = new MySqlCommand(selectCmd, conn);
                        reader = command.ExecuteReader();

                    }

                }
               
            }
            if (radioButton1.Checked == true) // E pay

            {
                //start
                if (txtPaymentType.Text == "Individual")
                {
                    ePay aa = new ePay();
                    this.Close();
                    aa.Show();
                    string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                    MySqlConnection conn = new MySqlConnection(connStr);

                    conn.Open();

                    MySqlDataReader reader = null;
                    string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='3' WHERE paymentID=" + paymentSelector.paymentID;

                    MySqlCommand command = new MySqlCommand(selectCmd, conn);
                    reader = command.ExecuteReader();

                }
                else if (txtPaymentType.Text == "Monthly")
                {
                    ePay aa = new ePay();
                    this.Close();
                    aa.Show();
                    string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                    MySqlConnection conn = new MySqlConnection(connStr);

                    conn.Open();

                    MySqlDataReader reader = null;
                    string selectCmd = "UPDATE `payment` SET `paymentStatus`='1',`paymentMethod`='3' WHERE payment_cusID=" + paymentSelector.cusID + " and MONTH(paymentDueDate) = " +
paymentSelector.month + " AND YEAR(paymentDueDate) = " + paymentSelector.year + "";


                    MySqlCommand command = new MySqlCommand(selectCmd, conn);
                    reader = command.ExecuteReader();

                }
                //end
                
            }
        }

        private void txtTotalAmout_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
