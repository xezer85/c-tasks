using System;

namespace ProductDemo
{
    public class BookProduct : Product
    {
        public string Author { get; set; }

        public BookProduct(string name, Dimensions size, int? stockCount, string author)
            : base(name, Category.Book, size, stockCount)
        {
            Author = author;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Müəllif: {Author}");
        }
    }
}
