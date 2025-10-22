using System;

namespace ProductDemo
{
    public class ElectronicsProduct : Product
    {
        public double PowerWatts { get; set; }

        public ElectronicsProduct(string name, Dimensions size, int? stockCount, double powerWatts)
            : base(name, Category.Electronics, size, stockCount)
        {
            PowerWatts = powerWatts;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Güc: {PowerWatts} W");
        }
    }
}
