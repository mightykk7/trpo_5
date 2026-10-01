using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число: ");
            number = int.Parse(Console.ReadLine());
            int i= 0;
            while (number % 7 != 0)
            {
                number += 1;
                i++;
            }
            Console.WriteLine("Минимальная число: "+ i);
            Console.ReadKey();
        }
    }
}
