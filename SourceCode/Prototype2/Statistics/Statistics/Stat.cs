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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;


namespace Statistics
{
    public partial class Statistics : Form
    {
        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();

            if (txtCusID.Text != "" && txtShipmentType.Text != "" && txtDestination.Text != "")
            {
                da = new MySqlDataAdapter("SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND services=" + txtShipmentType.Text + " AND destinationCountry=" + txtDestination.Text, conn);
            }
            else if (txtCusID.Text != "" && txtShipmentType.Text != "")
            {
                da = new MySqlDataAdapter("SELECT cusID, services, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND services=" + txtShipmentType.Text, conn);
            }
            else if (txtCusID.Text != "" && txtDestination.Text != "")
            {
                da = new MySqlDataAdapter("SELECT cusID, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND destinationCountry=" + txtDestination.Text, conn);
            }
            else if (txtShipmentType.Text != "" && txtDestination.Text != "")
            {
                da = new MySqlDataAdapter("SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE services=" + txtShipmentType.Text + " AND destinationCountry=" + txtDestination.Text, conn);
            }
            else if (txtCusID.Text != "" && txtDestination.Text != "")
            {
                da = new MySqlDataAdapter("SELECT cusID, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND destinationCountry=" + txtDestination.Text, conn);
            }
            else if (txtCusID.Text != "" && txtDestination.Text == "" && txtShipmentType.Text == "")
            {
                da = new MySqlDataAdapter("SELECT cusID, services, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " GROUP BY `services`", conn);
            }
            else if (txtCusID.Text == "" && txtDestination.Text == "" && txtShipmentType.Text != "")
            {
                da = new MySqlDataAdapter("SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE services=" + txtShipmentType.Text + " GROUP BY `destinationCountry`", conn);
            }
            else if (txtCusID.Text == "" && txtDestination.Text != "" && txtShipmentType.Text == "")
            {
                da = new MySqlDataAdapter("SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE destinationCountry=" + txtDestination.Text + " GROUP BY `services`", conn);
            }
            else
            {
                da = new MySqlDataAdapter("SELECT cusID, COUNT(*) AS count FROM `airwaybill` GROUP BY cusID", conn);
            }

            dt = new DataTable();
            da.Fill(dt);
            statisticsGridView.DataSource = dt;
            conn.Close();
            btnShowChart.Visible = true;
            btnPieChart.Visible = true;
        }

        // fillChart method
        private void fillChart()
        {
            MySqlConnection conn2 = new MySqlConnection(conString);
            conn2.Open();
            string query;

            MySqlDataReader reader2 = null;

            if (txtCusID.Text != "" && txtShipmentType.Text != "" && txtDestination.Text != "")
            {
                query = "SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND services=" + txtShipmentType.Text + " AND destinationCountry=" + txtDestination.Text;
            }
            else if (txtCusID.Text != "" && txtShipmentType.Text != "")
            {
                query = "SELECT cusID, services, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND services=" + txtShipmentType.Text;
            }
            else if (txtCusID.Text != "" && txtDestination.Text != "")
            {
                query = "SELECT cusID, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND destinationCountry=" + txtDestination.Text;
            }
            else if (txtShipmentType.Text != "" && txtDestination.Text != "")
            {
                query = "SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE services=" + txtShipmentType.Text + " AND destinationCountry=" + txtDestination.Text;
            }
            else if (txtCusID.Text != "" && txtDestination.Text != "")
            {
                query = "SELECT cusID, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " AND destinationCountry=" + txtDestination.Text;
            }
            else if (txtCusID.Text != "" && txtDestination.Text == "" && txtShipmentType.Text == "")
            {
                query = "SELECT cusID, services, COUNT(*) AS count FROM `airwaybill` WHERE cusID=" + txtCusID.Text + " GROUP by `services`";
            }
            else if (txtCusID.Text == "" && txtDestination.Text == "" && txtShipmentType.Text != "")
            {
                query = "SELECT services, destinationCountry, COUNT(*) AS count FROM `airwaybill` WHERE services=" + txtShipmentType.Text + " GROUP by `services`";
            }
            else if (txtCusID.Text == "" && txtDestination.Text != "" && txtShipmentType.Text == "")
            {
                query = "SELECT destinationCountry, services, COUNT(*) AS count FROM `airwaybill` WHERE destinationCountry=" + txtDestination.Text + " GROUP by `services`";
            }
            else
            {
                query = "SELECT cusID, COUNT(*) AS count FROM `airwaybill` GROUP BY cusID";
            }


            MySqlCommand commandDB = new MySqlCommand(query, conn2);

            reader2 = commandDB.ExecuteReader();
            chart1.Series["Report1"].Points.Clear();

            while (reader2.Read())
            {
                if (txtCusID.Text != "" && txtDestination.Text == "" && txtShipmentType.Text == "")
                {
                    chart1.Series["Report1"].Points.AddXY(reader2.GetInt32("services"), reader2.GetInt32("count"));
                } else if (txtCusID.Text == "" && txtDestination.Text != "" && txtShipmentType.Text == "")
                {
                    chart1.Series["Report1"].Points.AddXY(reader2.GetInt32("destinationCountry"), reader2.GetInt32("count"));
                }
                else if (txtCusID.Text == "" && txtDestination.Text == "" && txtShipmentType.Text != "")
                {
                    chart1.Series["Report1"].Points.AddXY(reader2.GetInt32("services"), reader2.GetInt32("count"));
                }
            }
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Report1"].XValueMember = "cusID";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Report1"].YValueMembers = "count";
            conn2.Close();
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            if (chart1.Series["Report1"].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie){
                chart1.Series["Report1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            fillChart();
            chart1.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (var Bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(Bmp, new System.Drawing.Rectangle(0, 0, Bmp.Width, Bmp.Height));
                DateTime now = DateTime.Now;
                string time = now.ToString();
                time = time.Replace(" ", "_");
                time = time.Replace("/", "-");
                time = time.Replace(":", "-");
                System.Drawing.Image image = Bmp;
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\Public\Documents\_" + "Report_savedAt--" + time + ".pdf", FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(Bmp, System.Drawing.Imaging.ImageFormat.Jpeg);
                doc.Add(pdfImage);
                doc.Close();
            }
        }

        private void btnPieChart_Click(object sender, EventArgs e)
        {
            chart1.Series["Report1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {

        }
    }
}
