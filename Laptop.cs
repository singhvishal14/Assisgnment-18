using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_18
{
    internal class Laptop:IConnectable1,IRechargeable, IDisplayable
    {
        string Model;
        int charge;
        string info;
        public Laptop(string model)
        {
            Model = model;
            charge = 0;
            info = "";
        }
        public int Charge(int minutes)
        {
            charge += minutes;
            return charge;
        }

        public bool Connect()
        {
            Console.WriteLine($"COnnected Successfully to Laptop {Model}!!");
            return true;
        }

        public string Display()
        {
            Console.WriteLine("Charging Time: " + charge + " minutes");
            return info;
        }
    }
}
