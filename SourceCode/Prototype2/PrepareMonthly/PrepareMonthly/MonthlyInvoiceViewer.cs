using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareMonthly
{
    public partial class MonthlyInvoiceViewer : Form
    {

        string cusID = MonthlyInvoiceSeletor.cusID;
        public MonthlyInvoiceViewer()
        {
            InitializeComponent();
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("select airwaybill.airwayBillID, airwaybill.contentDescription,airwaybill.declaredValue, airwaybill.destinationCountry, airwaybill.date,payment.paymentAmount from airwaybill join payment where airwaybill.cusID=payment.payment_cusID and airwaybill.airwayBillID=payment.airwaybill_airwayBillId and airwaybill.cusID=" + cusID, conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "select SUM(payment.paymentAmount),airwaybill.airwayBillID, airwaybill.contentDescription,airwaybill.declaredValue, airwaybill.destinationCountry, airwaybill.date,payment.paymentAmount from airwaybill join payment where airwaybill.cusID=payment.payment_cusID and airwaybill.airwayBillID=payment.airwaybill_airwayBillId and airwaybill.cusID=" + cusID;

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;
            while (reader2.Read())
            {
                var amount = reader2["SUM(payment.paymentAmount)"];
                txtAmount.Text=amount.ToString();

            }
            conn2.Close();
            ///
            string connStr3 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn3 = new MySqlConnection(connStr3);

            MySqlDataReader reader3 = null;
            string selectCmd3 = "select cusName from customer where cusID="+cusID;

            conn3.Open();
            MySqlCommand command3 = new MySqlCommand(selectCmd3, conn3);
            reader3 = command3.ExecuteReader();

            while (reader3.Read())
            {
                txtCusName.Text = reader3["cusName"].ToString();

            }
            conn3.Close();

            ///
            txtYear.Text = MonthlyInvoiceSeletor.year;
            txtMonth.Text = MonthlyInvoiceSeletor.month;
            txtCusID.Text = MonthlyInvoiceSeletor.cusID;
            textBox1.Text= MonthlyInvoiceSeletor.year+"-"+ MonthlyInvoiceSeletor.month;
            txtShipmentNum.Text = airwaybillDataGridView.RowCount.ToString();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet);

        }

        private void MonthlyInvoiceViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet1.airwaybill' table. You can move, or remove it, as needed.
            this.airwaybillTableAdapter.Fill(this.edeDataSet1.airwaybill);
            // TODO: This line of code loads data into the 'edeDataSet.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.edeDataSet.payment);


           

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("select airwaybill.airwayBillID, airwaybill.contentDescription,airwaybill.declaredValue, airwaybill.destinationCountry, airwaybill.date,payment.paymentAmount from airwaybill join payment where MONTH(airwaybill.date) = " + MonthlyInvoiceSeletor.month + " AND YEAR(airwaybill.date) = " + MonthlyInvoiceSeletor.year + " and airwaybill.airwayBillID=payment.airwaybill_airwayBillId and airwaybill.cusID=payment.payment_cusID and airwaybill.cusID=" + cusID, conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);

            MySqlDataReader reader2 = null;
            string selectCmd2 = "select airwaybill.airwayBillID, airwaybill.contentDescription,airwaybill.declaredValue, airwaybill.destinationCountry, airwaybill.date,payment.paymentAmount from airwaybill join payment where MONTH(airwaybill.date) = " + MonthlyInvoiceSeletor.month + " AND YEAR(airwaybill.date) = " + MonthlyInvoiceSeletor.year + " and airwaybill.cusID=payment.payment_cusID and airwaybill.airwayBillID=payment.airwaybill_airwayBillId and airwaybill.cusID=" + cusID;

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();
            int i = 0;
            

            while (reader2.Read())
            {
                airwaybillDataGridView[5,i].Value = reader2["paymentAmount"];
                

                i++;
            }
            conn2.Close();
            airwaybillDataGridView.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";        


            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a file name of the monthly invoice inorder to save", "ERROR");
            }
            else
            {
                int width = panel1.Size.Width;
                int height = panel1.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                panel1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, width, height));


                DateTime now = DateTime.Now;
                string time = now.ToString();
                time = time.Replace(" ", "_");
                time = time.Replace("/", "-");
                time = time.Replace(":", "-");
                bm.Save(@"C:\Users\Public\Pictures\monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".Bmp");
                MessageBox.Show("The bmp saved in C:\\Users\\Public\\Pictures\\ as monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".Bmp", "Sucess");

            }


            
        }

        private void airwaybillDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a file name of the airwaybill inorder to save", "ERROR");
            }
            else
            {
                using (var Bmp = new Bitmap(panel1.Width, panel1.Height))
                {
                    panel1.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0,0, Bmp.Width, Bmp.Height));
                    DateTime now = DateTime.Now;
                    string time = now.ToString();
                    time = time.Replace(" ", "_");
                    time = time.Replace("/", "-");
                    time = time.Replace(":", "-");
                    System.Drawing.Image image = Bmp;
                    Document doc = new Document(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    doc.Add(pdfImage);
                    doc.Close();
                    MessageBox.Show("The pdf file saved in C:\\Users\\Public\\Pictures\\ as monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".pdf", "Sucess");


                }


            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var Bmp = new Bitmap(panel1.Width, panel1.Height))
            {
                panel1.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                DateTime now = DateTime.Now;
                string time = now.ToString();
                time = time.Replace(" ", "_");
                time = time.Replace("/", "-");
                time = time.Replace(":", "-");
                System.Drawing.Image image = Bmp;
                Document doc = new Document(PageSize.A4.Rotate());
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(pdfImage);
                doc.Close();


                string filename = "C:\\Users\\Public\\Pictures\\monthlyInvoice_" + textBox1.Text + "_savedAt--" + time + ".pdf";
                Process p = new Process();
                p.StartInfo.FileName = "AcroRd32.exe";
                p.StartInfo.Arguments = @" /p """ + filename + @"""";

                p.Start();
            }
        }
    }
}
