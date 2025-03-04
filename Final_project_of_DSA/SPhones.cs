using System;
using System.Numerics;

namespace Final_project_of_DSA
{
    public class SPhones
    {
        private Node1 Head { get; set; } // Head of the linked list
        private Node1 Tail { get; set; } // Tail of the linked list
        public int Count { get; private set; } // Number of nodes in the list

        // Add a new mobile phone to the end of the list
        public void AddLast1(string productName, string productID, double price, string processor, string ram, string storage, double batteryLife, string display, string cameraQuality, string condition)
        {
            Node1 newNode = new Node1(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);

            if (Tail == null) // If the list is empty
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        // Add a new mobile phone to the front of the list
        public void AddFront(string productName, string productID, double price, string processor, string ram, string storage, double batteryLife, string display, string cameraQuality, string condition)
        {
            Node1 newNode = new Node1(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);

            if (Head == null) // If the list is empty
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
            Count++;
        }

        // Add a new mobile phone at a specific index
        public void AddIndex(string productName, string productID, double price, string processor, string ram, string storage, double batteryLife, string display, string cameraQuality, string condition, int index)
        {
            if (index < 0 || index > Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            if (index == 0)
            {
                AddFront(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);
            }
            else if (index == Count)
            {
                AddLast1(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);
            }
            else
            {
                Node1 newNode = new Node1(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);
                Node1 current = Head;

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
                Count++;
            }
        }

        // Remove a mobile phone at a specific index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            if (index == 0) // Remove the first node
            {
                Head = Head.Next;
                if (Head == null) // If the list is now empty
                {
                    Tail = null;
                }
            }
            else
            {
                Node1 current = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;

                if (current.Next == null) // If the last node was removed
                {
                    Tail = current;
                }
            }
            Count--;
        }

        // Search for a mobile phone by its ID
        public Node1 Search(string productID)
        {
            Node1 current = Head;

            while (current != null)
            {
                if (current.ProductID == productID)
                {
                    return current;
                }
                current = current.Next;
            }

            return null; // If not found
        }

        // Print all mobile phones in the list
        
        public void Stat_Print()
        {
            Node1 current = Head;

            // Define column widths
            int nameWidth = 25;
            int idWidth = 12;
            int priceWidth = 12;
            int processorWidth = 20;
            int ramWidth = 8;
            int storageWidth = 10;
            int batteryWidth = 15;
            int displayWidth = 20;
            int cameraWidth = 15;
            int conditionWidth = 10;

            // Top Border
            string topLine = $"┌{new string('─', nameWidth)}┬{new string('─', idWidth)}┬{new string('─', priceWidth)}┬{new string('─', processorWidth)}┬{new string('─', ramWidth)}┬{new string('─', storageWidth)}┬{new string('─', batteryWidth)}┬{new string('─', displayWidth)}┬{new string('─', cameraWidth)}┬{new string('─', conditionWidth)}┐";
            Console.WriteLine(topLine);

            // Headers
            Console.WriteLine($"│{"Product Name".PadRight(nameWidth)}│{"Product ID".PadRight(idWidth)}│{"Price (LKR)".PadRight(priceWidth)}│{"Processor".PadRight(processorWidth)}│{"RAM".PadRight(ramWidth)}│{"Storage".PadRight(storageWidth)}│{"Battery Life".PadRight(batteryWidth)}│{"Display".PadRight(displayWidth)}│{"Camera Quality".PadRight(cameraWidth)}│{"Condition".PadRight(conditionWidth)}│");

            // Mid Border
            string midLine = $"├{new string('─', nameWidth)}┼{new string('─', idWidth)}┼{new string('─', priceWidth)}┼{new string('─', processorWidth)}┼{new string('─', ramWidth)}┼{new string('─', storageWidth)}┼{new string('─', batteryWidth)}┼{new string('─', displayWidth)}┼{new string('─', cameraWidth)}┼{new string('─', conditionWidth)}┤";
            Console.WriteLine(midLine);

            // Table Rows
            while (current != null)
            {
                string name = current.ProductName.PadRight(nameWidth);
                string id = current.ProductID.PadRight(idWidth);
                string price = $"LKR{current.Price}".PadLeft(priceWidth);
                string processor = current.Processor.PadRight(processorWidth);
                string ram = current.RAM.PadRight(ramWidth);
                string storage = current.Storage.PadRight(storageWidth);
                string battery = $"{current.BatteryLife} hours".PadRight(batteryWidth);
                string display = current.Display.PadRight(displayWidth);
                string camera = current.CameraQuality.PadRight(cameraWidth);
                string condition = current.Condition.PadRight(conditionWidth);

                Console.WriteLine($"│{name}│{id}│{price}│{processor}│{ram}│{storage}│{battery}│{display}│{camera}│{condition}│");

                current = current.Next;
            }

            // Bottom Border
            string bottomLine = $"└{new string('─', nameWidth)}┴{new string('─', idWidth)}┴{new string('─', priceWidth)}┴{new string('─', processorWidth)}┴{new string('─', ramWidth)}┴{new string('─', storageWidth)}┴{new string('─', batteryWidth)}┴{new string('─', displayWidth)}┴{new string('─', cameraWidth)}┴{new string('─', conditionWidth)}┘";
            Console.WriteLine(bottomLine);
        }

        // Sort mobile phones by price using Bubble Sort
        public void BubbleSortByPrice()
        {
            if (Head == null || Head.Next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node1 current = Head;

                while (current.Next != null)
                {
                    if (current.Price > current.Next.Price)
                    {
                        // Swap data
                        SwapData(current, current.Next);
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        // Helper method to swap data between two nodes
        private void SwapData(Node1 node1, Node1 node2)
        {
            // Swap all properties
            string tempName = node1.ProductName;
            node1.ProductName = node2.ProductName;
            node2.ProductName = tempName;

            string tempID = node1.ProductID;
            node1.ProductID = node2.ProductID;
            node2.ProductID = tempID;

            double tempPrice = node1.Price;
            node1.Price = node2.Price;
            node2.Price = tempPrice;

            string tempProcessor = node1.Processor;
            node1.Processor = node2.Processor;
            node2.Processor = tempProcessor;

            string tempRAM = node1.RAM;
            node1.RAM = node2.RAM;
            node2.RAM = tempRAM;

            string tempStorage = node1.Storage;
            node1.Storage = node2.Storage;
            node2.Storage = tempStorage;

            double tempBatteryLife = node1.BatteryLife;
            node1.BatteryLife = node2.BatteryLife;
            node2.BatteryLife = tempBatteryLife;

            string tempDisplay = node1.Display;
            node1.Display = node2.Display;
            node2.Display = tempDisplay;

            string tempCameraQuality = node1.CameraQuality;
            node1.CameraQuality = node2.CameraQuality;
            node2.CameraQuality = tempCameraQuality;

            string tempCondition = node1.Condition;
            node1.Condition = node2.Condition;
            node2.Condition = tempCondition;
        }
        public void RemoveProductByID(string productID)
        {
            if (Head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            // If the product to remove is the head of the list
            if (Head.ProductID == productID)
            {
                Head = Head.Next;

                if (Head == null) // If the list is now empty
                {
                    Tail = null;
                }

                Count--;
                Console.WriteLine("Product removed successfully.");
                return;
            }

            // Otherwise, search for the product in the rest of the list
            Node1 current = Head;
            while (current.Next != null)
            {
                if (current.Next.ProductID == productID)
                {
                    // Product found, remove it
                    current.Next = current.Next.Next;

                    // If the product removed is the last one, update Tail
                    if (current.Next == null)
                    {
                        Tail = current;
                    }

                    Count--;
                    Console.WriteLine("Product removed successfully.");
                    return;
                }
                current = current.Next;
            }

            // If no product is found with the given ID
            Console.WriteLine("Product with the given ID not found.");
        }
        public void UpdateProductDetail(string productID)
        {
            Node1 current = Head;

            // Search for the product by its ID
            while (current != null)
            {
                if (current.ProductID == productID)
                {
                    // If the product is found, ask the user to update the details
                    Console.WriteLine("\n\n       Enter new details for the product:");

                    Console.Write("\n       Enter Product Name: ");
                    current.ProductName = Console.ReadLine();

                    Console.Write("\n       Enter Product Price: ");
                    current.Price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n       Enter Product's Processor: ");
                    current.Processor = Console.ReadLine();

                    Console.Write("\n       Enter Product's RAM: ");
                    current.RAM = Console.ReadLine();

                    Console.Write("\n       Enter Product's Storage: ");
                    current.Storage = Console.ReadLine();

                    Console.Write("\n       Enter Product's Battery Life (in hours): ");
                    current.BatteryLife = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\n       Enter Product's Display: ");
                    current.Display = Console.ReadLine();

                    Console.Write("\n       Enter Product's Camera Quality: ");
                    current.CameraQuality = Console.ReadLine();

                    Console.Write("\n       Enter Product's Condition (New, Refurbished, Booked): ");
                    current.Condition = Console.ReadLine();

                    Console.WriteLine("\n       Product details updated successfully.");
                    return; // Exit after updating the product
                }
                current = current.Next;
            }

            // If product was not found
            Console.WriteLine("\n       Product with the given ID not found.");
        }
        public void PrintBookedPhones()
        {
            Node1 current = Head;
            int bookedCount = 0;

            Console.WriteLine("\n       Booked Phones:");

            // Traverse the linked list
            while (current != null)
            {
                // Check if the phone is booked
                if (current.Condition == "Booked")
                {
                    bookedCount++; // Increment the count of booked phones

                    // Print the details of the booked phone
                    Console.WriteLine($"\n       Product {bookedCount}");
                    Console.WriteLine($"       Name: {current.ProductName}");
                    Console.WriteLine($"       ID: {current.ProductID}");
                    Console.WriteLine($"       Price: LKR{current.Price}");
                    Console.WriteLine($"       Processor: {current.Processor}");
                    Console.WriteLine($"       RAM: {current.RAM}");
                    Console.WriteLine($"       Storage: {current.Storage}");
                    Console.WriteLine($"       Battery Life: {current.BatteryLife} hours");
                    Console.WriteLine($"       Display: {current.Display}");
                    Console.WriteLine($"       Camera Quality: {current.CameraQuality}");
                    Console.WriteLine($"       Condition: {current.Condition}");
                }

                current = current.Next; // Move to the next node
            }

            // If no booked phones are found
            if (bookedCount == 0)
            {
                Console.WriteLine("\n       No booked phones found.");
            }
        }

        public void NameBubbleSort()
        {
            if (Head == null || Head.Next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                Node1 current = Head;
                while (current.Next != null)
                {
                    if (current.ProductName.CompareTo(current.Next.ProductName) > 0)
                    {
                        // Swap the product names, not Node1 objects
                        string tempProductName = current.ProductName;
                        current.ProductName = current.Next.ProductName;
                        current.Next.ProductName = tempProductName;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

    }
}