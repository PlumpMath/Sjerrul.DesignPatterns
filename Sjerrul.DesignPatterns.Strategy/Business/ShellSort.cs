using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    class ShellSort : SortBase, ISortAlgoritm
    {
        public void Sort(int[] integersToSort)
        {
            int j, temp = 0;
            int increment = (integersToSort.Length) / 2;
            while (increment > 0)
            {
                for (int index = 0; index < integersToSort.Length; index++)
                {
                    j = index;
                    temp = integersToSort[index];
                    while ((j >= increment) && integersToSort[j - increment] > temp)
                    {
                        integersToSort[j] = integersToSort[j - increment];
                        j = j - increment;
                    }
                    integersToSort[j] = temp;
                }
                if (increment / 2 != 0)
                    increment = increment / 2;
                else if (increment == 1)
                    increment = 0;
                else
                    increment = 1;
            }
        }
    }
}
