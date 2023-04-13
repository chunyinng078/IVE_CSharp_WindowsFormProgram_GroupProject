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

namespace QuickSearchAirwayBill
{
    public partial class QuickSearchAirwayBill : Form
    {

        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

        public QuickSearchAirwayBill()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(conString);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();

            da = new MySqlDataAdapter("SELECT airwayBillID, statusComment, status FROM `airwaybill` WHERE airwayBillID=" + txtBillNo.Text , conn);

            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            QuickSearchAirwayBill qs = new QuickSearchAirwayBill();
            qs.Show();
            this.Hide();
        }
    }
}
