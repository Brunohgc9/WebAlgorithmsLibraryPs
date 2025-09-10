using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.MethodsToBeBenchmarked
{
    public class BinarySearchAlgorithm
    {
        public int BinarySearchMethod (List<int> numberList, int numberToFind)
        {
            int low = 0;
            int mid;
            int high = numberList.Count - 1;

            int guess;
            int attempts = 0;

            while (low <= high)
            {
                attempts++;

                mid = (low + high) / 2;
                guess = numberList[mid];

                if (guess == numberToFind)
                {
                    return attempts;
                }
                if (guess > numberToFind)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
