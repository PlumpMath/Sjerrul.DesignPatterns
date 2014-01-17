using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    class VolvoFactory : ICarFactory
    {
        public ICar BuildCar()
        {
            return new Volvo();
        }
    }
}
