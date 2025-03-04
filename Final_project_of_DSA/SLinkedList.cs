using Final_project_of_DSA;
using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
public class SLinkedList
{
    public Node? Head { get; set; }
    public Node? Tail { get; set; }
    public int Count { get; set; }

    public SLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public void AddLast(string product_name, string product_ID, double price, string Category, string Processor, string RAM, string Storage, string GPU, string Display, double Warranty, string Condition, double BatteryLife)
    {
        Node temp = new Node(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);

        if (Tail == null) // Check if Tail is empty
        {
            Head = temp;
            Tail = temp;
            Count++;
        }
        else
        {
            Tail.Next = temp;
            Tail = temp;
            Count++;
        }
    }
    public void AddFront(string product_name, string product_ID, double price, string Category, string Processor, string RAM, string Storage, string GPU, string Display, double Warranty, string Condition, double BatteryLife)
    {
        Node temp = new Node(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);

        if (Head == null)//check head is empty
        {
            Head = temp;
            Tail = temp;
            Count++;
        }
        else
        {
            temp.Next = Head;
            Head = temp;
            Count++;
        }
    }
    public void AddIndex(string product_name, string product_ID, double price, string Category, string Processor, string RAM, string Storage, string GPU, string Display, double Warranty, string Condition, double BatteryLife, double index)//adding to the  index
    {
        Node NewNode = new Node(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);

        if (index < 0 || index > Count)
        {
            Console.WriteLine("invalid Index");
            return;
        }
        else if (index == 0)
        {
            AddFront(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);
            return;
        }

        else if (index == Count)
        {
            AddLast(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);
            return;
        }
        else
        {
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            NewNode.Next = current.Next;
            current.Next = NewNode;
            Count++;

        }
    }
    public void RemoveAt(int index)
    {
        if (index < 0 || index > Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        if (index == 0)
        {
            Head = Head.Next;

            if (Head == null)
            {
                Tail = null;

            }
            Count--;
        }
        else//deleting element at position
        {
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;

            }

            current.Next = (current.Next).Next;

            if (index == Count - 1)
            {
                Tail = current;
            }

            Count--;

        }


    }
    Node node;
    public Node Search(string ID)
    {

        Node current = Head;

        while (current != null)
        {
            if (current.product_ID == ID)
            {
                node = new Node(current.product_name, current.product_ID, current.Price, current.Category, current.Processor, current.RAM, current.Storage, current.GPU, current.Display, current.Warranty, current.Condition, current.BatteryLife);
                return node;

            }
            current = current.Next;
        }


        return null;

    }
   
   

