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

namespace WindowsFormsApp1
{
    
    public partial class EditPickUp : Form
    {

        public static string cusID ;
        public static String pickupId ;
        public static Boolean isStaff;

        public EditPickUp()
        {
            
            
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPickUp_Load(object sender, EventArgs e)
        {

            

            if (isStaff)
            {
                staffEdit();
            }
            else
            {
                customerEdit();
            }

        }
        private void staffEdit()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From pickup ", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void customerEdit()
        {
            string connStr = "server=127.0.0.1;uid=root;pwd=;database=ede;convert zero datetime=True";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();
            da = new MySqlDataAdapter("Select * From pickup where pickup_cusID ='" + cusID + "'", conn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pickupId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EditPickupORder editPickupORder = new EditPickupORder(pickupId);
            editPickupORder.Show();
            
            


        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pickupId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            EditPickupORder editPickupORder = new EditPickupORder(pickupId);
            editPickupORder.Show();
        }

    }
}
