using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_practice_set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# program to find the sum of all elements in an integer array using a loop
            /* int[] arr = { 1, 2, 3, 4, 5 };
             int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                   sum += arr[i];
                }
             Console.WriteLine("the sum of the array is: " + sum);
             Console.ReadLine();*/

            //2.Create a C# program that calculates the average of values in a floating-point array using a loop.
            /*double[] ab = { 1.3, 2.3, 3.4, 4.5, 5.6 };
            double sum1 = 0;
               for (int i = 0; i < ab.Length; i++)
               {
                   sum1 += ab[i];
               }
            double avg = sum1/ ab.Length;
            Console.WriteLine("the average is: " + sum1);
            */

            // 3.Develop a C# program that finds the largest element in an integer array using a loop and if-else statements.
            /*int[] ar = { 4, 5, 6, 7, 23, 54 };
            int max = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (max < ar[i])
                {
                    max = ar[i];
                }
            }
            Console.WriteLine("The largest number is: " + max);*/

            //4.  Write a C# program that counts the number of even and odd elements in an integer array using a loop and if-else statements.

            /*int[] ar2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < ar2.Length; i++)
            {
                if (ar2[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("the number if even is: " + even);
            Console.WriteLine("the number if odd is: " + odd);
            */

            //5. Implement a C# program that reverses the elements of an integer array using a loop.

            /*int[] ar3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i = 0;
            int j = ar3.Length - 1;
            while (i < j)
            {
                int temp = ar3[i];
                ar3[i] = ar3[j];
                ar3[j] = temp;
                i++;
                j--;
            }
            for (int l = 0; l < ar3.Length; l++)
            {
                Console.WriteLine(ar3[l]);  
            } */

            // 6.Create a C# program that multiplies each element in an integer array by a specified factor using a loop.

            /*int[] ar4 = { 1, 2, 3, 4, 5, 6, 6 };
            int mul = 1;
            for (int p = 0; p < ar4.Length; p++)
            {
                mul *= ar4[p];
            }
            Console.WriteLine(mul);
            */

            // 7.Write a C# program that searches for a specific value in an integer array using a loop and returns its index if found.

            int[] ar5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            Console.WriteLine("enter the number you want to search");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ar5.Length; i++)
            {
                if (n == ar5[i])
                {
                    Console.WriteLine("yes");
                    Console.WriteLine("index of the number is :" + i);
                    break;
                }
                Console.ReadLine();
            } 
        }
    }
}
    