using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managePayment
{
    public partial class ePay : Form
    {
        public ePay()
        {
            InitializeComponent();
            
        }

        private void ePay_Load(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Start();

            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox2.Show();
                pictureBox1.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true) {
                pictureBox3.Show();
                pictureBox2.Hide();
                pictureBox1.Hide();
                pictureBox4.Hide();
            }
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                pictureBox4.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox1.Hide();
            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timer1.Interval == 10000)
            {
                loading aa = new loading();
                aa.Show();
                this.Close();
            }
        }
    }
}
