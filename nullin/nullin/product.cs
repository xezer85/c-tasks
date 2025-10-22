using System;

namespace ProductDemo
{
    public enum Category
    {
        Book,
        Electronics,
        Food,
        Clothing
    }

    public class Product
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Dimensions Size { get; set; }
        public int? StockCount { get; set; }

        public Product(string name, Category category, Dimensions size, int? stockCount = null)
        {
            Name = name;
            Category = category;
            Size = size;
            StockCount = stockCount;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ad: {Name}");
            Console.WriteLine($"Kateqoriya: {Category}");
            Console.WriteLine($"Ölçülər: {Size}");
            Console.WriteLine($"Stok sayı: {(StockCount.HasValue ? StockCount.Value.ToString() : "Naməlum")}");
        }
    }
}
