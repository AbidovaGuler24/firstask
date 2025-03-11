using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Eded daxil edin: ");
            int num = int.Parse(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Bu eded ne sade, ne de murekkebdir.");
                return;
            }
            int i = 2, count = 0;
            while (i < num)
            {
                if (num % i == 0) // Əgər num i-ə tam bölünürsə
                {
                    count++; // Bölən tapıldığı üçün sayğacı artırırıq
                }
                i++;

            }
            if (count == 0)
                Console.WriteLine($"{num} sade ededdir.");

            else
                Console.WriteLine($"{num} murekkeb ededdir.");


        }
    }
}
