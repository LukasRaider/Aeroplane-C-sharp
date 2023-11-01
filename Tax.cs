using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    class RealEstate
    {
        public double tax()
        { return 0.0; }
    }
    class House : RealEstate
    {
        public double tax() { int dayOfMonth = DateTime.Now.Day; return 1.27 * dayOfMonth; }
    }
    class Flat : RealEstate 
    {
        public double tax() { int dayOfYear = DateTime.Now.DayOfYear; return 1.15 * dayOfYear; }
    }
    class Vehicle 
    {
        public int tax() { return 1500; }
    }
    class Car : Vehicle { }
    class Motorcycle : Vehicle { }
    class Trolleybus : Vehicle { public new double tax() { return 0.9 * base.tax(); } }
    class TestTax {
        public static void Mainx(string[] args)
        {
            List<object> items = new List<object>();
            items.Add(new House());
            items.Add(new Flat());
            items.Add(new Car());
            items.Add(new Motorcycle());
            items.Add(new Trolleybus());

            double totalTax = 0.0;

            foreach (var item in items)
            { 
                string className= item.GetType().Name;
                double itemTax = 0.0;

                if (item is RealEstate)
                { itemTax = ((RealEstate)item).tax(); }
                else if (item is Vehicle) { itemTax = ((Vehicle)item).tax();}

                Console.WriteLine($"{className} - sazba daně: {itemTax} hodnota daně.");
                totalTax += itemTax;
            }
            Console.WriteLine($"Celková daň: {totalTax}");
        }
    }
}
