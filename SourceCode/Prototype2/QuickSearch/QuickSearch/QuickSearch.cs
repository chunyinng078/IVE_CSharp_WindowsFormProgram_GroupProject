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

namespace QuickSearch
{
    public partial class QuickSearch : Form
    {

        string conString = "server=127.0.0.1;user id=root;persistsecurityinfo=True;database=ede";

        public QuickSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(conString);
            MySqlDataAdapter da;
            DataTable dt;
            conn.Open();

            if (txtStaffName.Text != "")
            {
                da = new MySqlDataAdapter("SELECT staffName, extension, email FROM `staff` WHERE staffName='" + txtStaffName.Text + "'", conn);
            }
            else
            {
                da = new MySqlDataAdapter("SELECT staffName, extension, email, salary FROM `staff` WHERE staffDept='" + txtStaffDept.Text + "'", conn);
            }

            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
            txtStaffDept.Enabled = false;
            if (txtStaffName.Text == "")
            {
                txtStaffDept.Enabled = true;
            }
        }

        private void txtStaffDept_TextChanged(object sender, EventArgs e)
        {
            txtStaffName.Enabled = false;
            if (txtStaffDept.Text == "")
            {
                txtStaffName.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            QuickSearch qs = new QuickSearch();
            qs.Show();
            this.Hide();
            }
        }
    }
