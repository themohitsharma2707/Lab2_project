using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_sum
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the element in the array");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("sum is ");
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}