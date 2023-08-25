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
    public partial class ModifyProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        MainScreen MainMenu = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProduct()
        {
            InitializeComponent();
        }
        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            LoadModifyProduct(prod);
        }

        // Loads template for DGV's tables when form is initialized and uses selected item to auto populate input
        private void LoadModifyProduct(Product selectedProduct)
        {

            modProductIDTextBox.Text = selectedProduct.ProductID.ToString();
            modProductNameTextBox.Text = selectedProduct.Name.ToString();
            modProductInvTextBox.Text = selectedProduct.InStock.ToString();
            modProductPriceCostTextBox.Text = decimal.Parse(selectedProduct.Price.Substring(1)).ToString();
            modProductMaxTextBox.Text = selectedProduct.Max.ToString();
            modProductMinTextBox.Text = selectedProduct.Min.ToString();


            
            var BindingCandidates = new BindingSource();
            BindingCandidates.DataSource = Inventory.AllParts;
            modProductCanidateDataGridView.DataSource = BindingCandidates;
            modProductCanidateDataGridView.Columns["PartID"].HeaderText = "Part ID";
            modProductCanidateDataGridView.Columns["Name"].HeaderText = "Part Name";
            modProductCanidateDataGridView.Columns["InStock"].HeaderText = "Inventory Level";
            modProductCanidateDataGridView.Columns["Price"].HeaderText = "Price per Unit";
            modProductCanidateDataGridView.Columns["Max"].Visible = false;
            modProductCanidateDataGridView.Columns["Min"].Visible = false;
        

            
            foreach (Part part in selectedProduct.AssociatedParts)
            {
                addedParts.Add(part);
            }

            var BindingAssociated = new BindingSource();
            BindingAssociated.DataSource = addedParts;
            modProductAssociatedDataGridView.DataSource = BindingAssociated;
            modProductAssociatedDataGridView.Columns["PartID"].HeaderText = "Part ID";
            modProductAssociatedDataGridView.Columns["Name"].HeaderText = "Part Name";
            modProductAssociatedDataGridView.Columns["InStock"].HeaderText = "Inventory Level";
            modProductAssociatedDataGridView.Columns["Price"].HeaderText = "Price per Unit";
            modProductAssociatedDataGridView.Columns["Max"].Visible = false;
            modProductAssociatedDataGridView.Columns["Min"].Visible = false;
        }

        // Add button for Modify Product
        private void modProductAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modProductCanidateDataGridView.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        // Delete button for ModifyProduct - will ask if the user is sure they would like to remove item for good
        private void modProductDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting this can not be undone, are you sure you wish to do this?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Part part = (Part)modProductAssociatedDataGridView.CurrentRow.DataBoundItem;
                int id = int.Parse(modProductIDTextBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                int rowIndex = modProductAssociatedDataGridView.CurrentCell.RowIndex;
                modProductAssociatedDataGridView.Rows.RemoveAt(rowIndex);
            }
            else return;
        }

        // Save button for ModifyProduct - uses try/catch to vailidate input
        private void modProductSaveButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;

            try
            {
                min = int.Parse(modProductMinTextBox.Text);
                max = int.Parse(modProductMaxTextBox.Text);
                inventory = int.Parse(modProductInvTextBox.Text);
                price = decimal.Parse(modProductPriceCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Text fields need correct values.\nInventory, price, min, max need to be a numeric value.");
                return;
            }

            int id = int.Parse(modProductIDTextBox.Text);
            string name = modProductNameTextBox.Text;
            inventory = int.Parse(modProductInvTextBox.Text);
            price = decimal.Parse(modProductPriceCostTextBox.Text);
            min = int.Parse(modProductMinTextBox.Text);
            max = int.Parse(modProductMaxTextBox.Text);

            
            if (min > max)
            {
                MessageBox.Show("Error: Minimum cannot be greater than maximum.");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory has to be a value between the minimum and maximum values.");
                return;
            }
            
            Product product = new Product(id, name, inventory, price, max, min);
            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Inventory.UpdateProduct(id, product);
            this.Close();

            
            // Refreshes and updates DGV on MainScreen form
            MainMenu.mainDataGridProducts.Update();
            MainMenu.mainDataGridProducts.Refresh();
        }

        // Cancel button for ModifyProduct
        private void modProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Seach button for ModifyProduct
        private void modProductSearchButton_Click(object sender, EventArgs e)
        {
            int partID = int.Parse(modProductSearchTextBox.Text);
            Part match = Inventory.LookupPart(partID);
            foreach (DataGridViewRow row in modProductCanidateDataGridView.Rows)
            {
                Part part = (Part)row.DataBoundItem;
                if (part.PartID == match.PartID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }
    }
}
