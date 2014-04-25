using Factory.Factories;
using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory factory = new SaabFactory();

            ICar car = factory.BuildCar();
            Console.WriteLine(car.GetInfo());
            Console.ReadLine();
        }
    }
}
