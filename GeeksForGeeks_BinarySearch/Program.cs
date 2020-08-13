using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GeeksForGeeks_BinarySearch
{
    class Program
    {

        private static int Find(int[] a, int k, int startIndex, int endIndex)
        {
            // If the Array contains more than one element
            if (endIndex >= startIndex)
            {
                // Get the the index of middle item
                int middleIndex = startIndex + (endIndex - startIndex) / 2;

                // Get the value of  the middle index
                int middleValue = a[middleIndex];

                // IF Value at the middle
                if (middleValue == k)
                    return 1;

                else if (middleValue > k)
                {
                    // Start Index will not change as we go left
                    // End Index will become the middle index 
                    endIndex = middleIndex -1;
                   return Find(a, k, startIndex, endIndex);
                }
                else
                {
                    // End Index will not chagne as we go right
                    // Start index will become the middle index
                    startIndex = middleIndex +1;
                   return Find(a, k, startIndex, endIndex);
                }
            }            

            return -1;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the number of test cases");

            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please enter the input length");

            for (int i = 0; i < numberOfTestCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(input[0]);

                int k = Convert.ToInt32(input[1]);

                //Console.WriteLine("Please enter the set of item you need to search in");

                string[] arrStr = Console.ReadLine().Split(' ');

                int[] A = new int[n];

                for (int j = 0; j < n; j++)
                {
                    A[j] = Convert.ToInt32(arrStr[j].ToString());
                }

                int indexOfK = Find(A, k, 0, A.Length -1 );

                Console.WriteLine(indexOfK);
            }
        }
    }
}
