using System;

namespace CountOfParityHW
{
    class Program
    {
        static void Main(string[] args)
        {
           int lowerLimitOfRange, uperLimitOfRange, resultOfOperation, countOfParity, countOfOdd, curentInteger;
            countOfParity = 0;
            countOfOdd = 0;
            lowerLimitOfRange = 0;
            uperLimitOfRange = 0;

            try
            {
                Console.WriteLine("Введите нижнюю границу диапозона:");
                lowerLimitOfRange = int.Parse(Console.ReadLine());
                

                Console.WriteLine("Введите верхнюю границу диапозона");
                uperLimitOfRange = int.Parse(Console.ReadLine());
            }
            catch (Exception) 
            {
                Console.WriteLine("Вы ввели неккоректные данные");
                Environment.Exit(0);
            }

            curentInteger = lowerLimitOfRange;

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