    public void Stat_Print()
    {
        Node? current = Head;

        // Dictionary to store the count of laptops with the same details
        Dictionary<string, int> laptopCount = new Dictionary<string, int>();

        // Traverse the linked list
        while (current != null)
        {
            // Create a unique key for the laptop based on all its properties
            string key = $"{current.product_name}|{current.product_ID}|{current.Price}|{current.Category}|{current.Processor}|{current.RAM}|{current.Storage}|{current.GPU}|{current.Display}|{current.Warranty}|{current.BatteryLife}";

            // If the key is already in the dictionary, increment the count
            if (laptopCount.ContainsKey(key))
            {
                laptopCount[key]++;
            }
            // If the key is not in the dictionary, add it with a count of 1
            else
            {
                laptopCount[key] = 1;
            }

            current = current.Next;
        }

        // Define column widths
        int nameWidth = 25;
        int idWidth = 15;
        int priceWidth = 12;
        int categoryWidth = 10;
        int processorWidth = 18;
        int ramWidth = 6;
        int storageWidth = 10;
        int gpuWidth = 15;
        int displayWidth = 25;
        int warrantyWidth = 8;
        int batteryWidth = 20;
        int stockWidth = 8;

        // Top Border
        string topLine = $"┌{new string('─', nameWidth)}┬{new string('─', idWidth)}┬{new string('─', priceWidth)}┬{new string('─', categoryWidth)}┬{new string('─', processorWidth)}┬{new string('─', ramWidth)}┬{new string('─', storageWidth)}┬{new string('─', gpuWidth)}┬{new string('─', displayWidth)}┬{new string('─', warrantyWidth)}┬{new string('─', batteryWidth)}┬{new string('─', stockWidth)}┐";
        Console.WriteLine(topLine);

        // Headers
        Console.WriteLine($"│{"Product Name".PadRight(nameWidth)}│{"Product ID".PadRight(idWidth)}│{"Price (LKR)".PadRight(priceWidth)}│{"Category".PadRight(categoryWidth)}│{"Processor".PadRight(processorWidth)}│{"RAM".PadRight(ramWidth)}│{"Storage".PadRight(storageWidth)}│{"GPU".PadRight(gpuWidth)}│{"Display".PadRight(displayWidth)}│{"Warranty".PadRight(warrantyWidth)}│{"Battery Life".PadRight(batteryWidth)}│{"Stock".PadRight(stockWidth)}│");

        // Mid Border
        string midLine = $"├{new string('─', nameWidth)}┼{new string('─', idWidth)}┼{new string('─', priceWidth)}┼{new string('─', categoryWidth)}┼{new string('─', processorWidth)}┼{new string('─', ramWidth)}┼{new string('─', storageWidth)}┼{new string('─', gpuWidth)}┼{new string('─', displayWidth)}┼{new string('─', warrantyWidth)}┼{new string('─', batteryWidth)}┼{new string('─', stockWidth)}┤";
        Console.WriteLine(midLine);

        // Table Rows
        foreach (var entry in laptopCount)
        {
            string[] details = entry.Key.Split('|');
            string name = details[0].PadRight(nameWidth);
            string id = details[1].PadRight(idWidth);
            string price = details[2].PadLeft(priceWidth);
            string category = details[3].PadRight(categoryWidth);
            string processor = details[4].PadRight(processorWidth);
            string ram = details[5].PadRight(ramWidth);
            string storage = details[6].PadRight(storageWidth);
            string gpu = details[7].PadRight(gpuWidth);
            string display = details[8].PadRight(displayWidth);
            string warranty = details[9].PadRight(warrantyWidth);
            string battery = details[10].PadRight(batteryWidth);
            string stock = entry.Value.ToString().PadLeft(stockWidth);

            Console.WriteLine($"│{name}│{id}│{price}│{category}│{processor}│{ram}│{storage}│{gpu}│{display}│{warranty}│{battery}│{stock}│");
        }

        // Bottom Border
        string bottomLine = $"└{new string('─', nameWidth)}┴{new string('─', idWidth)}┴{new string('─', priceWidth)}┴{new string('─', categoryWidth)}┴{new string('─', processorWidth)}┴{new string('─', ramWidth)}┴{new string('─', storageWidth)}┴{new string('─', gpuWidth)}┴{new string('─', displayWidth)}┴{new string('─', warrantyWidth)}┴{new string('─', batteryWidth)}┴{new string('─', stockWidth)}┘";
        Console.WriteLine(bottomLine);
    }

     

    public void BubbleSortByPrice()
    {
        if (Head == null || Head.Next == null)
            return;

        bool swapped;
        Node current;
        Node previous = null;
        Node temp = null;

        // Start with the head node
        do
        {
            swapped = false;
            current = Head;

            while (current.Next != null)
            {
                if (current.Price > current.Next.Price)
                {
                    // Swap the data of the current node and the next node
                    SwapData(current, current.Next);
                    swapped = true;
                }

                current = current.Next; // Move to the next node
            }

        } while (swapped);
    }

    // Swap the data between two nodes
    private void SwapData(Node node1, Node node2)
    {
        string tempProductName = node1.product_name;
        node1.product_name = node2.product_name;
        node2.product_name = tempProductName;

        string tempProductID = node1.product_ID;
        node1.product_ID = node2.product_ID;
        node2.product_ID = tempProductID;

        double tempPrice = node1.Price;
        node1.Price = node2.Price;
        node2.Price = tempPrice;

        string tempCategory = node1.Category;
        node1.Category = node2.Category;
        node2.Category = tempCategory;

        string tempProcessor = node1.Processor;
        node1.Processor = node2.Processor;
        node2.Processor = tempProcessor;

        string tempRAM = node1.RAM;
        node1.RAM = node2.RAM;
        node2.RAM = tempRAM;

        string tempStorage = node1.Storage;
        node1.Storage = node2.Storage;
        node2.Storage = tempStorage;

        string tempGPU = node1.GPU;
        node1.GPU = node2.GPU;
        node2.GPU = tempGPU;

        string tempDisplay = node1.Display;
        node1.Display = node2.Display;
        node2.Display = tempDisplay;

        double tempWarranty = node1.Warranty;
        node1.Warranty = node2.Warranty;
        node2.Warranty = tempWarranty;

        string tempCondition = node1.Condition;
        node1.Condition = node2.Condition;
        node2.Condition = tempCondition;

        double tempBatteryLife = node1.BatteryLife;
        node1.BatteryLife = node2.BatteryLife;
        node2.BatteryLife = tempBatteryLife;
    }

