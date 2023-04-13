using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ShippingExpensesCalculate
{
    public partial class CalculateExpenses : Form
    {
        public CalculateExpenses()
        {
            InitializeComponent();
            txtExpenses.ReadOnly = true;    // set the output read only
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string errorMsg = "Please check again the following data:\n";
            double weight = 0;

            try                 // check if weight inputed as number
            {  
                weight = double.Parse(txtWeight.Text); 
            }
            catch(System.FormatException) 
            {
                //nothing to do
                errorMsg = errorMsg + "\nWeight cannot be null or zero\n\n";

            }



            if (rdoDoc.Checked == true)    //EDE EXPRESS FREIGHT
            {


                if (txtPieces.Text == ""|| txtPieces.Text == "0")
                {
                    errorMsg = errorMsg + "Pieces cannot be null or zero\n\n";
                }
                else
                {
                    try                 // check if account no. inputed as number
                    {
                        int tmp = 0;

                        try
                        {

                            tmp = int.Parse(txtPieces.Text);
                        }
                        catch (System.FormatException a)
                        {
                            errorMsg = errorMsg + "\n-Pieces, please enter pieces with integer number.";

                        }
                        double tmp2 = double.Parse(txtWeight.Text);
                        double totalWeight = tmp * tmp2;

                        if (totalWeight ==0)
                        {
                            errorMsg = errorMsg + "Total Weight, document shipment's weight cannot be >=0 kg, total weight = weight * pieces. \n\n";
                            txtExpenses.Text = "";
                        }
                        else if (totalWeight >= 3)
                        {
                            errorMsg = errorMsg + "Total Weight, package shipment's weight cannot be >=3 kg. (total weight = weight * pieces), weight less than 3 please use document shipment services.\n\n";
                            txtExpenses.Text = "";
                        }

                    }
                    catch (System.FormatException)
                    {
                        errorMsg = errorMsg + "Pieces, please enter Pieces with integer number.\n\n";
                    }
                }


                if (errorMsg.Length != 39)              //check is there any error added to the errorMsg
                {
                    MessageBox.Show(errorMsg, "Error");
                    txtExpenses.Text = "";
                }
                else if (weight <= 0.5)
                {
                    txtExpenses.Text = 158.ToString();
                }
                else if (weight > 0.5)
                {
                    /*   (kg)       ($)
                         0.1-0.5	158
                         0.6-1.0	308
                         1.1-1.5	458
                         1.6-2.0	608
                         2.1-2.5	758
                         2.6-2.9	908
                     */
                    weight = weight - 0.5;
                    double count = 158;
                    while (weight > 0)
                    {
                        weight = weight - 0.5;
                        count = count + 150;
                    }
                    txtExpenses.Text = count.ToString();
                }
            }
            else if (rdoFreight.Checked == true)        //EDE EXPRESS DOCUMENT ENVELOPE
            {
                int tmp = 0;

                try
                {

                     tmp = int.Parse(txtPieces.Text);
                } 
                catch (System.FormatException a)
                {
                    errorMsg = errorMsg + "\n-Pieces, please enter pieces with integer number.";

                }
                double tmp2 = double.Parse(txtWeight.Text);
                double totalWeight = tmp * tmp2;

                if (totalWeight < 3 || totalWeight > 999)
                {
                    errorMsg = errorMsg + "\n-Total weight, the format of total weight should be a number and >=3 and <=999.  (total weight = weight * pieces)";
                }

                if (rdoFreight.Checked == true)
                {
                    if (cmbCountry.SelectedIndex == -1)         //check selected country
                    {
                        errorMsg = errorMsg + "\n-Country, not selected.";
                    }
                }

                if (errorMsg.Length != 39)              //check is there any error added to the errorMsg
                {
                    MessageBox.Show(errorMsg, "Error");
                }
                else if (totalWeight >= 3 && totalWeight <= 15)   //check what the expenses should be
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "75"; break;
                        case "JAPAN":
                            txtExpenses.Text = "75"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "45"; break;
                    }
                }
                else if (totalWeight >= 16 && totalWeight <= 29)
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "70"; break;
                        case "JAPAN":
                            txtExpenses.Text = "70"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "40"; break;
                    }
                }
                else if (totalWeight >= 30 && totalWeight <= 44)
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "65"; break;
                        case "JAPAN":
                            txtExpenses.Text = "65"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "37"; break;
                    }
                }
                else if (totalWeight >= 45 && totalWeight <= 69)
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "62"; break;
                        case "JAPAN":
                            txtExpenses.Text = "62"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "35"; break;
                    }
                }
                else if (totalWeight >= 70 && totalWeight <= 99)
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "61"; break;
                        case "JAPAN":
                            txtExpenses.Text = "61"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "33"; break;
                    }
                }
                else
                {
                    switch (cmbCountry.SelectedItem.ToString())
                    {
                        case "AUSTRALIA":
                            txtExpenses.Text = "58"; break;
                        case "JAPAN":
                            txtExpenses.Text = "58"; break;
                        case "China SHANGHAI":
                            txtExpenses.Text = "32"; break;
                    }
                }

                try                 // check if weight inputed as number
                {
                    double expense = double.Parse(txtExpenses.Text);

                    expense = expense * totalWeight;

                    txtExpenses.Text = expense.ToString();

                }
                catch (System.FormatException)
                {
                    //nothing to do
                }

            }
            else
            {

                errorMsg = errorMsg + "\n-Express type, please choose a express type.";
                MessageBox.Show("Please choose the express type first!!!","Error");


            }
        }

        private void rdoDoc_CheckedChanged(object sender, EventArgs e)
        {
            cmbCountry.Enabled = false;         // when choosing EDE EXPRESS DOCUMENT ENVELOPE, lock the combobox
        }

        private void rdoFreight_CheckedChanged(object sender, EventArgs e)
        {
            cmbCountry.Enabled = true;          // when choosing EEDE EXPRESS FREIGHT, able the combobox
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblExpressType_Click(object sender, EventArgs e)
        {

        }

        private void lblWeight_Click(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
