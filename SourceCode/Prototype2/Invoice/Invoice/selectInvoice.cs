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

namespace Invoice
{
    public partial class selectInvoice : Form
    {
        public static string cusID;
        public static string airwaybill;

        public selectInvoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewInvoice v1 = new viewInvoice();
            v1.Show();
        }

        private void airwaybillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airwaybillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet);

        }

        private void selectInvoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet.airwaybill' table. You can move, or remove it, as needed.
            this.airwaybillTableAdapter.Fill(this.edeDataSet.airwaybill);

            // TODO: This line of code loads data into the 'edeDataSet3.airwaybill' table. You can move, or remove it, as needed.
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill where cusID = '" + cusID + "' and services = 1", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
            txtairwayBillID.Text = "";

        }
        public static string airwaybillno;
        private void airwaybillDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            airwaybillno = airwaybillDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            viewInvoice v1 = new viewInvoice();
            v1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill where airwayBillID like'%" + txtairwayBillID.Text + "%' and cusID = '" + cusID + "'and services = 1", conn);
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
            da = new MySqlDataAdapter("Select * From airwaybill where cusID = '" + cusID + "' and services = 1", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
            txtairwayBillID.Text = "";
        }
    }
}
