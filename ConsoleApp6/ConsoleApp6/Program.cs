using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Fibonacci ardıcıllığının neçə ədədi göstərilsin? ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;
            Console.Write(a);
            Console.Write(b);

            for (int i = 2; i < n; i++)
            {
                int c = a + b;

                Console.Write(c);

                a = b;
                b = c;

            }
        }
    }
}
