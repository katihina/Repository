// Задание 1:
namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int product = 1;
            for (int i = 3; i <= n; i += 3)
            {
                product *= i;
            }

            Console.WriteLine("Произведение чисел: " + product);
        }
    }
}


// Задание 2:
using System.IO;

namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numberStrings = File.ReadAllText("numsTask2.txt").Split(';');
            double[] numbers = new double[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = double.Parse(numberStrings[i]);
            }

            double sum = 0;
            foreach (double number in numbers)
            {
                if (number > 0)
                {
                    sum += number;
                }

                if (number == 0)
                {
                    break;
                }
            }

            Console.WriteLine("Сумма положительных элементов: " + sum);
        }
    }
}

    
// Задание 3:
using System.IO;

namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStrings = File.ReadAllText("numsTask3.txt").Split(',');
            int[] numbers = Array.ConvertAll(numbersStrings, int.Parse);

            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num == 0)
                {
                    break;
                }
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }

            double ratio = (double)min / max;

            Console.WriteLine($"Отношение минимального числа к максимальному: {ratio.ToString("0.000")}");
        }
    }
}


// Задание 4:
using System.IO;

namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbersStrings = File.ReadAllText("numsTask4.txt").Split(' ');
            int[] numbers = new int[numbersStrings.Length];

            int countSameNums = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    countSameNums++;
                }
            }

            Console.WriteLine($"Количество одинаковых рядом стоящих чисел: {countSameNums}");
        }
    }
}


// Задание 5:
using System.ComponentModel.Design;

namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = -1;
            double y1 = -2;
            double x2 = 3;
            double y2 = 4;

            Console.WriteLine("Введите координаты точки(a;b):");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a >= x1 && a <= x2 && b >= y1 && b <= y2)
            {
                Console.WriteLine("Точки принадлежат");
            }
            else
            {
                Console.WriteLine("Точки не принадлежат");
            }
        }
    }
}


// Задание 6:
using System.ComponentModel.Design;

namespace PR4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = -2;
            double y1 = -3; 
            double x2 = 2;
            double y2 = -3;
            double x3 = 0;
            double y3 = 2;
        
            Console.WriteLine("Введите координаты точки:");
            double a = Convert.ToDouble(Console.ReadLine()); 
            double b = Convert.ToDouble(Console.ReadLine()); 
        
            if((a - x1) * (y2 - y1) - (x2 - x1) * (b - y1) > 0 &&
               (a - x2) * (y3 - y2) - (x3 - x2) * (b - y2) > 0 &&
               (a - x3) * (y1 - y3) - (x1 - x3) * (b - y3) > 0 ||
               (a - x1) * (y2 - y1) - (x2 - x1) * (b - y1) < 0 &&
               (a - x2) * (y3 - y2) - (x3 - x2) * (b - y2) < 0 &&
               (a - x3) * (y1 - y3) - (x1 - x3) * (b - y3) < 0)
            {
                Console.WriteLine("Точка принадлежит");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит"); 
            }
        }
    }
}

