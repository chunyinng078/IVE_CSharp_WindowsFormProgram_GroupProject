using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateShipment
{
    
    public partial class CreateShipments : Form
    {

        public static string custID;
        public static bool staff;
        public CreateShipments()
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
            pannelChildForm.Controls.Add(childForm);
            pannelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            btnDocument.BackColor = Color.White;
            btnPackage.BackColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            openChildForm(new CreatePackageShipment());
            btnPackage.BackColor = Color.Gray;
            btnDocument.BackColor = Color.White;
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {

             openChildForm(new CreateDocumentShipment());

            btnPackage.BackColor = Color.White;
            btnDocument.BackColor = Color.Gray;

        }
    }
}
