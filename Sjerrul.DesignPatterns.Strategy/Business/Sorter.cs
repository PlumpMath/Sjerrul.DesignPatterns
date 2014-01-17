using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    public class Sorter
    {
        private ISortAlgoritm _sortAlgoritm;

        public Sorter(ISortAlgoritm sortAlgoritm)
        {
            _sortAlgoritm = sortAlgoritm;
        }

        public void Sort(int[] integersToSort)
        {
            _sortAlgoritm.Sort(integersToSort);
        }
    }
}
