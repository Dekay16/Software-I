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

        private void addPartSave_Click(object sender, EventArgs e)
        {
            
        }

        private void addPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addPartOutsourcedRadio_CheckChanged(object sender, EventArgs e)
        {
            addPartMachComp.Text = "Company Name";
        }

        private void addPartInHouseRadio_CheckChanged(object sender, EventArgs e)
        {
            addPartMachComp.Text = "Machine ID";
        }
    }
}
