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
    public partial class AddProduct : Form
    {
        BindingList<Part> partsToAdd = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            
        }

        // Initializes everytime the addProduct form loads - Creates DGV template and binds the lists to the tables
        public void AddProduct_Load(object sender, EventArgs e)
        {
            // The top table contains a list of all parts
            var BindingCandidate = new BindingSource();
            BindingCandidate.DataSource = Inventory.AllParts;
            addPartCandidateDGV.DataSource = BindingCandidate;
            addPartCandidateDGV.Columns["PartID"].HeaderText = "Part ID";
            addPartCandidateDGV.Columns["Name"].HeaderText = "Part Name";
            addPartCandidateDGV.Columns["InStock"].HeaderText = "Inventory Level";
            addPartCandidateDGV.Columns["Price"].HeaderText = "Price per Unit";
            addPartCandidateDGV.Columns["Max"].Visible = false;
            addPartCandidateDGV.Columns["Min"].Visible = false;

            
            var BindingAssociated = new BindingSource();
            BindingAssociated.DataSource = partsToAdd;
            addPartAssociatedDGV.DataSource = BindingAssociated;
            addPartAssociatedDGV.Columns["PartID"].HeaderText = "Part ID";
            addPartAssociatedDGV.Columns["Name"].HeaderText = "Part Name";
            addPartAssociatedDGV.Columns["InStock"].HeaderText = "Inventory Level";
            addPartAssociatedDGV.Columns["Price"].HeaderText = "Price per Unit";
            addPartAssociatedDGV.Columns["Max"].Visible = false;
            addPartAssociatedDGV.Columns["Min"].Visible = false;
        }

        // Delete button for AddProduct form
        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            int rowIndex = addPartAssociatedDGV.CurrentCell.RowIndex;
            addPartAssociatedDGV.Rows.RemoveAt(rowIndex);
        }

        // Search button for AddProduct form - uses value from searchbox and will look up parts that match
        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            int searchValue = int.Parse(addProductSearchTextBox.Text);

            Part match = Inventory.LookupPart(searchValue);

            foreach (DataGridViewRow row in addPartCandidateDGV.Rows)
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

        // Add button for AddProduct form
        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            Part partToAdd = (Part)addPartCandidateDGV.CurrentRow.DataBoundItem;
            partsToAdd.Add(partToAdd);
        }

        // Save button for AddProduct form - uses a try/catch to validate input
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(addProductMinTextBox.Text);
                maxStock = int.Parse(addProductMaxTextBox.Text);
                invInStock = int.Parse(addProductInvTextBox.Text);
                price = decimal.Parse(addProductPriceCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Text fields need correct values.\nInventory, price, min, max need to be a numeric value.");
                return;
            }

            string name = addProductNameTextBox.Text;
            price = decimal.Parse(addProductPriceCostTextBox.Text);
            minStock = int.Parse(addProductMinTextBox.Text);
            maxStock = int.Parse(addProductMaxTextBox.Text);
            invInStock = int.Parse(addProductInvTextBox.Text);

            if (maxStock < minStock)
            {
                MessageBox.Show("Minimum cannot be greater than the Maximum.");
                return;
            }

            
            Product productToAdd = new Product((Inventory.Products.Count + 1), name, invInStock, price, maxStock, minStock);
            Inventory.AddProduct(productToAdd);

            foreach (Part part in partsToAdd)
            {
                productToAdd.AddAssociatedPart(part);
            }
            this.Close();
        }
    

        // Cancel button for AddProduct form
        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
