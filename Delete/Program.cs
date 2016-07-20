using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] LA = { 1, 2, 3, 4, 5 };
            int k = 3, n = 5;
            int i,j;

            Console.WriteLine("before");

            for (i=0; i<n; i++)
            {
                Console.WriteLine(LA[i]);
            }

            j = k;
            while (j < n)
            {
                LA[j - 1] = LA[j];
                j = j + 1;

            }
            n = n - 1;
            Console.WriteLine("after");
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine(LA[i]);
            }

        }
    }
}

