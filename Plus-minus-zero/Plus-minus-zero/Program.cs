using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Plus_minus_zero
{
    class Program
    {
        /*
            Sample Input:
            6
            -4 3 -9 0 4 1 

            Sample Output;
            0.500000
            0.333333
            0.166667
            OR
            0.5
            0.333333333333333
            0.166666666666667
        */
        static void plusMinus(int[] arr)
        {
            int[] res = new int[3];
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    res[0]++;
                }else if(arr[i] < 0)
                {
                    res[1]++;
                }
                else
                {
                    res[2]++;
                }
            }
            decimal temp = (decimal)1 / res.Length;
            for (int v = 0; v < res.Length; v++)
            {
                Console.WriteLine((double)res[v] / arr.Length);
            }
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            plusMinus(arr);
        }
    }
}
