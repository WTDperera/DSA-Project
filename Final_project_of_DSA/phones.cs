namespace Final_project_of_DSA
{
    public class Node1
    {
        public string ProductName { get; set; }  // Product name
        public string ProductID { get; set; }    // Product ID
        public double Price { get; set; }        // Price
        public string Processor { get; set; }    // Processor details
        public string RAM { get; set; }          // RAM capacity
        public string Storage { get; set; }      // Storage capacity
        public double BatteryLife { get; set; } // Battery life in hours
        public string Display { get; set; }     // Display size and resolution
        public string CameraQuality { get; set; } // Camera quality (e.g., 12MP, 48MP)
        public string Condition { get; set; }    // Condition: New, Refurbished, Booked, etc.
        public Node1 Next { get; set; }         // Pointer to the next node

        // Constructor to initialize a node
        public Node1(string productName, string productID, double price, string processor, string ram, string storage, double batteryLife, string display, string cameraQuality, string condition)
        {
            ProductName = productName;
            ProductID = productID;
            Price = price;
            Processor = processor;
            RAM = ram;
            Storage = storage;
            BatteryLife = batteryLife;
            Display = display;
            CameraQuality = cameraQuality;
            Condition = condition;
            Next = null;
        }
    }
}