using System;

namespace _3tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char letter = Convert.ToChar(Console.ReadLine());
            int index = FindIndex(word, letter);
            Console.WriteLine(index);

            Console.WriteLine("ededi daxil edin: ");
            string numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);
            int squareRoot = SquareRoot(number);
            Console.WriteLine(squareRoot);

            Console.WriteLine("ededi daxil edin: ");
            string numstr = Console.ReadLine();
            int num = Convert.ToInt32(numstr);
            Console.WriteLine("massivin sizesini daxil edin: ");
            string sizeStr = Console.ReadLine();
            int size = Convert.ToInt32(sizeStr);
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}. deyeri daxil edin: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxNum = MaxArray(numbers);
            Console.WriteLine(maxNum);
            int sumOfDigits = Sum(num);
            Console.WriteLine(sumOfDigits);

            Console.WriteLine("massivin sizesini daxil edin: ");
            string sizeStr = Console.ReadLine();
            int size = Convert.ToInt32(sizeStr);
            int[] numbers = new int[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i}. deyeri daxil edin:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] positiveArray = PositiveArray(numbers);
            Console.WriteLine("yeni array: ");
            foreach (var item in positiveArray)
            {
                Console.WriteLine(item);
            }
        }
        static int FindIndex(string output, char letter)
        {
            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] == letter)
                    return i;
            }
            return -1;
        }

        static int SquareRoot(int number)
        {
            if (number >= 0)
            {
                for (int i = 0; i <= number; i++)
                {
                    if (i * i == number)
                        return i;
                    else if (i * i > number)
                        return i - 1;
                }
            }
            return -1;
        }

        static int Sum(int number)
        {
            int sum = 0;
            while (number > 0 || number < 0)
            {
                sum += number % 10;
                number = (number - number % 10) / 10;
            }
            return sum;
        }

        static int MaxArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }
            return max;
        }

        static int[] PositiveArray(int[] numbers)
        {
            int length = numbers.Length;
            int[] positiveNumbers = new int[length];
            int j = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                    positiveNumbers[j] = -numbers[i];
                else
                    positiveNumbers[j] = numbers[i];
                j++;
            }
            return positiveNumbers;
        }
    }
}
