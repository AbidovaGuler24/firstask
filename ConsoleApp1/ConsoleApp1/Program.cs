using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Eded daxil edin : ");
            int num = int.Parse(Console.ReadLine());
            int hasil = 1;
            while (num>0)
            {
                hasil *= num % 10; 
                num /= 10;         
            }
            Console.WriteLine($"Reqemlerin hasili {hasil}");

        }
    }
}
