using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Strategy.Business
{
    class QuickSort : SortBase, ISortAlgoritm
    {
        public void Sort(int[] integersToSort)
        {
            int left = 0;
            int right = integersToSort.Length - 1;
            InternalQuickSort(integersToSort, left, right);
        }

        private void InternalQuickSort(int[] inputArray, int left, int right)
        {
            int pivotNewIndex = Partition(inputArray, left, right);
            int pivot = inputArray[(left + right) / 2];
            if (left < pivotNewIndex - 1)
                InternalQuickSort(inputArray, left, pivotNewIndex - 1);
            if (pivotNewIndex < right)
                InternalQuickSort(inputArray, pivotNewIndex, right);
        }

        private int Partition(int[] inputArray, int left, int right)
        {
            int i = left, j = right;
            int pivot = inputArray[(left + right) / 2];

            while (i <= j)
            {
                while (inputArray[i] < pivot)
                    i++;
                while (inputArray[j] < pivot)
                    j--;
                if (i <= j)
                {
                    SwapWithTemp(ref inputArray[i], ref inputArray[j]);
                    i++; j--;
                }
            }
            return i;
        }
    }
}
