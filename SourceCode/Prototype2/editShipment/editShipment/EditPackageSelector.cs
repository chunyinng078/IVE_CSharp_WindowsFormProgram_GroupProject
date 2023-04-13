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
    public partial class EditPackageSelector : Form
    {
        public EditPackageSelector()
        {
            InitializeComponent();
        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }

        private void EditPackageSelector_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'edeDataSet.airwaybill' table. You can move, or remove it, as needed.
            this.airwaybillTableAdapter.Fill(this.edeDataSet.airwaybill);
            // TODO: This line of code loads data into the 'testDataSet.test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.testDataSet.test);

        }

        private void testDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditPackageShipment e1 = new EditPackageShipment();
            e1.Show();
        }

        private void testDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
