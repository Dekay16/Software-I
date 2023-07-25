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
    public partial class ModifyPart : Form
    {
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];
        public ModifyPart()
        {
            InitializeComponent();
        }

        public ModifyPart(InHousePart inPart)
        {
            InitializeComponent();

            modPartIDTextBox.Text = inPart.PartID.ToString();
            modPartNameTextBox.Text = inPart.Name.ToString();
            modPartInvTextBox.Text = inPart.InStock.ToString();
            modPartPriceCostTextBox.Text = decimal.Parse(inPart.Price.Substring(1)).ToString();
            modPartMaxTextBox.Text = inPart.Max.ToString();
            modPartMinTextBox.Text = inPart.Min.ToString();
            modPartMachCompTextBox.Text = inPart.MachineID.ToString();

        }

        public ModifyPart(OutsourcedPart outPart)
        {
            InitializeComponent();

            modPartIDTextBox.Text = outPart.PartID.ToString();
            modPartNameTextBox.Text = outPart.Name.ToString();
            modPartInvTextBox.Text = outPart.InStock.ToString();
            modPartPriceCostTextBox.Text = decimal.Parse(outPart.Price.Substring(1)).ToString();
            modPartMaxTextBox.Text = outPart.Max.ToString();
            modPartMinTextBox.Text = outPart.Min.ToString();
            modPartMachCompTextBox.Text = outPart.CompanyName.ToString();

            modPartOutsourceButton.Checked = true;
        }

        private void modPartInHouseRadio_CheckChanged(object sender, EventArgs e)
        {
            modPartMachComp.Text = "Machine ID";
        }

        private void modPartOutsourcedRadio_CheckChanged(object sender, EventArgs e)
        {
            modPartMachComp.Text = "Company Name";
        }

        private void modPartSave_Click(object sender, EventArgs e)
        {
            int minInv;
            int maxInv;
            int inv;
            decimal price;

            try
            {
                minInv = int.Parse(modPartMinTextBox.Text);
                maxInv = int.Parse(modPartMaxTextBox.Text);
                inv = int.Parse(modPartInvTextBox.Text);
                price = decimal.Parse(modPartPriceCostTextBox.Text);
            }
            catch 
            {
                MessageBox.Show("Error:\nValues must be numeric.");
                return;
            }

            int id = int.Parse(modPartIDTextBox.Text);
            string name = modPartNameTextBox.Text;
            price = decimal.Parse(modPartPriceCostTextBox.Text);
            minInv = int.Parse(modPartMinTextBox.Text);
            maxInv = int.Parse (modPartMaxTextBox.Text);
            inv = int.Parse(modPartInvTextBox.Text);

            if (minInv > maxInv)
            {
                MessageBox.Show("Error:\nMax needs to be greater than the minimum.");
                return;
            }

            if (inv > maxInv || inv < minInv)
            {
                MessageBox.Show("Error:\nInventory must be between maximum and minimum");
                return;
            }
            
            if (modPartInHouseButton.Checked)
            {
                InHousePart inPart = new InHousePart(id, name, inv, price, maxInv, minInv, int.Parse(modPartMachCompTextBox.Text));
                Inventory.UpdatePart(id, inPart);
                modPartInHouseButton.Checked = true;
            }
            else
            {
                OutsourcedPart outPart = new OutsourcedPart(id, name, inv, price, maxInv, minInv, modPartMachCompTextBox.Text);
                Inventory.UpdatePart(id, outPart);
                modPartOutsourceButton.Checked = true;
            }

            this.Close();
            MainForm.TestProducts();
            MainForm.mainDataGridParts.Update();
        }

        private void modPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
