using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_Dekan_Peterson
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();


//methods for products
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }
        // Removes products from list by ID
        public static bool RemoveProduct(int productID)
        {
            bool success = false;
            foreach (Product prod in Products)
            {
                if (productID == prod.ProductID)
                {
                    Products.Remove(prod);
                    return success = true;
                }
                else
                {
                    MessageBox.Show("Removal failed.");
                    return false;
                }
            }
            return success;
        }
        // Searches list of Products by ID
        public static Product LookupProduct(int productID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == productID)
                {
                    return prod;
                }
            }
            Product emptyProd = new InventorySystem_Dekan_Peterson.Product();
            return emptyProd;
        }
        // Updates list of Products
        public static void UpdateProduct(int productID, Product updatedProduct)
        {
            foreach (Product currentProd in Products)
            {
                if (currentProd.ProductID == productID)
                {
                    currentProd.Name = updatedProduct.Name;
                    currentProd.InStock = updatedProduct.InStock;
                    currentProd.Price = updatedProduct.Price;
                    currentProd.Max = updatedProduct.Max;
                    currentProd.Min = updatedProduct.Min;
                    currentProd.AssociatedParts = updatedProduct.AssociatedParts;
                    return;
                }
            }
        }


// methods for parts
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        // Deletes part from list
        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                AllParts.Remove(partToDelete);
                return true;
            }
        }
        // Searches for part
        public static Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = null;  
            return emptyPart;
        }

        // Updates list of parts
        public static void UpdatePart(int partID, Part Allparts)
        {
            DeletePart(partID);
            AddPart(Allparts);
        }

        // Populates DGV with test Parts and Products
        public static void PopulateTestLists()
        {

            Product testProduct1 = new Product(1, "Test Product 1", 20, 10.00m, 20, 5);
            Product testProduct2 = new Product(2, "Test Product 2", 10, 9.00m, 25, 5);
            Product testProduct3 = new Product(3, "Test Product 3", 10, 6m, 25, 5);
            Product testProduct4 = new Product(4, "Test Product 4", 10, 9m, 25, 5);

            Products.Add(testProduct1);
            Products.Add(testProduct2);
            Products.Add(testProduct3);
            Products.Add(testProduct4);

            // add mach ids and comp names
            Part testPart1A = new InHousePart(1, "Test Part 1.A", 15, 10.00m, 30, 10, 101);
            Part testPart1B = new InHousePart(2, "Test Part 1.B", 10, 11.00m, 25, 10, 101);
            Part testPart2A = new InHousePart(3, "Test Part 2.A", 12, 19.00m, 25, 10, 102);
            Part testPart2B = new InHousePart(4, "Test Part 2.B", 15, 6.00m, 25, 10, 102);
            Part testPart3A = new OutsourcedPart(5, "Test Part 3.A", 15, 18.00m, 30, 10, "Test Comp 1");
            Part testPart3B = new OutsourcedPart(6, "Test Part 3.B", 10, 13.00m, 25, 10, "Test Comp 1");
            Part testPart4A = new OutsourcedPart(7, "Test Part 4.A", 12, 15.00m, 25, 10, "Test Comp 2");
            Part testPart4B = new OutsourcedPart(8, "Test Part 4.B", 15, 7.00m, 25, 10, "Test Comp 2");

            AllParts.Add(testPart1A);
            AllParts.Add(testPart1B);
            AllParts.Add(testPart2A);
            AllParts.Add(testPart2B);
            AllParts.Add(testPart3A);
            AllParts.Add(testPart3B);
            AllParts.Add(testPart4A);
            AllParts.Add(testPart4B);

            // Add parts to respective Products
            testProduct1.AssociatedParts.Add(testPart1A);
            testProduct1.AssociatedParts.Add(testPart1B);
            testProduct2.AssociatedParts.Add(testPart2A);
            testProduct2.AssociatedParts.Add(testPart2B);
            testProduct3.AssociatedParts.Add(testPart3A);
            testProduct3.AssociatedParts.Add(testPart3B);
            testProduct4.AssociatedParts.Add(testPart4A);
            testProduct4.AssociatedParts.Add(testPart4B);

        }
    }
        
}
