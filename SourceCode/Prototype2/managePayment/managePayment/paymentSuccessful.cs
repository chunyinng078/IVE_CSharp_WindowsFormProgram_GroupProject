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
    public partial class paymentSuccessful : Form
    {
        public paymentSuccessful()
        {
            InitializeComponent();
            this.timer1.Interval = 10000;
            this.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentSuccessful_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timer1.Interval == 10000) {
                paymentSelector aa = new paymentSelector();
                aa.Show();
                this.Close();
            }

        }
    }
}
