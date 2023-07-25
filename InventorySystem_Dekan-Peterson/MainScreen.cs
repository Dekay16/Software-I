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
        public void TestProducts()
        {
            InventorySystem_Dekan_Peterson.Inventory.PopulateTestLists();

            // All Parts in inventory show in the left table
            var mainBindingPart = new BindingSource();
            mainBindingPart.DataSource = InventorySystem_Dekan_Peterson.Inventory.AllParts;
            mainDataGridParts.DataSource = mainBindingPart;

            mainDataGridParts.Columns["PartID"].HeaderText = "Part ID";
            mainDataGridParts.Columns["Name"].HeaderText = "Part Name";
            mainDataGridParts.Columns["InStock"].HeaderText = "Inventory";
            mainDataGridParts.Columns["Price"].HeaderText = "Price/Cost per Unit";
            mainDataGridParts.Columns["Max"].Visible = false;
            mainDataGridParts.Columns["Min"].Visible = false;

            // All Products in inventory show in the right table
            var mainBindingProd = new BindingSource();
            mainBindingProd.DataSource = InventorySystem_Dekan_Peterson.Inventory.Products;
            mainDataGridProducts.DataSource = mainBindingProd;

            mainDataGridProducts.Columns["ProductID"].HeaderText = "Product ID";
            mainDataGridProducts.Columns["Name"].HeaderText = "Product Name";
            mainDataGridProducts.Columns["InStock"].HeaderText = "Inventory";
            mainDataGridProducts.Columns["Price"].HeaderText = "Price/Cost per Unit";
            mainDataGridProducts.Columns["Max"].Visible = false;
            mainDataGridProducts.Columns["Min"].Visible = false;
        }

        public MainScreen()
        {
            InitializeComponent();
            TestProducts();
        }

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

        private void mainPartsAdd_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

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
        //Not Working
        private void mainPartsDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in mainDataGridParts.SelectedRows)
            {
                mainDataGridParts.Rows.RemoveAt(row.Index);
            }
        }

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

        private void mainProductAddButton_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        
        private void mainProductDeleteButton_Click(object sender, EventArgs e)
        {
            Product prod = (Product)mainDataGridProducts.CurrentRow.DataBoundItem;
            if (prod.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Can not remove product beacuse it has parts associated with it.\nRemove associated parts.");
                    return;
            }

            //Not Working
            foreach (DataGridViewRow row in mainDataGridProducts.SelectedRows)
            {
                mainDataGridProducts.Rows.RemoveAt(row.Index);
            }
        }

        private void mainProductModifyButton_Click(object sender, EventArgs e)
        {

            Product selectedProduct = (Product)mainDataGridProducts.CurrentRow.DataBoundItem;
            new ModifyProduct(selectedProduct).ShowDialog();
        }

        private void mainExitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
