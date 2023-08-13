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
    public partial class MainScreen : Form
    {
        // Loads in templates for DGV's and populates them from Inventory class
        public void TestProducts()
        {
            InventorySystem_Dekan_Peterson.Inventory.PopulateTestLists();

            
            var mainBindingPart = new BindingSource();
            mainBindingPart.DataSource = InventorySystem_Dekan_Peterson.Inventory.AllParts;
            mainDataGridParts.DataSource = mainBindingPart;

            mainDataGridParts.Columns["PartID"].HeaderText = "Part ID";
            mainDataGridParts.Columns.["Name"].HeaderText = "Part Name";
            mainDataGridParts.Columns["InStock"].HeaderText = "Inventory";
            mainDataGridParts.Columns["Price"].HeaderText = "Price per Unit";
            mainDataGridParts.Columns["Max"].Visible = false;
            mainDataGridParts.Columns["Min"].Visible = false;
            

            
            var mainBindingProd = new BindingSource();
            mainBindingProd.DataSource = InventorySystem_Dekan_Peterson.Inventory.Products;
            mainDataGridProducts.DataSource = mainBindingProd;

            mainDataGridProducts.Columns["ProductID"].HeaderText = "Product ID";
            mainDataGridProducts.Columns["Name"].HeaderText = "Product Name";
            mainDataGridProducts.Columns["InStock"].HeaderText = "Inventory";
            mainDataGridProducts.Columns["Price"].HeaderText = "Price per Unit";
            mainDataGridProducts.Columns["Max"].Visible = false;
            mainDataGridProducts.Columns["Min"].Visible = false;
        }

        public MainScreen()
        {
            InitializeComponent();
            TestProducts();
        }

        // Search button for parts DGV - Returning "Nothing found" if no results
        private void mainPartsSearch_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (mainPartSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(mainPartSearchTextBox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    mainDataGridParts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                mainDataGridParts.DataSource = Inventory.AllParts;
            }
        }

        // Add button for parts DGV - This will open AddParts form
        private void mainPartsAdd_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        // Modify button for parts DGV - uses inhouse/outsourced parts to determine what version of ModifyPart form to open
        private void mainPartsModify_Click(object sender, EventArgs e)
        {
            if (mainDataGridParts.CurrentRow.DataBoundItem.GetType() == typeof(InventorySystem_Dekan_Peterson.InHousePart))
            {
                InHousePart inPart = (InHousePart)mainDataGridParts.CurrentRow.DataBoundItem;
                new ModifyPart(inPart).ShowDialog();
            }
            else
            {
                OutsourcedPart outPart = (OutsourcedPart)mainDataGridParts.CurrentRow.DataBoundItem;
                new ModifyPart(outPart).ShowDialog();
            }
        }
        
        // Delete button for Parts DGV
        private void mainPartsDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = mainDataGridParts.CurrentCell.RowIndex;
            mainDataGridParts.Rows.RemoveAt(rowIndex);
            
        }

        // Search button for Products DGV - Returning "Nothing found" if no results
        private void mainProductSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;
            if (mainProductSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(mainProductSearchTextBox.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    mainDataGridProducts.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
                mainDataGridProducts.DataSource = Inventory.Products;
            }
        }

        // Add button for Products DGV - This will open AddProducts form
        private void mainProductAddButton_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        // Delete button for Products DGV
        private void mainProductDeleteButton_Click(object sender, EventArgs e)
        {
            Product prod = (Product)mainDataGridProducts.CurrentRow.DataBoundItem;
            if (prod.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Can not remove product beacuse it has parts associated with it.\nRemove associated parts.");
                    return;
            }

            int rowIndex = mainDataGridProducts.CurrentCell.RowIndex;
            mainDataGridProducts.Rows.RemoveAt(rowIndex);

        }

        // Modify button for products DGV
        private void mainProductModifyButton_Click(object sender, EventArgs e)
        {

            Product selectedProduct = (Product)mainDataGridProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProduct).ShowDialog();
        }

        // Cancel button for MainScreen - Closes application
        private void mainExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
