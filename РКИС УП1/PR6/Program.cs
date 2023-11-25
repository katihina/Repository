// Задание 1:
using System.IO;

namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = File.ReadAllText("wordTask1.txt").Split(' ');

            foreach (string word in words)
            {
                if (word.Length % 2 == 0)
                {
                    Console.WriteLine("Слова нечетной длины: "  + word);
                }
            }
        }
    }
}


// Задание 2:
using System.IO;
    
namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("wordTask2.txt");

            string results = String.Join(" ", words);
       
            Console.WriteLine(results);
        }
    }
}


// Задание 3:
using System.IO;

namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 10 == 0 && n % 2 == 0)
            {
                Console.WriteLine("Число четное и кратно 10");
            }
            else
            {
                Console.WriteLine("Число не подходит по условиям");
            }
        }
    }
}


// Задание 4:
namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите положительнное число, который делит числа:");
            int a = Convert.ToInt32(Console.ReadLine());
       
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите положительные числа(для окончания ввести отрицательное):");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 0)
                { 
                    break;
                }

                if (n % a == 0)
                {
                    sum += n;
                }
            }

            Console.WriteLine("Сумма чисел: " + sum);

        }
    }
}


// Задание 5:
namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы m x n:");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
        
            int[,] a =
            {
                {1, 0, 1, 1, 0, 1, 0},
                {0, 1, 0, 1, 1, 0, 1},
                {1, 0, 1, 0, 1, 1, 0},
                {0, 1, 1, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 1, 0},
                {1, 0, 1, 0, 1, 0, 1},
                {0, 1, 1, 0, 0, 1, 0}
            };
        
            int[,] newMatrix = new int[n, m + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = a[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                int count = 0; 

                for (int j = 0; j < m; j++)
                {
                    if (newMatrix[i, j] == 1)
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    newMatrix[i, m] = 1;
                }
                else
                {
                    newMatrix[i, m] = 0;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m + 1; j++)
                {
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


// Задание 6:
namespace PR6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] mainlArray = GenerateRandomArray(10); 
            double[] positiveArray;
            double[] negativeArray;

            SplitArray(mainlArray, out positiveArray, out negativeArray);
        
            Console.WriteLine("\nМассив:");
            PrintArray(mainlArray);

            Console.WriteLine("\nПоложительные числа:");
            PrintArray(positiveArray);
            Console.WriteLine("\nОтрицательные числа:");
            PrintArray(negativeArray);
        }

        static double[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = random.NextDouble() * (random.Next(100) - 50); 
            }

            return result;
        }

        static void SplitArray(double[] main, out double[] positive, out double[] negative)
        {
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (double number in main)
            {
                if (number >= 0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }

            positive = new double[positiveCount];
            negative = new double[negativeCount];

            positiveCount = 0;
            negativeCount = 0;

            foreach (double number in main)
            {
                if (number >= 0)
                {
                    positive[positiveCount] = number;
                    positiveCount++;
                }
                else
                {
                    negative[negativeCount] = number;
                    negativeCount++;
                }
            }
        }

        static void PrintArray(double[] array)
        {
            foreach (double number in array)
            {
                Console.Write(number.ToString("0.000") + " ");
            }
        }
    }
}



