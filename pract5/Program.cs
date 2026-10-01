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
            int kopia = number;
            if (kopia < 0)
            {
                kopia = -kopia;
            }
            int sumChet = 0;
            int sumNeChet = 0;
            while (kopia > 0)
            {
                int digit = kopia % 10;

                if (digit % 2 == 0)
                {
                    sumChet += digit;
                }
                else
                {
                    sumNeChet += digit;
                }
                kopia /= 10;
            }
            int raz = sumChet - sumNeChet;
            if (raz < 0)
            {
                raz = -raz;
            }
            Console.WriteLine("Сумма чётных цифр: " +sumChet);
            Console.WriteLine("Сумма нечётных цифр: " +sumNeChet);
            Console.WriteLine("Минимальная разность: "+ raz);
        }
    }
}
