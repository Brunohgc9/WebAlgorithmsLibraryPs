using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.MethodsToBeBenchmarked
{
    public class LinearSearchAlgorithm
    {
        public int LinearSearchMethod(List<int> numberList, int numberToFind)
        {
            int attempts = 0;

            foreach (int number in numberList)
            {
                attempts++;

                if (number == numberToFind)
                {
                    return attempts;
                }
            }

            return -1;
        }
    }
}
