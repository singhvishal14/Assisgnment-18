using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartPhone smartPhone = new SmartPhone("Google Pixel6A");
            
            smartPhone.Connect();
            smartPhone.Charge(30);
            Console.WriteLine(smartPhone.Display());

            Laptop laptop = new Laptop("Acer Swift 3");
            laptop.Connect();
            laptop.Charge(78);
            laptop.Display();

            Console.ReadKey();
        }
    }
}