    public void UpdateProductDetail(string product_ID)
    {
        Node current = Head;

        // Search for the product by its ID
        while (current != null)
        {
            if (current.product_ID == product_ID)
            {
                // If the product is found, ask the user to update the details

                Console.WriteLine("\n\n       Enter new details for the product:");

                Console.Write("\n       Enter Product Name: ");
                current.product_name = Console.ReadLine();

                Console.Write("\n       Enter Product Price: ");
                current.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n       Enter Product Category: ");
                current.Category = Console.ReadLine();

                Console.Write("\n       Enter Product Processor: ");
                current.Processor = Console.ReadLine();

                Console.Write("\n       Enter Product RAM: ");
                current.RAM = Console.ReadLine();

                Console.Write("\n       Enter Product Storage: ");
                current.Storage = Console.ReadLine();

                Console.Write("\n       Enter Product GPU: ");
                current.GPU = Console.ReadLine();

                Console.Write("\n       Enter Product Display: ");
                current.Display = Console.ReadLine();

                Console.Write("\n       Enter Product Warranty: ");
                current.Warranty = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n       Enter Product Condition: ");
                current.Condition = Console.ReadLine();

                Console.Write("\n       Enter Product Battery Life: ");
                current.BatteryLife = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n       Product details updated successfully.");
                return; // Exit after updating the product
            }
            current = current.Next;
        }

        // If product was not found
        Console.WriteLine("\n       Product with the given ID not found.");
    }


