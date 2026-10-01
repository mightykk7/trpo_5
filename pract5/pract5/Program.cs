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
            bool found = false;
            while (!found)
            {
                int kopia = number + i;
                int sum = 0;
                while(kopia >0)
                {
                    sum += kopia % 10;
                    kopia /= 10;
                }
                if ( sum % 7 == 0)
                    found = true;
                else 
                    i++;
            }
            Console.WriteLine("Минимальная число: "+ i);
            Console.ReadKey();
        }
    }
}
