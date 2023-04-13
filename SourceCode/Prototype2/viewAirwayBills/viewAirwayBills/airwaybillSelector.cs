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

namespace viewAirwayBills
{


    public partial class airwaybillSelector : Form
    {

        public static string cusID ;

        public airwaybillSelector()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill where airwayBillID like'%" + txtairwayBillID.Text + "%' and cusID = '" + cusID + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill where cusID = '"+ cusID+"'", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
            txtairwayBillID.Text = "";
        }

        public static string a = "";
        public static string b = "";
        public static string c = "";
        public static string d = "";
        private void testDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airwaybillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet1);

        }


        


        private void Form1_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'edeDataSet3.airwaybill' table. You can move, or remove it, as needed.
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill where cusID = '" + cusID + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
            txtairwayBillID.Text = "";


        }


        private void airwaybillDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         //   a = airwaybillDataGridView.SelectedRows[0].Cells[0].Value.ToString();
         //   b = airwaybillDataGridView.SelectedRows[0].Cells[1].Value.ToString();
         //   c = airwaybillDataGridView.SelectedRows[0].Cells[2].Value.ToString();
         //   d = airwaybillDataGridView.SelectedRows[0].Cells[3].Value.ToString();


        }

        private void testBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void airwaybillDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void airwaybillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airwaybillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet1);

        }

        
        private void airwaybillDataGridView_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void airwaybillDataGridView_CellDoubleClick_3(object sender, DataGridViewCellEventArgs e)
        {
          //  
            
        }

        public static string airwaybillno;
        private void airwaybillDataGridView_CellDoubleClick_4(object sender, DataGridViewCellEventArgs e)
        {
            airwaybillno = airwaybillDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AirwayBillViewer f2 = new AirwayBillViewer();
            f2.Show();
        }
    }
}
