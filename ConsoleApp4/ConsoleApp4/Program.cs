using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 7, 8, 9, 12, 23, 34 };
            Console.Write("Eded daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            bool maxeded= true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (n<=arr[i])
                {
                    Console.WriteLine("False");
                    break;
                }
                else
                {
                    Console.WriteLine("True");
                    break;
                }

            }
        }
    }
}
