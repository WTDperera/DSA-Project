using System;
using System.Collections.Generic;

namespace Final_project_of_DSA
{
    public class Tree : Node
    {
        public Tree? Left { get; set; }
        public Tree? Right { get; set; }

        // Constructor that initializes Tree using Node parameters
        public Tree(string product_name, string product_ID, double price, string category, string processor,
                    string ram, string storage, string gpu, string display, double warranty, string condition, double batteryLife)
            : base(product_name, product_ID, price, category, processor, ram, storage, gpu, display, warranty, condition, batteryLife)
        {
            Left = null;
            Right = null;
        }

        // Method to print the laptops in tabular format
        public void PrintTable(List<Tree> laptopList)
        {
            Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| Product Name   | Product ID  | Price LKR  | Category  | Processor    | RAM  | Storage  | GPU    | Display  | Warranty | Condition  | Battery Life |");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");

            foreach (var laptop in laptopList)
            {
                Console.WriteLine($"| {laptop.product_name,-14} | {laptop.product_ID,-11} | {laptop.Price,-10} | {laptop.Category,-9} | {laptop.Processor,-11} | {laptop.RAM,-4} | {laptop.Storage,-8} | {laptop.GPU,-6} | {laptop.Display,-8} | {laptop.Warranty,-8} | {laptop.Condition,-10} | {laptop.BatteryLife,-12} |");
            }

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
