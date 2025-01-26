using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrya_Problem
{
    internal class sum_array
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int[] a = new int[5];

            Console.WriteLine("enter a numbers to sum ");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Addition of array is");

            for (int i = 0; i < a.Length; i++)
            {
                sum = a[i] + sum;
                
            }
            Console.WriteLine(sum);


        }
    }
}
