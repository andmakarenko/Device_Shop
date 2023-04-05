using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device laptop = new Laptop("Asus", "SuperMega", 650, 36499.99, new Colors(Color.Black, Color.White, Color.Grey), 38, 3.4, 16);
            Device smartphone = new Smartphone("Samsung", "S7", 1500, 28500, new Colors(Color.Blue, Color.White), SmartphoneOS.Android, 15);
            Device tablet = new Tablet("Apple", "IPad 15", 326, 33200, new Colors(Color.Green, Color.Black, Color.Yellow), ScreenType.AMOLED, 23);
            Device smartphone2 = new Smartphone("Apple", "IPhone 8", 150, 12450, new Colors(Color.White, Color.Black, Color.Red), SmartphoneOS.IOS, 12);

            List<Device> devices = new List<Device> { laptop, smartphone, tablet };


            Shop shop = new Shop(devices);

            Console.WriteLine(shop.ToString());
            shop.AddDevice(smartphone2);
            Console.WriteLine(shop.ToString());
            shop.SearchByParameter();
            shop.DeleteByParameter();
            Console.WriteLine(shop.ToString());
            Console.WriteLine(shop[1]);


            Console.Read();
        }
    }
}
