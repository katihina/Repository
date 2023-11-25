// Задание 1:
namespace PR2
{
    public class Program
    {
        public static void Main(string[] args)   
        {
            int[] numbers = new int[100];
            int value = 300;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = value;
                value -= 3;
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}


// Задание 2:
namespace PR2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int value = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = value;
                value += 2;
            }

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}


// Задание 3:
namespace PR2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                matrix[i, 0] = 1;
                matrix[0, i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
                }
            }
        
            Console.WriteLine("Матрица:" + "\n");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}


// Задание 4:
namespace PR2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] temperatures = new double[12, 30];

            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j =0; j < 30; j++) 
                { 
                    temperatures[i, j] = random.Next(-10, 40);
                }
            }

            double[] averageTemperatures = CalculateAverageTemperature(temperatures);
            double[] ascendingTemperature = AscedingSort(averageTemperatures);

            for (int i = 0; i < ascendingTemperature.Length; i++)
            { 
                Console.WriteLine("Средняя температура в " + (i + 1) + " месяце: " + ascendingTemperature[i].ToString("0.0"));
            }
        }

        static double[] CalculateAverageTemperature(double[,] temperatures)
        {
            double[] averageTemperatures = new double[12];

            for (int i = 0; i < 12; i++)
            { 
                double sum = 0;
                for (int j = 0; j < 30; j++)
                { 
                    sum += temperatures[i, j];
                }

                averageTemperatures[i] = sum / 30;
            }

            return averageTemperatures;
        }

        static double[] AscedingSort(double[] averageTemperatures)
        {
            double[] ascendingTemperature = new double[averageTemperatures.Length];
            averageTemperatures.CopyTo(ascendingTemperature, 0);

            for (int i = 0; i < ascendingTemperature.Length - 1; i++)
            { 
                for (int j = i + 1; j < ascendingTemperature.Length; j++)
                {
                    if (ascendingTemperature[j] < ascendingTemperature[i])
                    {
                        (ascendingTemperature[i], ascendingTemperature[j]) = (ascendingTemperature[j], ascendingTemperature[i]);
                    }
                }
            }

            return ascendingTemperature;
        }
    }
}


// Задание 5:
namespace PR2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] temperatures = new double[12, 30];

            Random random = new Random();

            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    temperatures[i, j] = random.Next(-10, 40);
                }
            }

            double[] averageTemperatures = CalculateAverageTemperature(temperatures);

            Dictionary<int, double> averageTemperaturesDictionary = new Dictionary<int, double>();

            for (int i = 0; i < averageTemperatures.Length; i++)
            {
                averageTemperaturesDictionary.Add(i + 1, averageTemperatures[i]);
            }

            var sortedTemperature = averageTemperaturesDictionary.OrderBy(t => t.Value);

            foreach (var item in sortedTemperature)
            {
                Console.WriteLine("Средняя температура в " + item.Key + " месяце: " + item.Value.ToString("0.0"));
            }

        }

        static double[] CalculateAverageTemperature(double[,] temperatures)
        {
            double[] averageTemperatures = new double[12];

            for (int i = 0; i < 12; i++)
            {
                double s = 0;
                for (int j = 0; j < 30; j++)
                {
                    s += temperatures[i, j];
                }

                averageTemperatures[i] = s / 30;
            }

            return averageTemperatures;
        }
    }
}

