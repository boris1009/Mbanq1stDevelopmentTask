using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTaskAlgorithms
{
     class Program
    {
        static void Main(string[] args)
        {

            //1
            Console.WriteLine("\nTask 1");
            Console.WriteLine(factorial(5));

            //2
            Console.WriteLine("\nTask 2");
            Console.WriteLine(swap(5,3));

            //3
            Console.WriteLine("\nTask 3");
            int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3, 6, 7, 8};
            int n = arr.Length;
            repeat(arr, n);

            //4
            Console.WriteLine("\nTask 4");
            Console.WriteLine(divide(9));

        }

        //task 1 - swap
        private static string swap(int x, int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;
            
            return "x = " + x + ", y = " + y;

        }

        //task 2 - repeat
        static void repeat(int[] arr, int n)
        {

            n = arr.Length;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    var val = dict[arr[i]];
                    dict[arr[i]] = val +1;
                    
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> e in dict)
            {
                if (e.Value > 1)
                {
                    Console.Write(e.Key + " ");
                }
            }
        }

   
        //task 3 - division by 3
        private static int divide(int n)
        {
            while (true)
            {
                n++;
                if(n%3 == 0)
                {
                    return n;

                }

            }
            return n;
        }

            //task 4 - factoriel
            private static double factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }
    }
}
