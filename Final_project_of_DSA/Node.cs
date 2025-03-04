using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Final_project_of_DSA
{
  
    public class Node
    {
        public string product_name { get; set; }        //product name
        public string product_ID { get; set; }          //product ID
        public double Price {  get; set; }              //price
        public string Category { get; set; }        // Gaming, Business, etc.
        public string Processor { get; set; }       // CPU details
        public string RAM { get; set; }             // RAM capacity
        public string Storage { get; set; }         // Storage type and size
        public string GPU { get; set; }             // GPU details
        public string Display { get; set; }         // Display size/resolutio
        public double Warranty { get; set; }        // Warranty details
        public string Condition { get; set; }       // New, refurbished, etc.
        public double BatteryLife { get; set; }     // Battery life in hours


         public  Node(string laptopID, string modelName, double price,string category, string processor,string ram, string storage, string gpu, string display, double warranty, string condition , double batteryLife)
        {
            product_name = laptopID;
            product_ID = modelName;
            Category = category;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            GPU = gpu;
            Display = display;
            Price = price;
            Warranty = warranty;
            Condition = condition;
            BatteryLife = batteryLife;
            Next = null;
        }

        public Node? Next { get; set; }

    }
}
