using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    class BubbleSort : SortBase, ISortAlgoritm
    {
        public void Sort(int[] integersToSort)
        {
            for (int iterator = 0; iterator < integersToSort.Length; iterator++)
            {
                for (int index = 0; index < integersToSort.Length - 1; index++)
                {
                    if (integersToSort[index] > integersToSort[index + 1])
                    {
                        Swap(ref integersToSort[index], ref integersToSort[index + 1]);
                    }
                }
            }
        }
    }
}
