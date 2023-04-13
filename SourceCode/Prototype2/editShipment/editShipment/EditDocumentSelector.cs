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
    public partial class EditDocumentSelector : Form
    {
        public EditDocumentSelector()
        {
            InitializeComponent();
        }

        private void testBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDataSet);

        }

        private void EditDocumentSelector_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.test' table. You can move, or remove it, as needed.
            this.testTableAdapter.Fill(this.testDataSet.test);

        }

        private void testDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditDocumentShipment e1 = new EditDocumentShipment();
            e1.Show();
        }

        private void testBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void testDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
