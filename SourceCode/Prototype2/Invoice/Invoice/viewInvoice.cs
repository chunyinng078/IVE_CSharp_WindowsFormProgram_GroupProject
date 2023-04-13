using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class viewInvoice : Form
    {
        public viewInvoice()
        {
            InitializeComponent();
            txtFileName.Text = selectInvoice.airwaybillno;
        }

        private void btnBmp_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a file name of the airwaybill inorder to save", "ERROR");
            }
            else
            {
                using (var Bmp = new Bitmap(pnlInvoice.Width, pnlInvoice.Height))
                {
                    pnlInvoice.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                    DateTime now = DateTime.Now;
                    string time = now.ToString();
                    time = time.Replace(" ", "_");
                    time = time.Replace("/", "-");
                    time = time.Replace(":", "-");
                    Bmp.Save(@"C:\Users\Public\Pictures\invoice_" + txtFileName.Text + "_savedAt--" + time + ".Bmp");
                    MessageBox.Show("The bmp saved in C:\\Users\\Public\\Pictures\\ as invoice_" + txtFileName.Text + "_savedAt--" + time + ".Bmp", "Sucess");

                }

            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a file name of the airwaybill inorder to save", "ERROR");
            }
            else
            {
                using (var Bmp = new Bitmap(pnlInvoice.Width, pnlInvoice.Height))
                {
                    pnlInvoice.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                    DateTime now = DateTime.Now;
                    string time = now.ToString();
                    time = time.Replace(" ", "_");
                    time = time.Replace("/", "-");
                    time = time.Replace(":", "-");
                    System.Drawing.Image image = Bmp;
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\invoice_" + txtFileName.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    doc.Add(pdfImage);
                    doc.Close();
                    MessageBox.Show("The pdf file saved in C:\\Users\\Public\\Pictures\\ as invoice_" + txtFileName.Text + "_savedAt--" + time + ".pdf","Sucess");


                }


            }
        }

        private void viewInvoice_Load(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "select * from airwaybill where airwayBillID=" + selectInvoice.airwaybillno;

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string receiverCompany = reader["receiverCompany"].ToString();
                txtCompanyName.Text = receiverCompany;

                string deliveryAddress = reader["deliveryAddress"].ToString();
                txtShipToAddress.Text = deliveryAddress;

                string postCode = reader["postCode"].ToString();
                txtTownAreaCode.Text = postCode;

                string Pieces = reader["Pieces"].ToString();
                txtPieces.Text = Pieces;
                

                string weight = reader["weight"].ToString();
                txtTotalWeight.Text = weight;

                int destination = (int)reader["destinationCountry"];
                if (destination == 0)
                {
                    txtStateCountry.Text = "Australia";
                }
                else if (destination == 1)
                {
                    txtStateCountry.Text = "Hong Kong";
                }
                else if (destination == 2)
                {
                    txtStateCountry.Text = "Japan";
                }
                else if (destination == 3)
                {
                    txtStateCountry.Text = "Shanghai";
                    
                }

                string receiverName = reader["receiverName"].ToString();
                txtShipToContactName.Text = receiverName;

                string receiverPhone = reader["receiverPhone"].ToString();
                txtShipToContact.Text = receiverPhone;

                string contentDescription = reader["contentDescription"].ToString();
                txtDescription.Text = contentDescription;

                string declaredValue = reader["declaredValue"].ToString();
                txtTotalValue.Text = declaredValue;
                txtTotalInvoiceValue.Text = declaredValue;

                txtOrigin.Text = "HONG KONG";


            }
            conn.Close();

            string connStr2 = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn2 = new MySqlConnection(connStr2);
            
            MySqlDataReader reader2 = null;
            string selectCmd2 = "select * from customer where cusID = '" + selectInvoice.cusID+"'";

            conn2.Open();
            MySqlCommand command2 = new MySqlCommand(selectCmd2, conn2);
            reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                txtlblAirwayBillNo.Text = selectInvoice.airwaybillno;

                string cusAddress = reader2["cusAddress"].ToString();
                txtAddress.Text = cusAddress;

                string cusName = reader2["cusName"].ToString();
                txtContactName.Text = cusName;
                txtCertifyName.Text = cusName;

                string cusPhone = reader2["cusPhone"].ToString();
                txtShipperContact.Text = cusPhone;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var Bmp = new Bitmap(pnlInvoice.Width, pnlInvoice.Height))
            {
                pnlInvoice.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                DateTime now = DateTime.Now;
                string time = now.ToString();
                time = time.Replace(" ", "_");
                time = time.Replace("/", "-");
                time = time.Replace(":", "-");
                System.Drawing.Image image = Bmp;
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\invoice_" + txtFileName.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(pdfImage);
                doc.Close();


                string filename = "C:\\Users\\Public\\Pictures\\invoice_" + txtFileName.Text + "_savedAt--" + time + ".pdf";
                Process p = new Process();
                p.StartInfo.FileName = "AcroRd32.exe";
                p.StartInfo.Arguments = @" /p """ + filename + @"""";

                p.Start();
            }
        }
    }
}
