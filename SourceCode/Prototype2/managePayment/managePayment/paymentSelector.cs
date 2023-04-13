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
    public partial class paymentSelector : Form
    {
        public static string cusID;
        public static string paymentType;
        public static string paymentID;
        public static double price;
        public static double year;
        public static double month;
        public paymentSelector()
        {
            InitializeComponent();
        }

        private void paymentSelector_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.edeDataSet.payment);

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "' and paymentStatus=0", conn);
            dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            conn.Close();

            ///
            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "' and paymentStatus=0";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;


            while (reader2.Read())
            {
                paymentDataGridView[2, i].Value = reader2["date"];


                i++;
            }
            conn2.Close();
            paymentDataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";


        }

        private void btnIndividualy_Click(object sender, EventArgs e)
        {


            if (paymentDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record below", "Error");
            }
            else
            {
                paymentType = "Individual";
                payForm i1 = new payForm();
                i1.Show();
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            /*
            string msg = "Please check the followings are filled and correctly:\n\n";
            
            if (txtMonth.Text == "")
            {
                msg = msg + "Month \n\n";
            }
            else if (txtMonth.Text == "00")
            {
                msg = msg + "Month, month cannot be all zero.\n\n";
            }
            else if (txtMonth.Text.Length != 2)
            {
                msg = msg + "Month, please enter month with 2 number.\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtMonth.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Month, please enter month with 2 number.\n\n";
                }
            }

            if (txtYear.Text == "")
            {
                msg = msg + "Year \n\n";
            }
            else if (txtYear.Text == "0000")
            {
                msg = msg + "Year, year cannot be all zero.\n\n";
            }
            else if (txtYear.Text.Length != 4)
            {
                msg = msg + "Year, please enter year with 4 number.\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    int tmp = int.Parse(txtYear.Text);
                }
                catch (System.FormatException)
                {
                    msg = msg + "Year, please enter year with 4 number.\n\n";
                }
            }

            //if () Do sql to search are any record
            //{
            //    
            //}

            if (msg.Length != 59)
            {
                MessageBox.Show(msg,"Error");
            }
            else
            {
                paymentType = "Monthly";
                payForm i1 = new payForm();
                i1.Show();
            }
            */
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //sql things
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From payment where airwaybill_airwayBillId like'%" + textBox1.Text + "%' and payment_cusID	 = '" + cusID + "' and paymentStatus=0", conn);
            dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            conn.Close();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet);

        }

        public static double num_price;
        private void paymentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tmp = paymentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            paymentID = paymentDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            price = double.Parse(tmp);

            paymentType = "Individual";
            payForm i1 = new payForm();
            i1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "' and paymentStatus=0", conn);
            dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            conn.Close();
            textBox1.Text = "";

            ///
            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "' and paymentStatus=0";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;


            while (reader2.Read())
            {
                paymentDataGridView[2, i].Value = reader2["date"];


                i++;
            }
            conn2.Close();
            paymentDataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (txtDate.Text == "" || txtMonth.Text == "")
            {
                msg = msg + "Please make sure you have filled both Year and Month column\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    double tmp = double.Parse(txtMonth.Text);
                    if (tmp <= 0 || tmp > 12)
                    {
                        msg = msg + "Month, please enter a valid number of month.\n\n";
                    }

                    double tmp2 = double.Parse(txtDate.Text);
                    if (tmp2 == 0)
                    {
                        msg = msg + "Year, please enter a valid number of year (cannot be zero).\n\n";
                    }
                    else if (txtDate.Text.Length != 4)
                    {
                        msg = msg + "Year, please enter a valid number of year (must be 4 number).\n\n";
                    }


                }
                catch (System.FormatException)
                {
                    msg = msg + "Weight, please enter weight with number.\n\n";
                    MessageBox.Show(msg, "Error");
                }

            }


            if (msg != "")
            {
                MessageBox.Show(msg, "Error");
            }
            else
            {



                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlDataAdapter da;
                DataTable dt;
                conn.Open();
                da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "' and paymentStatus=0 and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "", conn);
                dt = new DataTable();
                da.Fill(dt);
                paymentDataGridView.DataSource = dt;
                conn.Close();

                ///
                string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn2 = new MySqlConnection(connStr2);

                MySqlDataReader reader2 = null;
                string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "' and paymentStatus=0 and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "";

                conn2.Open();
                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                int i = 0;


                while (reader2.Read())
                {
                    paymentDataGridView[2, i].Value = reader2["date"];


                    i++;
                }
                conn2.Close();
                paymentDataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (txtDate.Text == "" || txtMonth.Text == "")
            {
                msg = msg + "Please make sure you have filled both Year and Month column\n\n";
            }
            else
            {
                try                 // check if account no. inputed as number
                {
                    double tmp = double.Parse(txtMonth.Text);
                    if (tmp <= 0 || tmp > 12)
                    {
                        msg = msg + "Month, please enter a valid number of month.\n\n";
                    }

                    double tmp2 = double.Parse(txtDate.Text);
                    if (tmp2 == 0)
                    {
                        msg = msg + "Year, please enter a valid number of year (cannot be zero).\n\n";
                    }
                    else if (txtDate.Text.Length != 4)
                    {
                        msg = msg + "Year, please enter a valid number of year (must be 4 number).\n\n";
                    }


                }
                catch (System.FormatException)
                {
                    msg = msg + "Weight, please enter weight with number.\n\n";
                    MessageBox.Show(msg, "Error");
                }

            }

            if (paymentDataGridView.Rows.Count == 0)
            {
                msg = msg + "There is no record in the table below. Please make sure you have filter the table or make sure you have payment in that month.\n\n";
            }

            if (msg != "")
            {
                MessageBox.Show(msg, "Error");
            }
            else
            {

                month = double.Parse(txtMonth.Text);
                year = double.Parse(txtDate.Text);

                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn = new MySqlConnection(connStr);

                conn.Open();

                MySqlDataReader reader = null;
                string selectCmd = "Select SUM(paymentAmount) From payment where payment_cusID = '" + cusID + "' and paymentStatus=0 and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "";


                MySqlCommand command = new MySqlCommand(selectCmd, conn);
                reader = command.ExecuteReader();

                paymentID = "";
                try
                {
                    while (reader.Read())
                    {
                        string tmp = reader["SUM(paymentAmount)"].ToString();
                        price = double.Parse(tmp);

                    }
                    conn.Close();


                    MySqlConnection conn2 = new MySqlConnection(connStr);

                    conn2.Open();

                    MySqlDataReader reader2 = null;
                    string selectCmd2 = "Select * From payment where payment_cusID = '" + cusID + "' and paymentStatus=0 and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "";


                    MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                    reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        paymentID += reader2["paymentID"] + ", ";

                    }
                    conn2.Close();





                    paymentType = "Monthly";
                    payForm i1 = new payForm();
                    this.Close();
                    i1.Show();
                }
                catch (System.FormatException a)
                {
                    MessageBox.Show("No such record in that month");

                }

            }
        }
    }
}