    public void RemoveProductByID(string product_ID)
    {
        if (Head == null)
        {
            Console.WriteLine("The list is empty.");
            return;
        }

        // If the product to remove is the head of the list
        if (Head.product_ID == product_ID)
        {
            Head = Head.Next;

            if (Head == null)
            {
                Tail = null;  // If the list is empty after removal, update Tail
            }

            Count--;
            Console.WriteLine("Product removed successfully.");
            return;
        }

        // Otherwise, search for the product in the rest of the list
        Node current = Head;
        while (current.Next != null)
        {
            if (current.Next.product_ID == product_ID)
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



    public void BookingLaptop(string product_ID)
    {
        Node current = Head;

        // Search for the product by its ID
        while (current != null)
        {
            if (current.product_ID == product_ID)
            {
                // If the product is found, check if it's already booked
                if (current.Condition == "Booked")
                {
                    Console.WriteLine("\n       This laptop is already booked.");
                }
                else
                {
                    // Mark the laptop as booked
                    current.Condition = "Booked";
                    Console.WriteLine("\n       Laptop booked successfully.");
                }
                return; // Exit after booking the laptop
            }
            current = current.Next;
        }
        

        // If product was not found
        Console.WriteLine("\n       Product with the given ID not found.");
    }

    public void CheckAvailableStockByProductID(string product_ID)
    {
        Node current = Head;
        int availableCount = 0;

        // Traverse the linked list
        while (current != null)
        {
            // Check if the product ID matches and the laptop is not booked
            if (current.product_ID == product_ID && current.Condition != "Booked")
            {
                availableCount++; // Increment the count of available laptops
            }
            current = current.Next;
        }

        // Display the result
        if (availableCount > 0)
        {
            Console.WriteLine($"\n       {availableCount} laptops with Product ID '{product_ID}' are available.");
        }
        
    }

    public void PrintBookedLaptops()
    {
        Node? current = Head;
        int bookedCount = 0;

        Console.WriteLine("\n       Booked Laptops:");

        // Traverse the linked list
        while (current != null)
        {
            // Check if the laptop is booked
            if (current.Condition == "Booked")
            {
                bookedCount++; // Increment the count of booked laptops

                // Print the details of the booked laptop
                Console.WriteLine($"\n       Product {bookedCount}");
                Console.Write($"\n       product_name : {current.product_name}");
                Console.Write($"\n       product_ID : {current.product_ID}");
                Console.Write($"\n       Category : {current.Category}");
                Console.Write($"\n       Processor :{current.Processor}");
                Console.Write($"\n       RAM:{current.RAM}");
                Console.Write($"\n       Storage : {current.Storage}");
                Console.Write($"\n       GPU  :{current.GPU}");
                Console.Write($"\n       Display :{current.Display}");
                Console.Write($"\n       Price : {current.Price}");
                Console.Write($"\n       Warranty : {current.Warranty}");
                Console.Write($"\n       Condition : {current.Condition}");
                Console.Write($"\n       BatteryLife  : {current.BatteryLife}\n");
            }

            current = current.Next;
        }

        // If no booked laptops are found
        if (bookedCount == 0)
        {
            Console.WriteLine("\n       No booked laptops found.");
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
            Node current = Head;
            while (current.Next != null)
            {
                if (current.product_name.CompareTo(current.Next.product_name) > 0)
                {
                    string tempName = current.product_name;
                    current.product_name = current.Next.product_name;
                    current.Next.product_name = tempName;
                    swapped = true;
                }
                current = current.Next;
            }
        } while (swapped);
    }
    public void BubbleSortByProcessor()
    {
        if (Head == null || Head.Next == null)
            return;

        bool swapped;
        do
        {
            swapped = false;
            Node current = Head;
            Node previous = null;

            while (current.Next != null)
            {
                if (GetProcessorPriority(current.Processor) > GetProcessorPriority(current.Next.Processor))
                {
                    // Swap nodes
                    Node next = current.Next;
                    current.Next = next.Next;
                    next.Next = current;

                    if (previous == null)
                    {
                        Head = next;
                    }
                    else
                    {
                        previous.Next = next;
                    }

                    previous = next;
                    swapped = true;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }
        } while (swapped);
    }

    private int GetProcessorPriority(string processor)
    {
        if (processor.Contains("i3")) return 1;
        if (processor.Contains("i5")) return 2;
        if (processor.Contains("i7")) return 3;
        return 0; // For unknown processors
    }

    public void Display()
    {
        Node temp = Head;
        while (temp != null)
        {
            Console.WriteLine(temp.product_name);
            temp = temp.Next;
        }
    }


    private Node GetLastNode(Node node)
    {
        while (node != null && node.Next != null)
        {
            node = node.Next;
        }
        return node;
    }

    // Helper function to get the tail node of the linked list
    private Node GetTail(Node node)
    {
        while (node != null && node.Next != null)
            node = node.Next;
        return node;
    }

    // Partition function to rearrange the linked list based on the pivot
    private Node Partition(Node head, Node tail, ref Node newHead, ref Node newTail)
    {
        Node pivot = tail;
        Node prev = null, curr = head, last = pivot;

        while (curr != pivot)
        {
            if (curr.Price < pivot.Price)
            {
                if (newHead == null)
                    newHead = curr;
                prev = curr;
                curr = curr.Next;
            }
            else
            {
                if (prev != null)
                    prev.Next = curr.Next;

                Node temp = curr.Next;
                curr.Next = null;
                last.Next = curr;
                last = curr;
                curr = temp;
            }
        }

        if (newHead == null)
            newHead = pivot;

        newTail = last;
        return pivot;
    }

    // QuickSort function for linked list
    private Node QuickSort(Node head, Node tail)
    {
        if (head == null || head == tail)
            return head;

        Node newHead = null, newTail = null;
        Node pivot = Partition(head, tail, ref newHead, ref newTail);

        // Sort left part before pivot
        if (newHead != pivot)
        {
            Node temp = newHead;
            while (temp.Next != pivot)
                temp = temp.Next;
            temp.Next = null;

            newHead = QuickSort(newHead, temp);

            // Reconnect pivot
            temp = GetTail(newHead);
            temp.Next = pivot;
        }

        // Sort right part after pivot
        pivot.Next = QuickSort(pivot.Next, newTail);

        return newHead;
    }

    public void QuickSortByPrice()
    {
        Head = QuickSort(Head, GetTail(Head));
    }
    //price merging 
    // MergeSort method
    public void MergeSort()
    {
        Head = MergeSort(Head); // Call the recursive MergeSort method
    }

    // Recursive MergeSort method
    private Node MergeSort(Node head)
    {
        // Base case: if the list is empty or has only one node
        if (head == null || head.Next == null)
            return head;

        // Split the list into two halves
        Node middle = GetMiddle(head); // Find the middle node
        Node nextToMiddle = middle.Next; // Start of the second half
        middle.Next = null; // Split the list into two parts

        // Recursively sort both halves
        Node left = MergeSort(head); // Sort the left half
        Node right = MergeSort(nextToMiddle); // Sort the right half

        // Merge the two sorted halves
        return Merge(left, right);
    }

    // Helper method to find the middle node of the linked list
    private Node GetMiddle(Node head)
    {
        if (head == null)
            return head;

        Node slow = head; // Moves one step at a time
        Node fast = head.Next; // Moves two steps at a time

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow; // Middle node
    }

    // Helper method to merge two sorted linked lists
    private Node Merge(Node left, Node right)
    {
        if (left == null)
            return right;
        if (right == null)
            return left;

        Node result;

        // Choose the smaller value as the head of the merged list
        if (left.Price <= right.Price)
        {
            result = left;
            result.Next = Merge(left.Next, right); // Recursively merge the rest
        }
        else
        {
            result = right;
            result.Next = Merge(left, right.Next); // Recursively merge the rest
        }

        return result;
    }

   
    // MergeSort method for sorting by product_name
    public void NameMergeSort()
    {
        Head = NameMergeSort(Head); // Call the recursive MergeSort method
    }

    // Recursive MergeSort method for sorting by product_name
    private Node NameMergeSort(Node head)
    {
        // Base case: if the list is empty or has only one node
        if (head == null || head.Next == null)
            return head;

        // Split the list into two halves
        Node middle = GetMiddle1(head); // Find the middle node
        Node nextToMiddle = middle.Next; // Start of the second half
        middle.Next = null; // Split the list into two parts

        // Recursively sort both halves
        Node left = NameMergeSort(head); // Sort the left half
        Node right = NameMergeSort(nextToMiddle); // Sort the right half

        // Merge the two sorted halves
        return MergeByName(left, right);
    }

    // Helper method to find the middle node of the linked list
    private Node GetMiddle1(Node head)
    {
        if (head == null)
            return head;

        Node slow = head; // Moves one step at a time
        Node fast = head.Next; // Moves two steps at a time

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }

        return slow; // Middle node
    }

    // Helper method to merge two sorted linked lists by product_name
    private Node MergeByName(Node left, Node right)
    {
        if (left == null)
            return right;
        if (right == null)
            return left;

        Node result;

        // Compare product_name and choose the smaller one
        if (string.Compare(left.product_name, right.product_name, StringComparison.Ordinal) <= 0)
        {
            result = left;
            result.Next = MergeByName(left.Next, right); // Recursively merge the rest
        }
        else
        {
            result = right;
            result.Next = MergeByName(left, right.Next); // Recursively merge the rest
        }

        return result;
    }
    //Quick sort product name
    // Helper method to get the last node of the linked list
    private Node GetLastNode0(Node node)
    {
        while (node != null && node.Next != null)
        {
            node = node.Next;
        }
        return node;
    }

    // Partition method for Quick Sort (based on product_name)
    private Node Partition0(Node low, Node high, ref Node newLow, ref Node newHigh)
    {
        Node pivot = high; // Choose the last node as the pivot
        Node smallerHead = null; // Head of the list with nodes smaller than the pivot
        Node smallerTail = null; // Tail of the list with nodes smaller than the pivot
        Node greaterHead = null; // Head of the list with nodes greater than or equal to the pivot
        Node greaterTail = null; // Tail of the list with nodes greater than or equal to the pivot

        Node current = low;

        while (current != pivot)
        {
            // Compare product_name values
            if (string.Compare(current.product_name, pivot.product_name, StringComparison.Ordinal) < 0)
            {
                // Add current node to the smaller list
                if (smallerHead == null)
                {
                    smallerHead = current;
                    smallerTail = current;
                }
                else
                {
                    smallerTail.Next = current;
                    smallerTail = current;
                }
            }
            else
            {
                // Add current node to the greater list
                if (greaterHead == null)
                {
                    greaterHead = current;
                    greaterTail = current;
                }
                else
                {
                    greaterTail.Next = current;
                    greaterTail = current;
                }
            }
            current = current.Next;
        }

        // Connect the smaller list, pivot, and greater list
        if (smallerTail != null)
        {
            smallerTail.Next = pivot;
        }
        pivot.Next = greaterHead;

        // Update newLow and newHigh
        newLow = smallerHead ?? pivot; // If smallerHead is null, pivot is the smallest element
        newHigh = greaterTail ?? pivot; // If greaterTail is null, pivot is the largest element

        return pivot;
    }

    // Recursive Quick Sort method
    private Node QuickSort0(Node low, Node high)
    {
        if (low == null || low == high)
        {
            return low;
        }

        Node newLow = null;
        Node newHigh = null;

        // Partition the list
        Node pivot = Partition0(low, high, ref newLow, ref newHigh);

        // If pivot is not the smallest element, recursively sort the left sublist
        if (newLow != pivot)
        {
            Node temp = newLow;
            while (temp.Next != pivot)
            {
                temp = temp.Next;
            }
            temp.Next = null; // Disconnect the left sublist from the pivot

            newLow = QuickSort0(newLow, temp);

            // Reconnect the sorted left sublist to the pivot
            temp = GetLastNode0(newLow);
            temp.Next = pivot;
        }

        // Recursively sort the right sublist
        pivot.Next = QuickSort0(pivot.Next, newHigh);

        return newLow;
    }

    // Public method to start Quick Sort (by product_name)
    public void QuickSortByName()
    {
        Node lastNode = GetLastNode0(Head);
        Head = QuickSort0(Head, lastNode);
    }

    // Helper method to print the linked list
    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine($"Product: {current.product_name}, Price: {current.Price}");
            current = current.Next;
        }
    }
    // merge sort for processor 
    

