using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    public class SortBase
    {
        protected void Swap(ref int ValueOne, ref int ValueTwo)
        {
            ValueOne = ValueOne + ValueTwo;
            ValueTwo = ValueOne - ValueTwo;
            ValueOne = ValueOne - ValueTwo;
        }

        protected void SwapWithTemp(ref int ValueOne, ref int ValueTwo)
        {
            int temp = ValueOne;
            ValueOne = ValueTwo;
            ValueTwo = temp;
        }
    }
}
