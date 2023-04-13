using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportFunction
{
    public partial class FunctionSelecter : Form
    {
        public string userid;
        public FunctionSelecter(String userid)
        {
            this.userid = userid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupplierList ex1 = new SupplierList(userid);
            this.Hide();
            ex1.Show();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            ImportMainPage ex = new ImportMainPage(userid);
            this.Hide();
            ex.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddRegularSupplies ex = new AddRegularSupplies(userid);
            this.Hide();
            ex.Show();
        }
    }
}
