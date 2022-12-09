using System;
using System.Drawing;

namespace HW_1_4_Git
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Enter random number: ");
            int numb = int.Parse(Console.ReadLine());

            int[] numbers = new int[numb];

            // Заполняем массив рандомными числами
            Console.WriteLine("Array with random numbers: ");
            Random nums = new Random();
            for (int i = 0; i < numb; i++)
            {
                numbers[i] = nums.Next(1, 27);

                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Узнаем количество четных и нечетных чисел
            int oddNumber = 0;
            int evenNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumber++;
                }
                else
                {
                    oddNumber++;
                }
            }

            // Заполняем массивы четными и нечетными числами
            int odd = 0;
            int even = 0;

            int[] evenNumbers = new int[evenNumber];
            int[] oddNumbers = new int[oddNumber];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[even] = numbers[i];
                    even++;
                }
                else
                {
                    oddNumbers[odd] = numbers[i];
                    odd++;
                }
            }

            // Замена чисел на буквы в массиве
            string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            string[] evenABC = new string[evenNumbers.Length];
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                evenABC[i] = abc[evenNumbers[i] - 1];
                Console.Write(evenABC[i] + " ");
            }

            Console.WriteLine();

            string[] oddABC = new string[oddNumbers.Length];
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                oddABC[i] = abc[oddNumbers[i] - 1];
                Console.Write(oddABC[i] + " ");
            }

            Console.WriteLine();

            // Заменяем указанные буквы нижнего регистрастра на буквы верхнего регистра и считаем их колиство
            int countEven = 0;
            string[] compare = { "a", "e", "i", "d", "h", "j" };

            for (int i = 0; i < evenABC.Length; i++)
            {
                for (int j = 0; j < compare.Length; j++)
                {
                    if (evenABC[i] == compare[j])
                    {
                        evenABC[i] = evenABC[i].ToUpper();
                        countEven++;
                    }
                }
            }

            Console.WriteLine();

            int countOdd = 0;
            for (int i = 0; i < oddABC.Length; i++)
            {
                for (int j = 0; j < compare.Length; j++)
                {
                    if (oddABC[i] == compare[j])
                    {
                        oddABC[i] = oddABC[i].ToUpper();
                        countOdd++;
                    }
                }
            }

            // Выводим массив, в котором больше букв в верхнем регистре
            Console.WriteLine("Array with more letters in upper case: ");

            if (countOdd > countEven)
            {
                for (int i = 0; i < oddABC.Length; i++)
                {
                    Console.Write(oddABC[i] + " ");
                }
            }

            if (countOdd < countEven)
            {
                for (int i = 0; i < evenABC.Length; i++)
                {
                    Console.Write(evenABC[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Even array:");

            for (int i = 0; i < evenABC.Length; i++)
            {
                Console.Write(evenABC[i] + " ");
            }

            Console.WriteLine("\nOdd array:");

            for (int i = 0; i < oddABC.Length; i++)
            {
                Console.Write(oddABC[i] + " ");
            }

            Console.WriteLine();
        }
    }
}