        // MergeSort method for sorting by Processor
        public void MergeSortByProcessor()
        {
            Head = MergeSortByProcessor(Head); // Call the recursive MergeSort method
        }

        // Recursive MergeSort method for sorting by Processor
        private Node MergeSortByProcessor(Node head)
        {
            // Base case: if the list is empty or has only one node
            if (head == null || head.Next == null)
                return head;

            // Split the list into two halves
            Node middle = GetMiddle00(head); // Find the middle node
            Node nextToMiddle = middle.Next; // Start of the second half
            middle.Next = null; // Split the list into two parts

            // Recursively sort both halves
            Node left = MergeSortByProcessor(head); // Sort the left half
            Node right = MergeSortByProcessor(nextToMiddle); // Sort the right half

            // Merge the two sorted halves
            return MergeByProcessor(left, right);
        }

        // Helper method to find the middle node of the linked list
        private Node GetMiddle00(Node head)
        {
            if (head == null)
                return head;

            Node slow = head; // Moves one step at a time
            Node fast = head.Next; // Moves two steps at a time

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow; // Middle node
        }

        // Helper method to merge two sorted linked lists by Processor
        private Node MergeByProcessor(Node left, Node right)
        {
            if (left == null)
                return right;
            if (right == null)
                return left;

            Node result;

            // Compare Processor priority and choose the smaller one
            if (GetProcessorPriority00(left.Processor) <= GetProcessorPriority00(right.Processor))
            {
                result = left;
                result.Next = MergeByProcessor(left.Next, right); // Recursively merge the rest
            }
            else
            {
                result = right;
                result.Next = MergeByProcessor(left, right.Next); // Recursively merge the rest
            }

            return result;
        }

        // Helper method to get the priority of a processor
        private int GetProcessorPriority00(string processor)
        {
            if (processor.Contains("i3")) return 1;
            if (processor.Contains("i5")) return 2;
            if (processor.Contains("i7")) return 3;
            return 0; // For unknown processors
        }



    }





