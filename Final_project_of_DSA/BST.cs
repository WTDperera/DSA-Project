using System;

namespace Final_project_of_DSA
{
    public class BST
    {
        private Tree? Root; // Root node of the BST

        public BST()
        {
            Root = null;
        }

        // Recursive insertion function
        private Tree InsertRecursively(string product_name, string product_ID, double price, string category, string processor,
                                       string ram, string storage, string gpu, string display, double warranty, string condition, double batteryLife, Tree? root)
        {
            if (root == null)
            {
                root = new Tree(product_name, product_ID, price, category, processor, ram, storage, gpu, display, warranty, condition, batteryLife);
                return root;
            }

            if (string.Compare(product_ID, root.product_ID, StringComparison.OrdinalIgnoreCase) < 0)
            {
                root.Left = InsertRecursively(product_name, product_ID, price, category, processor, ram, storage, gpu, display, warranty, condition, batteryLife, root.Left);
            }
            else if (string.Compare(product_ID, root.product_ID, StringComparison.OrdinalIgnoreCase) > 0)
            {
                root.Right = InsertRecursively(product_name, product_ID, price, category, processor, ram, storage, gpu, display, warranty, condition, batteryLife, root.Right);
            }

            return root;
        }

        // Public insert method
        public void Insert(string product_name, string product_ID, double price, string category, string processor,
                           string ram, string storage, string gpu, string display, double warranty, string condition, double batteryLife)
        {
            Root = InsertRecursively(product_name, product_ID, price, category, processor, ram, storage, gpu, display, warranty, condition, batteryLife, Root);
        }

        // Recursive search function
        private Tree? SearchByID(Tree? root, string ID)
        {
            if (root == null) return null;

            if (root.product_ID.Equals(ID, StringComparison.OrdinalIgnoreCase))
            {
                return root;
            }

            if (string.Compare(ID, root.product_ID, StringComparison.OrdinalIgnoreCase) < 0)
            {
                return SearchByID(root.Left, ID);
            }
            else
            {
                return SearchByID(root.Right, ID);
            }
        }

        // Public search method
        public Tree? Search(string ID)
        {
            return SearchByID(Root, ID);
        }

        // Print the BST in table format
        private void PrintInOrder(Tree? root)
        {
            if (root != null)
            {
                PrintInOrder(root.Left);
                Console.WriteLine($"| {root.product_name,-14} | {root.product_ID,-11} | {root.Price,-10} | {root.Category,-9} | {root.Processor,-11} | {root.RAM,-4} | {root.Storage,-8} | {root.GPU,-6} | {root.Display,-8} | {root.Warranty,-8} | {root.Condition,-10} | {root.BatteryLife,-12} |");
                PrintInOrder(root.Right);
            }
        }
        public void Print()
        {
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Product Name   | Product ID  | Price LKR  | Category  | Processor    | RAM  | Storage  | GPU    | Display  | Warranty | Condition  | Battery Life |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");

            PrintInOrder(Root);

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
        }


    }
}
