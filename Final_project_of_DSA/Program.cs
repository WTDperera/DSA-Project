using Final_project_of_DSA;
using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

SLinkedList list = new SLinkedList();
BST tree = new BST();
string select0;
string select1; // 1st operation
string select2 = "H";
string select3;
double IndexValu;
string select4 = "BH";
string select5 = "H"; // For "Back to Home" functionality


SPhones phoneList = new SPhones();

string select10, select20, select30, select40 = "MD";
int indexValue;


// Sample Laptops data to add to the list
//add last
list.AddLast("Dell XPS 13", "DXPS13-001", 450000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "13.4\" FHD+ Touchscreen", 12, "New", 12);
list.AddFront("HP Spectre x360", "HPSPX360-002", 550000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "13.5\" OLED Touchscreen", 12, "New", 15);
list.AddLast("Lenovo ThinkPad X1 Carbon", "LTX1C-003", 600000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD+", 24, "New", 12);
list.AddLast("Acer Predator Helios 300", "APHP300-004", 500000, "Laptop", "Intel i7-11800H", "16GB", "512GB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
// add front
list.AddFront("Razer Blade 15", "RB15-005", 750000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "15.6\" QHD", 12, "New", 9);
list.AddFront("LG Gram 17", "LGG17-006", 650000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "17\" WQXGA", 12, "New", 7);
list.AddFront("MSI GS66 Stealth", "MSIGS66-007", 700000, "Laptop", "Intel i7-11800H", "32GB", "1TB SSD", "NVIDIA RTX 3080", "15.6\" FHD", 12, "New", 6);
list.AddFront("Dell Inspiron 15", "DI15-008", 350000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 8, "New", 14);
list.AddFront("HP Pavilion 14", "HPP14-009", 400000, "Laptop", "Intel i5-1235U", "8GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 10, "New", 13);
//add last
list.AddLast("Lenovo IdeaPad 3", "LIP3-010", 300000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "15.6\" HD", 7, "New", 20);
list.AddLast("Dell Vostro 3400", "DV3400-011", 280000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "14\" HD", 6, "New", 25);
list.AddLast("HP Envy x360", "HPENVX360-012", 420000, "Laptop", "Intel i5-1235U", "8GB", "512GB SSD", "Intel Iris Xe", "13.3\" FHD Touchscreen", 12, "New", 10);
list.AddLast("Lenovo Yoga 7i", "LY7I-013", 470000, "Laptop", "Intel i7-1255U", "16GB", "1TB SSD", "Intel Iris Xe", "14\" FHD+ Touch", 12, "New", 8);
list.AddLast("Acer Aspire 5", "AA5-014", 320000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 8, "New", 12);
list.AddLast("MSI Modern 14", "MSI14-015", 450000, "Laptop", "Intel i5-1240P", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 10, "New", 9);
list.AddLast("Asus ZenBook 14", "AZB14-016", 500000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "14\" OLED", 12, "New", 8);
list.AddLast("Dell Latitude 5420", "DL5420-017", 530000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 10);
list.AddLast("HP EliteBook 840 G8", "HPEB840-018", 550000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 7);
list.AddLast("Lenovo ThinkBook 15", "LTB15-019", 410000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 10, "New", 15);
list.AddLast("Asus VivoBook 15", "AVB15-020", 300000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "15.6\" FHD", 6, "New", 20);
list.AddLast("Dell G15 Gaming", "DG15-021", 520000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
list.AddLast("HP Omen 16", "HPO16-022", 750000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "16.1\" QHD", 12, "New", 5);
list.AddLast("Lenovo Legion 5i", "LL5I-023", 580000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 9);
list.AddLast("Acer Swift 3", "AS3-024", 340000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 8, "New", 11);
list.AddLast("MSI Prestige 14", "MSIP14-025", 600000, "Laptop", "Intel i7-1185G7", "16GB", "1TB SSD", "Intel Iris Xe", "14\" 4K UHD", 12, "New", 7);
list.AddLast("Asus ExpertBook B9", "AEB9-026", 480000, "Laptop", "Intel i7-1255U", "16GB", "1TB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 10);
list.AddLast("Dell Precision 3560", "DP3560-027", 670000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "15.6\" FHD", 12, "New", 6);
list.AddLast("HP ZBook Firefly 15", "HPZB15-028", 750000, "Laptop", "Intel i7-1165G7", "32GB", "1TB SSD", "NVIDIA T500", "15.6\" FHD", 12, "New", 5);
list.AddLast("Dell XPS 13", "DXPS13-001", 450000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "13.4\" FHD+ Touchscreen", 12, "New", 12);
list.AddLast("HP Spectre x360", "HPSPX360-002", 550000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "13.5\" OLED Touchscreen", 12, "New", 15);
list.AddLast("Lenovo ThinkPad X1 Carbon", "LTX1C-003", 600000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD+", 24, "New", 12);
list.AddLast("Acer Predator Helios 300", "APHP300-004", 500000, "Laptop", "Intel i7-11800H", "16GB", "512GB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
list.AddLast("Razer Blade 15", "RB15-005", 750000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "15.6\" QHD", 12, "New", 9);
list.AddLast("Lenovo ThinkBook 15", "LTB15-019", 410000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 10, "New", 15);
list.AddLast("Asus VivoBook 15", "AVB15-020", 300000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "15.6\" FHD", 6, "New", 20);
list.AddLast("Dell G15 Gaming", "DG15-021", 520000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
list.AddLast("HP Omen 16", "HPO16-022", 750000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "16.1\" QHD", 12, "New", 5);
list.AddLast("Lenovo Legion 5i", "LL5I-023", 580000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 9);
list.AddLast("Acer Swift 3", "AS3-024", 340000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 8, "New", 11);
list.AddLast("MSI Prestige 14", "MSIP14-025", 600000, "Laptop", "Intel i7-1185G7", "16GB", "1TB SSD", "Intel Iris Xe", "14\" 4K UHD", 12, "New", 7);
list.AddLast("Asus ExpertBook B9", "AEB9-026", 480000, "Laptop", "Intel i7-1255U", "16GB", "1TB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 10);
list.AddLast("Dell Precision 3560", "DP3560-027", 670000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "15.6\" FHD", 12, "New", 6);
list.AddLast("HP ZBook Firefly 15", "HPZB15-028", 750000, "Laptop", "Intel i7-1165G7", "32GB", "1TB SSD", "NVIDIA T500", "15.6\" FHD", 12, "New", 5);
list.AddLast("Dell XPS 13", "DXPS13-001", 450000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "13.4\" FHD+ Touchscreen", 12, "New", 12);
list.AddLast("HP Spectre x360", "HPSPX360-002", 550000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "13.5\" OLED Touchscreen", 12, "New", 15);
list.AddLast("Lenovo ThinkPad X1 Carbon", "LTX1C-003", 600000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD+", 24, "New", 12);

//laptops data to tree
tree.Insert("Dell XPS 13", "DXPS13-001", 450000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "13.4\" FHD+ Touchscreen", 12, "New", 12);
tree.Insert("HP Spectre x360", "HPSPX360-002", 550000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "13.5\" OLED Touchscreen", 12, "New", 15);
tree.Insert("Lenovo ThinkPad X1 Carbon", "LTX1C-003", 600000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD+", 24, "New", 12);
tree.Insert("Acer Predator Helios 300", "APHP300-004", 500000, "Laptop", "Intel i7-11800H", "16GB", "512GB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
tree.Insert("Razer Blade 15", "RB15-005", 750000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "15.6\" QHD", 12, "New", 9);
tree.Insert("LG Gram 17", "LGG17-006", 650000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "17\" WQXGA", 12, "New", 7);
tree.Insert("MSI GS66 Stealth", "MSIGS66-007", 700000, "Laptop", "Intel i7-11800H", "32GB", "1TB SSD", "NVIDIA RTX 3080", "15.6\" FHD", 12, "New", 6);
tree.Insert("Dell Inspiron 15", "DI15-008", 350000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 8, "New", 14);
tree.Insert("HP Pavilion 14", "HPP14-009", 400000, "Laptop", "Intel i5-1235U", "8GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 10, "New", 13);
tree.Insert("Lenovo IdeaPad 3", "LIP3-010", 300000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "15.6\" HD", 7, "New", 20);
tree.Insert("Dell Vostro 3400", "DV3400-011", 280000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "14\" HD", 6, "New", 25);
tree.Insert("HP Envy x360", "HPENVX360-012", 420000, "Laptop", "Intel i5-1235U", "8GB", "512GB SSD", "Intel Iris Xe", "13.3\" FHD Touchscreen", 12, "New", 10);
tree.Insert("Lenovo Yoga 7i", "LY7I-013", 470000, "Laptop", "Intel i7-1255U", "16GB", "1TB SSD", "Intel Iris Xe", "14\" FHD+ Touch", 12, "New", 8);
tree.Insert("Acer Aspire 5", "AA5-014", 320000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 8, "New", 12);
tree.Insert("MSI Modern 14", "MSI14-015", 450000, "Laptop", "Intel i5-1240P", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 10, "New", 9);
tree.Insert("Asus ZenBook 14", "AZB14-016", 500000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "14\" OLED", 12, "New", 8);
tree.Insert("Dell Latitude 5420", "DL5420-017", 530000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 10);
tree.Insert("HP EliteBook 840 G8", "HPEB840-018", 550000, "Laptop", "Intel i7-1185G7", "16GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 7);
tree.Insert("Lenovo ThinkBook 15", "LTB15-019", 410000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "15.6\" FHD", 10, "New", 15);
tree.Insert("Asus VivoBook 15", "AVB15-020", 300000, "Laptop", "Intel i3-1115G4", "8GB", "256GB SSD", "Intel UHD", "15.6\" FHD", 6, "New", 20);
tree.Insert("Dell G15 Gaming", "DG15-021", 520000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 8);
tree.Insert("HP Omen 16", "HPO2216-0", 750000, "Laptop", "Intel i7-12700H", "16GB", "1TB SSD", "NVIDIA RTX 3070", "16.1\" QHD", 12, "New", 5);
tree.Insert("Lenovo Legion 5i", "LL5I-023", 580000, "Laptop", "Intel i7-11800H", "16GB", "1TB SSD", "NVIDIA RTX 3060", "15.6\" FHD", 12, "New", 9);
tree.Insert("Acer Swift 3", "AS3-024", 340000, "Laptop", "Intel i5-1135G7", "8GB", "512GB SSD", "Intel Iris Xe", "14\" FHD", 8, "New", 11);
tree.Insert("MSI Prestige 14", "MSIP14-025", 600000, "Laptop", "Intel i7-1185G7", "16GB", "1TB SSD", "Intel Iris Xe", "14\" 4K UHD", 12, "New", 7);
tree.Insert("Asus ExpertBook B9", "AEB9-026", 480000, "Laptop", "Intel i7-1255U", "16GB", "1TB SSD", "Intel Iris Xe", "14\" FHD", 12, "New", 10);
tree.Insert("Dell Precision 3560", "DP3560-027", 670000, "Laptop", "Intel i7-1165G7", "16GB", "1TB SSD", "Intel Iris Xe", "15.6\" FHD", 12, "New", 6);
tree.Insert("HP ZBook Firefly 15", "HPZB15-028", 750000, "Laptop", "Intel i7-1165G7", "32GB", "1TB SSD", "NVIDIA T500", "15.6\" FHD", 12, "New", 5);


// Add some phones
phoneList.AddLast1("Samsung Galaxy M35 5G", "P001", 85000.00, "Exynos 1380", "6GB", "128GB", 24, "6.6\" FHD+ 120Hz", "50MP", "Available");
phoneList.AddLast1("Tecno Camon 19 Pro", "P002", 75000.00, "Helio G96", "8GB", "256GB", 30, "6.8\" FHD+", "64MP", "Available");
phoneList.AddLast1("Oppo F5", "P003", 50000.00, "Octa-core 2.5GHz", "4GB", "32GB", 20, "6.0\" FHD+", "16MP", "Available");
phoneList.AddLast1("Honor 60 Pro", "P004", 120000.00, "Snapdragon 778G+", "8GB", "256GB", 35, "6.78\" OLED 120Hz", "108MP", "Available");
phoneList.AddLast1("Samsung Galaxy M55 5G", "P005", 95000.00, "Snapdragon 7 Gen 1", "8GB", "128GB", 28, "6.7\" FHD+ 120Hz", "50MP", "Available");



Console.WriteLine("   INVENTORY MANAGEMENT SYSTEM");

do
{
    Console.WriteLine("    \nLogin");
    Console.WriteLine("    \nAdmin - Com \t\t Customer -User");

    select0 = Console.ReadLine();
    
    if (select0 == "Com")
    {
        Console.WriteLine("\n    Enter passWord : ");
        string password = "1234";
        string select_password = Console.ReadLine();
       
        
        //Admin
        if (select_password == "1234")
        {
            Console.WriteLine("\nWhat you want to consider ? ");
            Console.WriteLine("\n 1 - Laptop");
            Console.WriteLine("\n 2 - Mobile Phones ");
            Console.WriteLine();
            //int n1 = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int n1;
            
            if (int.TryParse(input, out n1))
            {
                //laptops
                if (n1 == 1)
                {
                    do
                    {
                        Console.WriteLine("   LAPTOP INVENTORY MANAGEMENT SYSTEM");
                        Console.WriteLine("\n       Add a new product = A\n       Search product detail = S\n       Update product detail = U\n       Remove product = R\n       Print booked laptops = PB\n       Dispaly All product = D\n       Filter products = F\n       Quit = Q\n");
                        select1 = Console.ReadLine();

                        switch (select1)
                        {
                            //add product
                            case "A":
                                {
                                    do
                                    {
                                        Console.WriteLine("\n       Where do you want to add product details?");
                                        Console.WriteLine("\n       Add front  : AF");
                                        Console.WriteLine("       Add Last  : AL");
                                        Console.WriteLine("       Add a new product to your desired index  : AIN\n");

                                        select3 = Console.ReadLine();

                                        string product_name;
                                        string product_ID;
                                        double price;
                                        string Category;
                                        string Processor;
                                        string RAM;
                                        string Storage;
                                        string GPU;
                                        string Display;
                                        double Warranty;
                                        string Condition;
                                        double BatteryLife;

                                        Console.Write("\n       Enter Product Name : "); product_name = Console.ReadLine();
                                        Console.Write("\n       Enter product_ID : "); product_ID = Console.ReadLine();
                                        Console.Write("\n       Enter Product price : "); price = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("\n       Enter Product's Category  (e.g., gaming, business, ultrabook) : "); Category = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Processor : "); Processor = Console.ReadLine();
                                        Console.Write("\n       Enter Product's RAM : "); RAM = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Storage : "); Storage = Console.ReadLine();
                                        Console.Write("\n       Enter Product's  GPU : "); GPU = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Display : "); Display = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Warranty in Month : "); Warranty = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("\n       Enter Product's Condition; : "); Condition = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Battery life in hours : "); BatteryLife = Convert.ToDouble(Console.ReadLine());

                                        //add last
                                        if (select3 == "AL")
                                        {
                                            list.AddLast(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);
                                        }
                                        
                                        //add last
                                        else if (select3 == "AF")
                                        {
                                            list.AddFront(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife);
                                        }

                                        //add index
                                        else if (select3 == "AIN")
                                        {
                                            Console.Write("\n       Enter index :");
                                            IndexValu = Convert.ToInt32(Console.ReadLine());
                                            list.AddIndex(product_name, product_ID, price, Category, Processor, RAM, Storage, GPU, Display, Warranty, Condition, BatteryLife, IndexValu);
                                        }

                                        Console.WriteLine("\n       ADD MORE PRODUCT = M\t BACK TO HOME = H\n");
                                        select2 = Console.ReadLine();

                                    } while (select2 == "M");
                                    break;
                                }
                            //display 
                            case "D":
                                list.Stat_Print();
                                break;
                            
                                //remove
                            case "R":
                                {
                                    do
                                    {
                                        Console.WriteLine("\n\n       Remove product by using ID : RID");
                                        Console.WriteLine("\n       Remove product by using Index : RIN");
                                        string getKey = Console.ReadLine();

                                        if (getKey == "RIN")
                                        {
                                            Console.Write("\n\n       Enter Remove Product's Index : ");
                                            int index = Convert.ToInt32(Console.ReadLine());
                                            list.RemoveAt(index);

                                            Console.WriteLine("\n       DELETE MORE PRODUCT = MD\t BACK TO HOME = BH\n");
                                            select4 = Console.ReadLine();
                                        }
                                        else if (getKey == "RID")
                                        {
                                            Console.Write("\n\n       Enter the Product ID to remove: ");
                                            string productID = Console.ReadLine();
                                            list.RemoveProductByID(productID);

                                            Console.WriteLine("\n       DELETE MORE PRODUCT = MD\t BACK TO HOME = BH\n");
                                            select4 = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\n       Enter correct Key ");
                                        }
                                    } while (select4 == "MD");
                                    break;
                                }
                            
                                //search
                            case "S":
                                {
                                    Console.WriteLine("\n       Enter the Product ID :  "); string id = Console.ReadLine();
                                    Console.WriteLine("\n       1.From Tree \t 2.From Link List ");
                                    int a = Convert.ToInt32(Console.ReadLine());


                                    if (a == 1)
                                    {
                                        Stopwatch sw = Stopwatch.StartNew();
                                        sw.Reset();
                                        sw.Start();
                                        Tree? result = tree.Search(id);
                                        sw.Stop();
                                        if (result != null)
                                        {
                                            Console.WriteLine("\nProduct Found:");
                                            Console.WriteLine("-----------------------------------------------------------");
                                            Console.WriteLine($"Product Name   : {result.product_name}");
                                            Console.WriteLine($"Product ID     : {result.product_ID}");
                                            Console.WriteLine($"Price (LKR)    : {result.Price}");
                                            Console.WriteLine($"Category       : {result.Category}");
                                            Console.WriteLine($"Processor      : {result.Processor}");
                                            Console.WriteLine($"RAM            : {result.RAM}");
                                            Console.WriteLine($"Storage        : {result.Storage}");
                                            Console.WriteLine($"GPU            : {result.GPU}");
                                            Console.WriteLine($"Display        : {result.Display}");
                                            Console.WriteLine($"Warranty       : {result.Warranty} years");
                                            Console.WriteLine($"Condition      : {result.Condition}");
                                            Console.WriteLine($"Battery Life   : {result.BatteryLife} hours");
                                            Console.WriteLine("-----------------------------------------------------------");// Call the Print() method of Tree to print the details

                                            Console.WriteLine($"Search  Time of Tree: {sw.Elapsed.TotalNanoseconds} ns");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n       Product not found.");
                                        }
                                    }
                                    else if(a == 2)
                                    {
                                        Stopwatch sw = Stopwatch.StartNew();
                                        sw.Reset();
                                        sw.Start();
                                        Node foundNode = list.Search(id);
                                        sw.Stop();
                                        if (foundNode != null)
                                        {
                                            Console.WriteLine("\nProduct Found:");
                                            Console.WriteLine("-----------------------------------------------------------");
                                            Console.WriteLine($"Product Name   : {foundNode.product_name}");
                                            Console.WriteLine($"Product ID     : {foundNode.product_ID}");
                                            Console.WriteLine($"Price (LKR)    : {foundNode.Price}");
                                            Console.WriteLine($"Category       : {foundNode.Category}");
                                            Console.WriteLine($"Processor      : {foundNode.Processor}");
                                            Console.WriteLine($"RAM            : {foundNode.RAM}");
                                            Console.WriteLine($"Storage        : {foundNode.Storage}");
                                            Console.WriteLine($"GPU            : {foundNode.GPU}");
                                            Console.WriteLine($"Display        : {foundNode.Display}");
                                            Console.WriteLine($"Warranty       : {foundNode.Warranty} years");
                                            Console.WriteLine($"Condition      : {foundNode.Condition}");
                                            Console.WriteLine($"Battery Life   : {foundNode.BatteryLife} hours");
                                            Console.WriteLine("-----------------------------------------------------------");// Call the Print() method of Tree to print the details

                                            Console.WriteLine($"Search  Time of Link list: {sw.Elapsed.TotalNanoseconds} ns");
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n       Product not found.");
                                        }

                                    }
                                    

                                    // Output the result

                                    break;
                                }


                            //update
                            case "U":
                                {
                                    Console.Write("\n\n       Enter the Product ID to update: ");
                                    string productID = Console.ReadLine();
                                    list.UpdateProductDetail(productID);
                                    break;
                                }
                            
                                //Print book laptops
                            case "PB":
                                {
                                    list.PrintBookedLaptops();
                                    break;
                                }
                            
                                //filter
                            case "F":
                                {

                                    Console.WriteLine("\n       Filter");
                                    Console.WriteLine("\n        1.Product Name");
                                    Console.WriteLine("\n        2.Product Price");
                                    Console.WriteLine("\n        3.Product Processer");

                                    int n = Convert.ToInt32(Console.ReadLine());
                                   
                                    //product name sorting
                                    if (n == 1)
                                    {
                                        Console.WriteLine("\n       What Metthod ?");
                                        Console.WriteLine("\n        1.Bubble Sort");
                                        Console.WriteLine("\n        2.Merge Sort.");
                                        
                                        int nn = Convert.ToInt32(Console.ReadLine());
                                        if (nn == 1)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //bubblesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            list.NameBubbleSort();
                                            stopwatch.Stop();


                                            list.Stat_Print();
                                            Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                        }
                                        else if (nn == 2)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //mergesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            list.NameMergeSort();
                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                        }

                                        else if (nn == 3)
                                        {

                                            Stopwatch stopwatch = new Stopwatch();

                                            //Quicksort
                                            stopwatch.Reset();
                                            stopwatch.Start();

                                            list.QuickSortByName();
                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                        }


                                    }

                                    //product price sorting
                                    else if (n == 2)
                                    {
                                        Console.WriteLine("\n       What Metthod ?");
                                        Console.WriteLine("\n        1.Bubble Sort");
                                        Console.WriteLine("\n        2.Merge Sort.");
                                        Console.WriteLine("\n        3.Quick Sort");
                                        int nn = Convert.ToInt32(Console.ReadLine());
                                        if (nn == 1)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //bubblesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            list.NameBubbleSort();
                                            stopwatch.Stop();


                                            list.Stat_Print();
                                            Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                        }
                                        else if (nn == 2)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //mergesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            list.MergeSort();
                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                        }

                                        else if (nn == 3)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //Quicksort
                                            stopwatch.Reset();
                                            stopwatch.Start();

                                            list.QuickSortByPrice();
                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                        }




                                    }

                                    //sort processr(i3,i5,i7)
                                    else if (n == 3)
                                    {
                                        Console.WriteLine("\n       What Metthod ?");
                                        Console.WriteLine("\n        1.Bubble Sort");
                                        Console.WriteLine("\n        2.Merge Sort.");
                                        //Console.WriteLine("\n        3.Quick Sort");
                                        int nn = Convert.ToInt32(Console.ReadLine());
                                        if (nn == 1)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //bubblesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            list.BubbleSortByProcessor();
                                            stopwatch.Stop();


                                            list.Stat_Print();
                                            Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                        }
                                        else if (nn == 2)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //mergesort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            //list.MergeSortByProcessor();
                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                        }

                                        else if (nn == 3)
                                        {
                                            Stopwatch stopwatch = new Stopwatch();

                                            //Quicksort
                                            stopwatch.Reset();
                                            stopwatch.Start();
                                            // list.QuickSortByProcessor();

                                            stopwatch.Stop();

                                            list.Stat_Print();
                                            Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");




                                        }



                                    }


                                    break;
                                }


                            //quit
                            case "Q":
                                {
                                    return;
                                }
                        }

                        Console.WriteLine("\n        Back = B \t BACK TO HOME = H\n");
                        select2 = Console.ReadLine();

                    } while (select2 == "B");
                }

                //phones
                else if (n1 == 2)
                {
                    do
                    {
                        Console.WriteLine("   MOBILE PHONE INVENTORY MANAGEMENT SYSTEM");
                        Console.WriteLine("\n       Add A New Product = A\n\n       Search Product Detail = S\n\n       Update Product Detail = U\n\n       Display Product Stat = D\n\n       Remove Product = R\n\n       Display Product According To The Price Order = DP\n\n       Print Booked Phones = PB\n\n       Sort Name = NS\n\n       Quit = Q\n");
                        select10 = Console.ReadLine();
                        
                        switch (select10)
                        {
                            //add product
                            case "A":
                                {
                                    do
                                    {
                                        Console.WriteLine("\n\n       Where do you want to add product details?");
                                        Console.WriteLine("\n\n       Add front  : AF");
                                        Console.WriteLine("\n       Add Last  : AL");
                                        Console.WriteLine("\n       Add a new product to your desired index  : AIN\n");

                                        select30 = Console.ReadLine();

                                        string productName;
                                        string productID;
                                        double price;
                                        string processor;
                                        string ram;
                                        string storage;
                                        double batteryLife;
                                        string display;
                                        string cameraQuality;
                                        string condition;

                                        Console.Write("\n       Enter Product Name : "); productName = Console.ReadLine();
                                        Console.Write("\n       Enter Product ID : "); productID = Console.ReadLine();
                                        Console.Write("\n       Enter Product Price : "); price = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("\n       Enter Product's Processor : "); processor = Console.ReadLine();
                                        Console.Write("\n       Enter Product's RAM : "); ram = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Storage : "); storage = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Battery Life (in hours) : "); batteryLife = Convert.ToDouble(Console.ReadLine());
                                        Console.Write("\n       Enter Product's Display : "); display = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Camera Quality : "); cameraQuality = Console.ReadLine();
                                        Console.Write("\n       Enter Product's Condition (New, Refurbished, Booked) : "); condition = Console.ReadLine();

                                        //add last
                                        if (select30 == "AL")
                                        {
                                            phoneList.AddLast1(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);
                                        }

                                        //add front
                                        else if (select30 == "AF")
                                        {
                                            phoneList.AddFront(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition);
                                        }

                                        //add index
                                        else if (select30 == "AIN")
                                        {
                                            Console.Write("\n       Enter index :");
                                            indexValue = Convert.ToInt32(Console.ReadLine());
                                            phoneList.AddIndex(productName, productID, price, processor, ram, storage, batteryLife, display, cameraQuality, condition, indexValue);
                                        }

                                        Console.WriteLine("\n       ADD MORE PRODUCT = M\t BACK TO HOME = H\n");
                                        select20 = Console.ReadLine();

                                    } while (select20 == "M");
                                    break;
                                }
                            
                                //display
                            case "D":
                                phoneList.Stat_Print();
                                break;
                            
                                //remove
                            case "R":
                                {
                                    do
                                    {
                                        Console.WriteLine("\n\n       Remove product by using ID : RID");
                                        Console.WriteLine("\n       Remove product by using Index : RIN");
                                        string getKey = Console.ReadLine();

                                        if (getKey == "RIN")
                                        {
                                            Console.Write("\n\n       Enter Remove Product's Index : ");
                                            int index = Convert.ToInt32(Console.ReadLine());
                                            phoneList.RemoveAt(index);

                                            Console.WriteLine("\n       DELETE MORE PRODUCT = MD\t BACK TO HOME = BH\n");
                                            select40 = Console.ReadLine();
                                        }
                                        else if (getKey == "RID")
                                        {
                                            Console.Write("\n\n       Enter the Product ID to remove: ");
                                            string productID = Console.ReadLine();
                                            phoneList.RemoveProductByID(productID);

                                            Console.WriteLine("\n       DELETE MORE PRODUCT = MD\t BACK TO HOME = BH\n");
                                            select40 = Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\n\n       Enter correct Key ");
                                        }
                                    } while (select40 == "MD");
                                    break;
                                }
                            
                                // search
                            case "S":
                                {
                                    Console.WriteLine("\n       Enter the Product ID :  ");
                                    string id = Console.ReadLine();
                                    Node1 foundNode = phoneList.Search(id);

                                    // Output the result
                                    if (foundNode != null)
                                    {
                                        Console.WriteLine("\n       Found Product Here is Product Detail: \n");
                                        Console.WriteLine($"Name: {foundNode.ProductName}");
                                        Console.WriteLine($"ID: {foundNode.ProductID}");
                                        Console.WriteLine($"Price: LKR{foundNode.Price}");
                                        Console.WriteLine($"Processor: {foundNode.Processor}");
                                        Console.WriteLine($"RAM: {foundNode.RAM}");
                                        Console.WriteLine($"Storage: {foundNode.Storage}");
                                        Console.WriteLine($"Battery Life: {foundNode.BatteryLife} hours");
                                        Console.WriteLine($"Display: {foundNode.Display}");
                                        Console.WriteLine($"Camera Quality: {foundNode.CameraQuality}");
                                        Console.WriteLine($"Condition: {foundNode.Condition}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("\n       Product was not included in the database.");
                                    }
                                    break;
                                }
                            //sort price
                            case "DP":
                                {
                                    phoneList.BubbleSortByPrice();
                                    Console.WriteLine("\n       Sorted according to the price");
                                    phoneList.Stat_Print();
                                    break;
                                }

                                //update
                            case "U":
                                {
                                    Console.Write("\n\n       Enter the Product ID to update: ");
                                    string productID = Console.ReadLine();
                                    phoneList.UpdateProductDetail(productID);
                                    break;
                                }
                            
                                //print booked products
                            case "PB":
                                {
                                    phoneList.PrintBookedPhones();
                                    break;
                                }

                                // sort name
                            case "NS":
                                {

                                    phoneList.NameBubbleSort();
                                    phoneList.Stat_Print();
                                    break;
                                }
                            
                                //quit
                            case "Q":
                                {
                                    return;
                                }
                        }



                        Console.WriteLine("\n        BACK TO HOME = H\t Back = B");
                        select2 = Console.ReadLine();

                    } while (select2 == "B");

                }
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number (1 or 2).");
            }


            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a number (1 or 2).");
            }
    }

    //user
        else
        {

            do
            {

                Console.WriteLine("\nWhat you want to consider ? ");
                Console.WriteLine("\n 1 - Laptop");
                Console.WriteLine("\n 2 - Mobile Phones ");

                int n1 = Convert.ToInt32(Console.ReadLine());
              
            
            //laptop
            if (n1 == 1)
                {
                    Console.WriteLine("\n   LAPTOP INVENTORY MANAGEMENT SYSTEM");
                    Console.WriteLine("\n       Print booked laptops = PB\n       Dispaly All product = D\n       To Book = B\n       Filter products = F\n       Quit = Q\n");
                    select1 = Console.ReadLine();

                switch (select1)
                {

                    //display
                        case "D":
                        {
                            list.Stat_Print();
                            break;

                        }

                        case "B": // Booking a laptop
                            {
                                Console.Write("\nEnter the Product ID to book: ");
                                string productID = Console.ReadLine();
                                list.BookingLaptop(productID);
                                break;
                            }

                        case "PB": // Print booked laptops
                            {
                                list.PrintBookedLaptops();
                                break;
                            }

                        //filter 
                        case "F":
                            {

                                Console.WriteLine("\n       Filter");
                                Console.WriteLine("\n        1.Product Name");
                                Console.WriteLine("\n        2.Product Price");
                                Console.WriteLine("\n        3.Product Processer");

                                int n = Convert.ToInt32(Console.ReadLine());
                            
                            //sort product name
                                if (n == 1)
                                {
                                    Console.WriteLine("\n       What Metthod ?");
                                    Console.WriteLine("\n        1.Bubble Sort");
                                    Console.WriteLine("\n        2.Merge Sort.");
                                   
                                    int nn = Convert.ToInt32(Console.ReadLine());
                                    if (nn == 1)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                        //bubblesort
                                        stopwatch.Reset();
                                        stopwatch.Start();
                                        list.NameBubbleSort();
                                        stopwatch.Stop();


                                        list.Stat_Print();
                                        Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                    }
                                    else if (nn == 2)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //mergesort
                                         stopwatch.Reset();
                                        stopwatch.Start();
                                        list.NameMergeSort();
                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                    }

                                    else if (nn == 3)
                                    {

                                        Stopwatch stopwatch = new Stopwatch();

                                    //Quicksort
                                        stopwatch.Reset();
                                        stopwatch.Start();

                                    
                                        list.QuickSortByName();
                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                    }


                                }
                                //sort price
                                else if (n == 2)
                                {
                                    Console.WriteLine("\n       What Metthod ?");
                                    Console.WriteLine("\n        1.Bubble Sort");
                                    Console.WriteLine("\n        2.Merge Sort.");
                                    Console.WriteLine("\n        3.Quick Sort");
                                    int nn = Convert.ToInt32(Console.ReadLine());
                                    if (nn == 1)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                        //bubblesort
                                        stopwatch .Reset();
                                        stopwatch.Start();
                                        list.NameBubbleSort();
                                        stopwatch.Stop();


                                        list.Stat_Print();
                                        Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                    }
                                    else if (nn == 2)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //mergesort
                                    stopwatch.Reset();
                                    stopwatch.Start();
                                        list.MergeSort();
                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                    }

                                    else if (nn == 3)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //Quicksort
                                    stopwatch.Reset();
                                    stopwatch.Start();

                                        list.QuickSortByPrice();
                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");
                                    }




                                }

                                //sort processor(i3,i5,i7)

                                else if (n == 3)
                                {
                                    Console.WriteLine("\n       What Metthod ?");
                                    Console.WriteLine("\n        1.Bubble Sort");
                                    Console.WriteLine("\n        2.Merge Sort.");
                                   
                                    int nn = Convert.ToInt32(Console.ReadLine());
                                  
                                if (nn == 1)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //bubblesort
                                    stopwatch.Reset();
                                    stopwatch.Start();
                                        list.BubbleSortByProcessor();
                                        stopwatch.Stop();


                                        list.Stat_Print();
                                        Console.WriteLine($"Bubble Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                    }
                                    else if (nn == 2)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //mergesort
                                    stopwatch.Reset();
                                    stopwatch.Start();
                                       // list.MergeSortByProcessor();
                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Merge Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");



                                    }

                                    else if (nn == 3)
                                    {
                                        Stopwatch stopwatch = new Stopwatch();

                                    //Quicksort
                                    stopwatch.Reset();
                                    stopwatch.Start();
                                        //list.QuickSortByProcessor();

                                        stopwatch.Stop();

                                        list.Stat_Print();
                                        Console.WriteLine($"Quick Sort Time: {stopwatch.Elapsed.TotalNanoseconds} ns");




                                    }



                                }
                                break;
                            }



                        //quit
                        case "Q":
                            {
                                return;
                            }
                    }
                }

            //phones
                else if (n1 == 2)
                {
                    
                    
                        Console.WriteLine("   MOBILE PHONE INVENTORY MANAGEMENT SYSTEM");
                        Console.WriteLine("\n       Display product stat = D\n\n       Display product according to the price order = DP\n\n       Sort name = NS\n\n       Quit = Q\n");

                        select10 = Console.ReadLine();
                        

                switch (select10)
                        {

                    //display
                            case "D":
                            {
                                phoneList.Stat_Print();
                                break;
                            }


                            
                        //sort price
                            case "DP":
                                {
                                    phoneList.BubbleSortByPrice();
                                    Console.WriteLine("\n       Sorted according to the price");
                                    phoneList.Stat_Print();
                                    break;
                                }

                        //print booked products
                            case "PB":
                                {
                                    phoneList.PrintBookedPhones();
                                    break;
                                }
                        //sort names
                            case "NS":
                                {
                                    phoneList.NameBubbleSort();
                                    phoneList.Stat_Print();
                                    break;
                                }
                        //quit
                            case "Q":
                                {
                                    return;
                                }
                        }

                        
                }

                Console.WriteLine("\n        Back = B \t BACK TO HOME = H\n");
                select2 = Console.ReadLine();

            } while (select2 == "B");






        }
   
} while (select2 == "H") ;




