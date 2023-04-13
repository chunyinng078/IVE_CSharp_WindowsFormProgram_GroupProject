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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace ImportFunction
{
    public partial class ImportMainPage : Form
    {
        public String cusID = "103";
        string Description;
        double UnitValue;
        double weight, value;
        string cusAddress, cusPhone, companyName, cusName, time;
        int airwayBillID;
        public ImportMainPage(String cusID)
        {
            this.cusID = cusID;
            //Application.Run(new SupplierList());
            InitializeComponent();
        }

        private void ImportMainPage_Load(object sender, EventArgs e)
        {

            getCustomerData();
            getCustomerProduct();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbQunaty.Text = "";
            tbrname.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = " ";
            tbCompanyName.Text = "";
            comboBox1.Text = "";
            tbEmail.Text = "";
        }

        private void GBsenderinfo_Enter(object sender, EventArgs e)
        {

        }
        private void getCustomerData()
        {


            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            String Sql = "SELECT * FROM `customer` WHERE cusID ='" + cusID + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, conn);
            MySqlDataReader DR = cmd.ExecuteReader();
            try
            {
                while (DR.Read())
                {
                    cusName = "User ID:  " + DR.GetString("cusID");
                    lblID.Text = cusID;

                    cusName = "User Name:  " + DR.GetString("cusName");
                    lblName.Text = cusName;

                    cusAddress = "User Address:  " + DR.GetString("cusAddress");
                    lblAddress.Text = cusAddress;

                    cusPhone = "User Phone Number:  " + DR.GetString("cusPhone");
                    lblPhone.Text = cusPhone;

                    companyName = "User Company Name:  " + DR.GetString("cusCompany");
                    lblUserName.Text = companyName;
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }

        private void getCustomerProduct()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            String Sql = "SELECT `ProductID` FROM `regularproduct` WHERE cusID ='" + cusID + "';";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(Sql, conn);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                //MessageBox.Show(DR[0].ToString());
                comboBox1.Items.Add(DR[0].ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
            print();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            add();





        }

        private void add()
        {
            if (String.IsNullOrEmpty(tbAddress.Text))
            {
                MessageBox.Show("You need to enter the The Address");
            }

            else if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("You need to enter the The Email Address");
            }
            else if (!IsValid(tbEmail.Text))
            {
                MessageBox.Show("The Email format is not correct. The Correct Emial format should be xxx@xxx.xx ");

            }
            else if (String.IsNullOrWhiteSpace(tbPhone.Text))
            {
                MessageBox.Show("You need to enter the The Phone Number");
            }
            else if (String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("You need to Select the ProductID");
            }
            else if (!isPhoneNumber(tbPhone.Text))
            {
                MessageBox.Show("The Phone number should be 8 digits ");
            }
            else if (String.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("The Address must not be null");
            }
            else if (String.IsNullOrWhiteSpace(tbQunaty.Text))
            {
                MessageBox.Show("You need to enter the The Quanty");
            }
            else
            { //get selected product data

                string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
                MySqlConnection conn = new MySqlConnection(connStr);
                String Sql = "SELECT * FROM `regularproduct` WHERE ProductID ='" + comboBox1.Text + "';";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Sql, conn);
                MySqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    //MessageBox.Show(DR[0].ToString());
                    Description = DR.GetString("Description");
                    UnitValue = DR.GetDouble("UnitValue");
                    weight = DR.GetDouble("Weight");

                }
                conn.Close();








                //Sql


                conn.Open();

                MySqlDataReader reader = null;
                string selectCmd = "SELECT MAX(airwayBillID) FROM airwaybill";

                MySqlCommand command = new MySqlCommand(selectCmd, conn);
                reader = command.ExecuteReader();

                airwayBillID = 0;
                while (reader.Read())
                {
                    airwayBillID = (int)reader["MAX(airwayBillID)"];
                    airwayBillID = airwayBillID + 1;
                }
                conn.Close();
                int paymentID = getPaymentID();
                addToDB(airwayBillID, paymentID);

                DateTime expires = DateTime.Now.AddDays(30);
                String dueDate = expires.ToString("yyyy-MM-dd HH:mm:ss");
                dueDate = dueDate.Replace("/", "-");
                dueDate = dueDate.Replace("PM", "");



                string connStr4 = "server=127.0.0.1;uid=root;pwd=;database=ede";
                MySqlConnection conn4 = new MySqlConnection(connStr4);

                conn4.Open();

                MySqlDataReader reader4 = null;
                string selectCmd4 = "INSERT INTO `payment` (`paymentID`, `paymentAmount`, `paymentDueDate`," +
                    " `paymentStatus`, `payment_cusID`, `airwaybill_airwayBillId`)" +
                    " VALUES ('" + paymentID + "', '" + UnitValue * Convert.ToDouble(tbQunaty.Text) + "', '" + dueDate + "', '0', '" + cusID + "', '" + airwayBillID + "')";

                try
                {
                    MySqlCommand command4 = new MySqlCommand(selectCmd4, conn4);
                    reader4 = command4.ExecuteReader();
                    conn4.Close();

                    //this.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException a)
                {


                }
            }
        }
        private int getPaymentID()
        {
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

            return paymentID;
        }
        public static bool isPhoneNumber(String number)
        {
            Regex phone = new Regex(@"^\d{8}");

            return phone.IsMatch(number);
        }
        public static bool IsValid(string emailaddress)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            return regex.IsMatch(emailaddress);
        }
        private void addToDB(int airwayBillID, int paymentID)
        {
            string destination = "1";


            String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            time = now.ToString();
            time = time.Replace("/", "-");
            time = time.Replace("PM", "");

            value = UnitValue * Convert.ToDouble(tbQunaty.Text);

            String connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr);
            conn2.Open();
            MySqlDataReader reader2 = null;
            string selectCmd2 = "INSERT INTO `airwaybill`(`airwayBillID`, `services`, `destinationCountry`, `deliveryAddress`, `postCode`, `receiverCompany`, `receiverName`, `receiverPhone`, `receiverEmail`, `declaredValue`, `contentDescription`, `weight`, `length`, `width`, `height`, `date`, `status`, `statusComment`, `cusID`) VALUES('" + airwayBillID + "', '1', '" + destination + "', '" + tbAddress.Text + "', 'HKG', '" + tbCompanyName.Text + "', '" + tbrname.Text + "', '" + tbPhone.Text + "', '" + tbEmail.Text + "', '" + value + "', '" + Description + "', '" + weight + "', 'NULL', 'NULL', 'NULL', '" + time + "', 'In Process', 'NULL', '" + cusID + "');";

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
                MessageBox.Show(a.Message.ToString());

            }

        }
        private void print()
        {
            try
            {
                #region Common Part
                PdfPTable pdfblank = new PdfPTable(1);

                //footer
                PdfPTable pdfFooter = new PdfPTable(1);
                pdfFooter.DefaultCell.BorderWidth = 0;
                pdfFooter.WidthPercentage = 100;
                pdfFooter.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                Chunk cnkFooter = new Chunk("EDE Limted", FontFactory.GetFont("Times New Roman"));
                cnkFooter.Font.Size = 10;
                pdfFooter.AddCell(new Phrase(cnkFooter));

                pdfblank.AddCell(new Phrase(" "));
                pdfblank.DefaultCell.Border = 0;


                #endregion

                #region Page
                #region Section-1 <Header FORM>
                PdfPTable pdfPTable1 = new PdfPTable(1);
                // PdfPTable pdfPTable2 = new PdfPTable(1);
                PdfPTable pdfPTable3 = new PdfPTable(1);
                // PdfPTable pdfPTable4 = new PdfPTable(1);
                PdfPTable pdfPTable5 = new PdfPTable(1);
                PdfPTable pdfPTable6 = new PdfPTable(1);

                //Font Style
                System.Drawing.Font fontH1 = new System.Drawing.Font("Currier", 16);

                pdfPTable1.WidthPercentage = 80;
                pdfPTable1.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfPTable1.DefaultCell.VerticalAlignment = Element.ALIGN_CENTER;

                //pdfPTable2.DefaultCell.BorderWidth = 0;

                pdfPTable3.DefaultCell.Padding = 5;
                pdfPTable3.WidthPercentage = 80;
                pdfPTable3.DefaultCell.BorderWidth = 0.5f;

                Chunk c1 = new Chunk("Proforma Invoice/commercial Invoice", FontFactory.GetFont("Times new Romean"));
                c1.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                c1.Font.SetStyle(0);
                c1.Font.Size = 14;
                Phrase p1 = new Phrase();
                p1.Add(c1);
                pdfPTable1.AddCell(p1);
                //Chunk c2 = new Chunk("28/3, xx ", FontFactory.GetFont("Times New Roman"));
                //c2.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                //c2.Font.SetStyle(0);
                //c2.Font.Size = 11;
                //Phrase p2 = new Phrase();
                //p2.Add(c2);
                //pdfPTable2.AddCell(p2);
                //Chunk c3 = new Chunk("28/3, xx ", FontFactory.GetFont("Times New Roman"));
                //c3.Font.Color = new iTextSharp.text.BaseColor(0, 0, 0);
                //c3.Font.SetStyle(0);
                //c3.Font.Size = 11;
                //Phrase p3 = new Phrase();
                //p3.Add(c3);
                //pdfPTable2.AddCell(p3);

                #endregion
                /* #region Section-1 <Bill Upper>
                 PdfPTable pdfTable4 = new PdfPTable(2);
                 pdfTable4.DefaultCell.Padding = 5;
                 pdfTable4.WidthPercentage = 80;
                 pdfTable4.DefaultCell.BorderWidth = 0.5f;


                 pdfTable4.AddCell(new Phrase("Bill No"));
                 pdfTable4.AddCell(new Phrase(airwayBillID));
                 pdfTable4.AddCell(new Phrase("Date"));
                 pdfTable4.AddCell(new Phrase(time));


                 #endregion*/

                #region Section Table
                pdfPTable5.AddCell(new Phrase("Ship TO"));
                pdfPTable5.AddCell(new Phrase("Compnay Name: " + tbCompanyName.Text));
                pdfPTable5.AddCell(new Phrase("Address: " + tbAddress.Text));
                pdfPTable5.AddCell(new Phrase("Conatct Name: " + tbrname.Text));
                pdfPTable5.AddCell(new Phrase("Phone No: " + tbPhone.Text));
                pdfPTable5.AddCell(new Phrase("Town Area Code: HKG"));
                pdfPTable5.AddCell(new Phrase("No of Pieces: " + tbQunaty.Text + "pieces"));
                #endregion
                #region Section Table
                pdfPTable3.AddCell(new Phrase("Shipper"));
                pdfPTable3.AddCell(new Phrase("Compnay Name: " + companyName));
                pdfPTable3.AddCell(new Phrase("Address: " + cusAddress));
                pdfPTable3.AddCell(new Phrase("Conatct Name: " + cusName));
                pdfPTable3.AddCell(new Phrase("Phone No: " + cusPhone));


                #endregion
                pdfPTable6.AddCell(new Phrase("Full Description of goods:    " + Description));
                pdfPTable6.AddCell(new Phrase("Harmonized Code:    " + comboBox1.Text));
                pdfPTable6.AddCell(new Phrase("No of Items :   " + tbQunaty.Text));
                pdfPTable6.AddCell(new Phrase("Unit Value:   " + UnitValue));
                pdfPTable6.AddCell(new Phrase("Total Value:     " + value));

                #endregion

                #region Pdf Generation
                string folderPath = "D:\\";
                if (Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                int fileCount = 1;
                fileCount = Directory.GetFiles(@"D:\").Length;

                string FileName = "Invoice" + (fileCount + 1) + ".pdf";

                using (FileStream stream = new FileStream(folderPath + FileName, FileMode.CreateNew))
                {

                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        #region PAGE-1
                        pdfDoc.Add(pdfPTable1);
                        pdfDoc.Add(pdfblank);
                        pdfDoc.Add(pdfblank);
                        //pdfDoc.Add(pdfPTable2);
                        //pdfDoc.Add(pdfblank);
                        //pdfDoc.Add(pdfTable4);
                        //pdfDoc.Add(pdfblank);
                        pdfDoc.Add(pdfPTable5);
                        pdfDoc.Add(pdfblank);
                        pdfDoc.Add(pdfPTable6);
                        pdfDoc.Add(pdfFooter);

                        pdfDoc.Add(pdfblank);
                        pdfDoc.NewPage();
                        #endregion
                        MessageBox.Show("Invoice printed in" + folderPath);
                        pdfDoc.Close();
                        stream.Close();

                    }
                    #endregion

                    //#region Display PDF
                    // System.Diagnostics.Process.Start(folderPath + "\\" + FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


    }

    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
    }
}



