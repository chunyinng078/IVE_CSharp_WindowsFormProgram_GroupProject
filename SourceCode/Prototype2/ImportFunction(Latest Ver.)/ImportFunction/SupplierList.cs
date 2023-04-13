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

namespace ImportFunction
{
    
    public partial class SupplierList : Form
    {
        public  String cusId="104";
        public SupplierList(String cusId)
        {
            this.cusId = cusId;
            InitializeComponent();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet1.regularproduct' table. You can move, or remove it, as needed.
           // this.regularproductTableAdapter1.Fill(this.edeDataSet1.regularproduct);
            // TODO: This line of code loads data into the 'edeDataSet.regularproduct' table. You can move, or remove it, as needed.

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            //da = new MySqlDataAdapter("Select `Code` AS `Prodct code`,`Description` AS `product description`,`Value` AS `Product Unit Value`,`Reason` AS `import Reason` From `regularproduct` where `CusID` ='" + cusId + "';", conn);
            //da = new MySqlDataAdapter("Select `ProductID` AS `Prodct code`,`Description` AS `product description`,`Value` AS `Product Unit Value`,`Reason` AS `import Reason` From `regularproduct` where `CusID` ='" + cusId + "';", conn);
            da = new MySqlDataAdapter("Select * From `regularproduct` where `CusID` ='" + cusId + "'", conn);
           // MessageBox.Show("reading");
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String Code = dataGridView1.SelectedCells[0].Value.ToString();
            //String Code = "Food1912";
            EditRegularSupplies edit = new EditRegularSupplies(Code);
            edit.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From  `regularproduct` where Description like'%" + tbsearch.Text + "%' and cusID = '" + cusId + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            //da = new MySqlDataAdapter("Select `Code` AS `Prodct code`,`Description` AS `product description`,`Value` AS `Product Unit Value`,`Reason` AS `import Reason` From `regularproduct` where `CusID` ='" + cusId + "';", conn);
            //da = new MySqlDataAdapter("Select `ProductID` AS `Prodct code`,`Description` AS `product description`,`Value` AS `Product Unit Value`,`Reason` AS `import Reason` From `regularproduct` where `CusID` ='" + cusId + "';", conn);
            da = new MySqlDataAdapter("Select * From `regularproduct` where `CusID` ='" + cusId + "'", conn);
            // MessageBox.Show("reading");
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
