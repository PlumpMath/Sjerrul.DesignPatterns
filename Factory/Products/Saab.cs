using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Products
{
    class Saab : ICar
    {

        public string GetInfo()
        {
            return "Saab";
        }
    }
}
