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

        public void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            
        }
    

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
