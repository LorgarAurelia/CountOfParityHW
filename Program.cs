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
           int lowerLimitOfRange, uperLimitOfRange, resultOfOperation, countOfParity, countOfOddness;
            countOfParity = 0;
            countOfOddness = 0;

            Console.WriteLine("Введите нижнюю границу диапозона:");
            lowerLimitOfRange = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите верхнюю границу диапозона");
            uperLimitOfRange = int.Parse(Console.ReadLine());

            while (lowerLimitOfRange <= uperLimitOfRange) 
            {
                resultOfOperation = lowerLimitOfRange % 2;
                switch (resultOfOperation) 
                {
                    case 0:
                        countOfParity++;
                        break;
                }
                    
            }
        }
    }
}
