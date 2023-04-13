using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace viewAirwayBills
{
    public partial class AirwayBillViewer : Form
    {
        public AirwayBillViewer()
        {
            InitializeComponent();
        }

        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a file name of the airwaybill inorder to save", "ERROR");
            }
            else
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
                    PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                    doc.Open();
                    iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    doc.Add(pdfImage);
                    doc.Close();
                    MessageBox.Show("The pdf file saved in C:\\Users\\Public\\Pictures\\ as airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".pdf", "Sucess");


                }


            }
        }

        private void AirwayBillViewer_Load(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            MySqlDataReader reader = null;
            string selectCmd = "select * from airwaybill where airwayBillID=" + airwaybillSelector.airwaybillno;

            MySqlCommand command = new MySqlCommand(selectCmd, conn);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ariwayBillID = (int)reader["airwayBillID"];
                txtairwayBillID.Text = ariwayBillID.ToString();
                txtFileName.Text = txtairwayBillID.Text;

                int services = (int)reader["services"];
                if (services == 0)
                {
                    txtservices.Text = "Document";
                }
                else
                {
                    txtservices.Text = "Freight";
                }

                int destination = (int)reader["destinationCountry"];
                if (destination == 0)
                {
                    txtdestination.Text = "Australia";
                }
                else if (destination == 1)
                {
                    txtdestination.Text = "Hong Kong";
                }
                else if (destination == 2)
                {
                    txtdestination.Text = "Japan";
                }
                else if (destination == 3)
                {
                    txtdestination.Text = "Shanghai";
                }


                string deliveryAddress = reader["deliveryAddress"].ToString();
                txtdeliveryAddress.Text = deliveryAddress;

                string postCode = reader["postCode"].ToString();
                txtpostCode.Text = postCode;

                string receiverCompany = reader["receiverCompany"].ToString();
                txtreceiverCompany.Text = receiverCompany;

                string receiverName = reader["receiverName"].ToString();
                txtreceiverName.Text = receiverName;

                string receiverContact = reader["receiverPhone"].ToString();
                txtreceiverContact.Text = receiverContact;

                string receiverEmail = reader["receiverEmail"].ToString();
                txtreceiverEmail.Text = receiverEmail;

                float declaredValue = (float)reader["declaredValue"];
                txtdeclaredValue.Text = declaredValue.ToString();

                string contentDescription = reader["contentDescription"].ToString();
                txtcontentDescription.Text = contentDescription;

                float weight = (float)reader["weight"];
                txtweight.Text = weight.ToString();

                float length = (float)reader["length"];
                txtlength.Text = length.ToString();

                float width = (float)reader["width"];
                txtwidth.Text = width.ToString();

                float height = (float)reader["height"];
                txtheight.Text = height.ToString();

                DateTime date = (DateTime)reader["date"];
                txtdate.Text = date.ToString();

                int CustomerID = (int)reader["cusID"];
                txtCustomerID.Text = CustomerID.ToString();

                if (services == 0)
                {
                    txtdeclaredValue.Text= "Not applicable ";
                    txtweight.Text = "Not applicable ";
                    txtlength.Text = "Not applicable ";
                    txtwidth.Text = "Not applicable ";
                    txtheight.Text = "Not applicable ";
                }

            }
            conn.Close();
        }

        private void btnSaveBmp_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please enter a file name of the airwaybill inorder to save", "ERROR");
            }
            else
            {
                using (var Bmp = new Bitmap(panel1.Width, panel1.Height))
                {
                    panel1.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                    DateTime now = DateTime.Now;
                    string time = now.ToString();
                    time = time.Replace(" ", "_");
                    time = time.Replace("/", "-");
                    time = time.Replace(":", "-");
                    Bmp.Save(@"C:\Users\Public\Pictures\airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".Bmp");
                    MessageBox.Show("The bmp saved in C:\\Users\\Public\\Pictures\\ as airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".Bmp", "Sucess");

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Pictures\airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(pdfImage);
                doc.Close();


                string filename = "C:\\Users\\Public\\Pictures\\airwaybills_" + txtFileName.Text + "_savedAt--" + time + ".pdf";
                Process p = new Process();
                p.StartInfo.FileName = "AcroRd32.exe";
                p.StartInfo.Arguments = @" /p """ + filename + @"""";

                p.Start();
            }


        }
    }
}
