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

namespace editShipment
{
    public partial class EditShipment : Form
    {
        public static string airwaybillno;
        public static string cusID = "103";

        public EditShipment()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet.airwaybill' table. You can move, or remove it, as needed.
            this.airwaybillTableAdapter.Fill(this.edeDataSet.airwaybill);

            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From airwaybill ", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();


        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            EditDocumentShipment e1 = new EditDocumentShipment();
            e1.Show();
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            EditPackageShipment e2 = new EditPackageShipment();
            e2.Show();
        }

        private void airwaybillBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airwaybillBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.edeDataSet);

        }

 
        private void airwaybillDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string tmp = airwaybillDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            airwaybillno = airwaybillDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            if (tmp == "0")
            {
                EditDocumentShipment e1 = new EditDocumentShipment();
                e1.Show();
            }
            else
            {

                EditPackageShipment e2 = new EditPackageShipment();
                e2.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
            da = new MySqlDataAdapter("Select * From airwaybill ", conn);
            dt = new DataTable();
            da.Fill(dt);
            airwaybillDataGridView.DataSource = dt;
            conn.Close();
            txtairwayBillID.Text = "";
        }
    }
}
