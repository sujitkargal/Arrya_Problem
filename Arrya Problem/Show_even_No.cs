using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrya_Problem
{
    class Show_even_No
    {
        public static void Main(string[] args)
        {
        int[] a = new int[10];

         Console.WriteLine("enter number len(10) ");
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] =  int.Parse(Console.ReadLine());
             
            }

            Console.WriteLine("even numbers are");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                   
                  Console.WriteLine(a[i]);

                }

            }

        }

    }
}
