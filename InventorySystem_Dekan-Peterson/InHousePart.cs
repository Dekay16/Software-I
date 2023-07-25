using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Dekan_Peterson
{
    public class InHousePart : Part
    {
        private int machineID;

        public int MachineID { get; set; }

        public InHousePart() { }
        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public InHousePart(int partID, string name, int inStock, decimal price, int max, int min, int machineID)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machineID;
        }
    }
}
