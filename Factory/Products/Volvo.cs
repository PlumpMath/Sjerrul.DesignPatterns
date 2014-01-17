using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    class Volvo : ICar
    {

        public string GetInfo()
        {
            return "Volvo";
        }
    }
}
