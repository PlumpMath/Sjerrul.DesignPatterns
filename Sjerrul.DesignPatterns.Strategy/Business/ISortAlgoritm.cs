using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    public interface ISortAlgoritm
    {
        void Sort(int[] integersToSort);
    }
}
