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
        public MainScreen()
        {
            InitializeComponent();
            MainScreen_Load();
        }

        public void MainScreen_Load()
        {
            
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
        private void mainPartsSearch_Click(object sender, EventArgs e)
        {

        }

        private void mainPartsAdd_Click(object sender, EventArgs e)
        {
            new AddPart().ShowDialog();
        }

        private void mainPartsModify_Click(object sender, EventArgs e)
        {
            new ModifyPart().ShowDialog();
        }

        private void mainPartsDelete_Click(object sender, EventArgs e)
        {

        }

        private void mainProductSearch_Click(object sender, EventArgs e)
        {

        }

        private void mainProductAdd_Click(object sender, EventArgs e)
        {
            new AddProduct().ShowDialog();
        }

        private void mainProductModify_Click(object sender, EventArgs e)
        {
            new ModifyProduct().ShowDialog();
        }

        private void mainProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
