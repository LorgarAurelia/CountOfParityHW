using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfParityHW
{
    class Program
    {
        static void Main(string[] args)
        {
           int lowerLimitOfRange, uperLimitOfRange, resultOfOperation, countOfParity, countOfOdd, curentInteger;
            countOfParity = 0;
            countOfOdd = 0;

            Console.WriteLine("Введите нижнюю границу диапозона:");
            lowerLimitOfRange = int.Parse(Console.ReadLine());
            curentInteger = lowerLimitOfRange;

            Console.WriteLine("Введите верхнюю границу диапозона");
            uperLimitOfRange = int.Parse(Console.ReadLine());

            while (curentInteger <= uperLimitOfRange) 
            {
                resultOfOperation = curentInteger % 2;

                if (resultOfOperation == 0)
                    countOfParity++;
                else
                    countOfOdd++;

                curentInteger++;
             }

            Console.WriteLine("Количество четных чисел в диапозоне равняется: " + countOfParity + " Количество нечетных чисел ровняется: " + countOfOdd);
        }
    }
}
