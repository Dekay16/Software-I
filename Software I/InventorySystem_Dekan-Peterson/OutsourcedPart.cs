using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Dekan_Peterson
{
    public class OutsourcedPart : Part
    {
        private string companyName;

        public string CompanyName { get; set; }

        public OutsourcedPart() { }
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
        }
        public OutsourcedPart(int partID, string name, int inStock, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompanyName = compName;
        }
    }
}
