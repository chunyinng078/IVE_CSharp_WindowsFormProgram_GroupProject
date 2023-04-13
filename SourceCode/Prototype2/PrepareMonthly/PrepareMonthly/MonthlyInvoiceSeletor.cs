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

namespace PrepareMonthly
{
    public partial class MonthlyInvoiceSeletor : Form
    {
        public static string cusID;
        public static string year;
        public static string month;

        public MonthlyInvoiceSeletor()
        {
            InitializeComponent();
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            conn.Close();

            ///

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "'";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;


            while (reader2.Read())
            {
                paymentDataGridView[4, i].Value = reader2["date"];


                i++;
            }
            conn2.Close();
            paymentDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "'  and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "", conn);
                dt = new DataTable();
                
                da.Fill(dt);
                paymentDataGridView.DataSource = dt;

                conn.Close();

                ///
                string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn2 = new MySqlConnection(connStr2);

                MySqlDataReader reader2 = null;
                string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "'  and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "";

                conn2.Open();
                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                int i = 0;


                while (reader2.Read())
                {
                    paymentDataGridView[4, i].Value = reader2["date"];


                    i++;
                }
                conn2.Close();
                paymentDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet);

        }

        private void MonthlyInvoiceSeletor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet.payment' table. You can move, or remove it, as needed.
            // this.paymentTableAdapter.Fill(this.edeDataSet.payment);


            ///

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "'";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;


            while (reader2.Read())
            {
                paymentDataGridView[4, i].Value = reader2["date"];


                i++;
            }
            conn2.Close();
            paymentDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
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

                ///


                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlDataAdapter da;
                DataTable dt;
                conn.Open();
                da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "'  and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "", conn);
                dt = new DataTable();

                da.Fill(dt);
                paymentDataGridView.DataSource = dt;

                conn.Close();

                ///
                string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn2 = new MySqlConnection(connStr2);

                MySqlDataReader reader2 = null;
                string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "'  and MONTH(date) = " + txtMonth.Text + " AND YEAR(date) = " + txtDate.Text + "";

                conn2.Open();
                MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
                reader2 = command2.ExecuteReader();
                int i = 0;


                while (reader2.Read())
                {
                    paymentDataGridView[4, i].Value = reader2["date"];


                    i++;
                }
                conn2.Close();
                paymentDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

                ///
                if (paymentDataGridView.Rows.Count == 0)
                {

                    MessageBox.Show("There is no record of the month", "Error");
                        
                }
                else
                {
                    year = txtDate.Text;
                    month = txtMonth.Text;

                    MonthlyInvoiceViewer aa = new MonthlyInvoiceViewer();
                    aa.Show();
                }
                

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From payment where payment_cusID = '" + cusID + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;
            conn.Close();

            ///

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "Select date From payment where payment_cusID = '" + cusID + "'";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;


            while (reader2.Read())
            {
                paymentDataGridView[4, i].Value = reader2["date"];


                i++;
            }
            conn2.Close();
            paymentDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
