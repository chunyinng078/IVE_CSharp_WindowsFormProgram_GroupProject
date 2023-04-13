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
using viewAirwayBills;
using editShipment;
using managePayment;
using Invoice;
using ProcessShipment;
using WindowsFormsApp1;
using CreateShipment;
using ShippingExpensesCalculate;
using PrepareMonthly;

namespace Login_1
{
    public partial class Portal : Form
    {   
        public Boolean isStaff;
        public String UserName;
        public static string  userid = "497";
        public String staffType;
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

        

        public Portal(String userName, bool isStaff)
        {
            this.UserName = userName;
            this.isStaff = isStaff;
            
            InitializeComponent();
            if (isStaff)
            {
                lblWelcome.Text = "Staff Portal Welcomes:";
                userid = getStaffData();
            }
            else
            {
                lblWelcome.Text = "Customer Portal Welcomes:";
                userid = getCusData();
            }

            lblUserID.Text = "UserID: " + userid;
            //MessageBox.Show(getCusData()) ;


        }

        public string getCusData()
        {
             string query = "SELECT `cusName` , `CusID` FROM `customer` WHERE `cusUserName`='" + UserName + "'"; 
           
            
            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            string name;
            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();
                while (reader.Read())
                {
                    name = (string)reader["cusName"];
                    lblUserName.Text = name;
                    lblUserName2.Text = name;                    

                    userid = Convert.ToString((int)reader["CusID"]);


                    lblUserID.Text = "UserID: " + userid;


                   

                    
                }
                
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return userid;
        }

        public String getStaffData()
        {
            string query = "SELECT `staffName`,`staffNo`, `officeCode` FROM `staff` WHERE `staffUserName`='" + UserName + "'";


            MySqlConnection databaseConnection = new MySqlConnection(conString);
            MySqlCommand commandDB = new MySqlCommand(query, databaseConnection);
            commandDB.CommandTimeout = 60;
            MySqlDataReader reader;
            string name;
            try
            {
                databaseConnection.Open();
                reader = commandDB.ExecuteReader();
                while (reader.Read())
                {
                    name = (string)reader["staffName"];
                    lblUserName.Text = name;
                    lblUserName2.Text = name;
                    staffType = (string)reader["officeCode"];

                    userid = Convert.ToString((int)reader["staffNo"]);
                    //MessageBox.Show("2" + userid);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return userid;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUserID_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPickUp_Click(object sender, EventArgs e)
        {
            NewPickUpOrder newPickUpOrder = new NewPickUpOrder(userid,isStaff);
            newPickUpOrder.ShowDialog();
        }

        private void btn_viewAirwayBill_Click(object sender, EventArgs e)
        {
            viewAirwayBills.airwaybillSelector.cusID = userid;
            viewAirwayBills.airwaybillSelector airwaybill = new viewAirwayBills.airwaybillSelector();
            airwaybill.Show();
        }

        private void btn_editShipment_Click(object sender, EventArgs e)
        {
            editShipment.EditShipment shipment = new EditShipment();
            shipment.Show();
        }

        private void btn_mangagePayment_Click(object sender, EventArgs e)
        {
            managePayment.paymentSelector.cusID = userid;
            managePayment.paymentSelector payment = new paymentSelector();
            payment.Show();
        }

        private void btn_Inovice_Click(object sender, EventArgs e)
        {
            Invoice.selectInvoice.cusID = userid;
            Invoice.selectInvoice invoice = new selectInvoice();
            invoice.Show();
        }

        private void btn_processShipment_Click(object sender, EventArgs e)
        {
            if (isStaff)
            {
                ProcessShipment.ProcessShipmentStaff process = new ProcessShipmentStaff();
                process.Show();
            }
            else
            {
                ProcessShipment.ProcessShipmentStaff process = new ProcessShipmentStaff(!isStaff);
                process.Show();
            }

        }

        private void btn_editPickUp_Click(object sender, EventArgs e)
        {
            WindowsFormsApp1.EditPickUp.cusID = userid;
            WindowsFormsApp1.EditPickUp.isStaff = isStaff;
            WindowsFormsApp1.EditPickUp editPickUp = new EditPickUp();
            editPickUp.Show();
        }

        private void Portal_Load(object sender, EventArgs e)
        {
            if (isStaff)
            {
                btnNewPickUp.Hide();
                btn_viewAirwayBill.Hide();
                panel1.BackColor = Color.LightSalmon;
                BackColor = Color.GhostWhite;

                ///
                btnCalculateExpense.Hide();
                btn_Inovice.Hide();
                btn_viewAirwayBill.Hide();
                button1.Hide(); // prepare monthly
                btn_mangagePayment.Hide();

            }
            else
            {
                btn_editShipment.Hide();
                btnSearch.Hide();
                btnStat.Hide();
            }

        }

        private void btnCreateShipment_Click(object sender, EventArgs e)
        {

            CreateShipment.CreateShipments.custID = userid;
            CreateShipment.CreateShipments.staff = isStaff;
            CreateShipments c1 = new CreateShipments();
            c1.Show();
            
        }

        private void btnCalculateExpense_Click(object sender, EventArgs e)
        {
            CalculateExpenses c1 = new CalculateExpenses();
            c1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrepareMonthly.MonthlyInvoiceSeletor.cusID = userid;
            MonthlyInvoiceSeletor ms1 = new MonthlyInvoiceSeletor();
            ms1.Show();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportFunction.FunctionSelecter if1 = new ImportFunction.FunctionSelecter(userid);
            if1.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (staffType.Equals("1"))
            {
                QuickSearch.QuickSearch qs = new QuickSearch.QuickSearch();
                qs.Show();
            } else
            {
                QuickSearchAirwayBill.QuickSearchAirwayBill qs = new QuickSearchAirwayBill.QuickSearchAirwayBill();
                qs.Show();
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            Statistics.Statistics s = new Statistics.Statistics();
            s.Show();
        }
    }
}
