using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3, 4, 5, 3, 6, 7, 8, 5, 2, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)

                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[i] = arr[j]);

                    }

                }

                }
            }
        }
}
