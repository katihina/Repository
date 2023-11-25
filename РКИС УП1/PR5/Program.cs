// Задание 1:
using System.IO;

namespace PR5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStrings = File.ReadAllText("numsTask1.txt").Split(' ');
            int[] numbers = Array.ConvertAll(numbersStrings, int.Parse);
        
            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            int product = 1;
            for (int i = minIndex + 1; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            Console.WriteLine($"Произведение элементов после минимального: {product}");
        }
    }
}


// Задание 2:
using System.IO;
    
namespace PR5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStrings = File.ReadAllText("numsTask2.txt").Split(';');
            double[] numbers = Array.ConvertAll(numbersStrings, double.Parse);

            double[] numbersSort = BubbleSort(numbers);

            string sortNumbersStrings = string.Join(";", numbersSort);
            File.WriteAllText("numsTask2.txt", sortNumbersStrings);
        }

        static double[] BubbleSort(double[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            
                if (numbers[i] > numbers[i + 1])
                {
                    (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
                }
            }

            return numbers;
        }
    }
}


// Задание 3:
using System.IO;

namespace PR5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStr = File.ReadAllText("numsTask3.txt").Split(',');
            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            int minIndex = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        minIndex = i;
                    }
                    else
                    {
                        minIndex = j;
                    }
                }
            }

            if (minIndex > 0)
            {
                int sum = 0;
                for (int i = 0; i < minIndex; i++)
                {
                    sum += numbers[i];
                }

                double average = (double)sum / minIndex;

                Console.WriteLine($"Среднее арифметическое элементов до минимального: {average.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine("Недостаточно чисел для вычисления среднего арифметического.");
            }
        }
    }
}


// Задание 4:
using System.IO;

namespace PR5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStr = File.ReadAllText("numsTask4.txt").Split(' ');
            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                if (number == max - 1 || number == max + 1)
                {
                    sum += number;
                }
            }

            Console.WriteLine($"Сумма элементов, отличающихся от максимального на 1: {sum}");
        }
    }
}


// Задание 5:
using System.IO;
    
namespace PR5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStr = File.ReadAllText("numsTask5.txt").Split(',');
            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            int minIndex = 0;
            int maxIndex = 0;
            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    maxIndex = i;
                }
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            int sum = 0;
            int count = 0;

            for (int i = start + 1; i < end; i++)
            {
                sum += numbers[i];
                count++;
            }

            double average = 0;

            if (count > 0)
            { 
                average = (double)sum / count;
            }

            Console.WriteLine($"Среднее арифметическое элементов между минимальным и максимальным: {average}");
        }
    }
}
