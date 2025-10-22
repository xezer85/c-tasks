using System;

namespace ProductDemo
{
    class Program
    {
        static void ShowAllProducts(params Product[] products)
        {
            foreach (var p in products)
            {
                p.DisplayInfo();
                Console.WriteLine("----------------------");
            }
        }

        static void Main(string[] args)
        {
            var book1 = new BookProduct("C# In Depth", new Dimensions(15.0, 23.0, 3.0), 10, "Jon Skeet");
            var elec1 = new ElectronicsProduct("Oyun Noutbuku", new Dimensions(35.0, 24.0, 2.5), null, 150.0);

            ShowAllProducts(book1, elec1);

            Console.WriteLine("Çıxmaq üçün hər hansı bir düyməyə basın...");
            Console.ReadKey();
        }
    }
}
