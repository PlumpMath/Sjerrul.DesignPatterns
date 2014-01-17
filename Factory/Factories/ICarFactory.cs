using Factory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    interface ICarFactory
    {
        ICar BuildCar();
    }
}
