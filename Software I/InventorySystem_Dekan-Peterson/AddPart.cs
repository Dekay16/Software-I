using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Dekan_Peterson
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        // Save button for AddPart form - using try/catch to check input values
        private void addPartSave_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(addPartMinTextBox.Text);
                maxStock = int.Parse(addPartMaxTextBox.Text);
                invInStock = int.Parse(addPartInvTextBox.Text);
                price = decimal.Parse(addPartPriceCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Text fields need correct values.\nInventory, price, min, max need to be a numeric value.");
                return;
            }



            string name = addPartNameTextBox.Text;
            price = decimal.Parse(addPartPriceCostTextBox.Text);
            minStock = int.Parse(addPartMinTextBox.Text);
            maxStock = int.Parse(addPartMaxTextBox.Text);
            invInStock = int.Parse(addPartInvTextBox.Text);


            
            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Maximum must be more than minimum");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between maximum and minimum inventory");
                return;
            }


            if (inHousePartButton.Checked)
            {
                InHousePart inPart = new InHousePart((Inventory.AllParts.Count + 1), name, invInStock, price, maxStock, minStock, int.Parse(addPartMachineIDTextBox.Text));
                Inventory.AddPart(inPart);

            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart((Inventory.AllParts.Count + 1), name, invInStock, price, maxStock, minStock, addPartMachineIDTextBox.Text);
                Inventory.AddPart(outPart);

            }
            Close();
        }

        // Cancel button for AddPart form
        private void addPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Outsourced Radio button for AddPart form
        private void addPartOutsourcedRadio_CheckChanged(object sender, EventArgs e)
        {
            addPartMachComp.Text = "Company Name";
        }

        // In House Radio button for AddPart form
        private void addPartInHouseRadio_CheckChanged(object sender, EventArgs e)
        {
            addPartMachComp.Text = "Machine ID";
        }
    }
}
