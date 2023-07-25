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
        MainScreen MainForm = (MainScreen)Application.OpenForms["MainScreen"];

        public ModifyProduct()
        {
            InitializeComponent();
        }
        public ModifyProduct(Product prod)
        {
            InitializeComponent();
            LoadModifyProduct(prod);
        }

        private void LoadModifyProduct(Product selectedProduct)
        {

            modProductIDTextBox.Text = selectedProduct.ProductID.ToString();
            modProductNameTextBox.Text = selectedProduct.Name.ToString();
            modProductInvTextBox.Text = selectedProduct.InStock.ToString();
            modProductPriceCostTextBox.Text = decimal.Parse(selectedProduct.Price.Substring(1)).ToString();
            modProductMaxTextBox.Text = selectedProduct.Max.ToString();
            modProductMinTextBox.Text = selectedProduct.Min.ToString();


            // The top table contains a list of all parts
            var bs1 = new BindingSource();
            bs1.DataSource = Inventory.AllParts;
            modProductCanidateDataGridView.DataSource = bs1;
            modProductCanidateDataGridView.Columns["PartID"].HeaderText = "Part ID";
            modProductCanidateDataGridView.Columns["Name"].HeaderText = "Part Name";
            modProductCanidateDataGridView.Columns["InStock"].HeaderText = "Inventory Level";
            modProductCanidateDataGridView.Columns["Price"].HeaderText = "Price per Unit";
            modProductCanidateDataGridView.Columns["Max"].Visible = false;
            modProductCanidateDataGridView.Columns["Min"].Visible = false;
        

            // The lower table contains all parts belonging to the selected Product from the main screen
            foreach (Part part in selectedProduct.AssociatedParts)
            {
                addedParts.Add(part);
            }

            var bs2 = new BindingSource();
            bs2.DataSource = addedParts;
            modProductAssociatedDataGridView.DataSource = bs2;
            modProductAssociatedDataGridView.Columns["PartID"].HeaderText = "Part ID";
            modProductAssociatedDataGridView.Columns["Name"].HeaderText = "Part Name";
            modProductAssociatedDataGridView.Columns["InStock"].HeaderText = "Inventory Level";
            modProductAssociatedDataGridView.Columns["Price"].HeaderText = "Price per Unit";
            modProductAssociatedDataGridView.Columns["Max"].Visible = false;
            modProductAssociatedDataGridView.Columns["Min"].Visible = false;
        }

        private void modProductAddButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modProductCanidateDataGridView.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void modProductDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void modProductSaveButton_Click(object sender, EventArgs e)
        {

        }

        private void modProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
