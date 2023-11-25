// Задание 1:
namespace PR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
            }

            int min = numbers[0];
            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"Номер минимального элемента: {minIndex}");
        }
    }
}


// Задание 2:
namespace PR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int input;
            do
            {
                Console.Write("Введите число (для окончания введите 0): ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input != 0)
                {
                    numbers.Add(input);
                }
            } while (input != 0);

            if (numbers.Count > 0)
            {
                int sum = 0;
                int product = 1;

                foreach (int number in numbers)
                {
                    sum += number;
                    product *= number;
                }

                double average = (double)sum / numbers.Count;

                Console.WriteLine("Сумма всех чисел: " + sum);
                Console.WriteLine("Произведение всех чисел: " + product);
                Console.WriteLine("Среднее значение: " + average);
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
        }
    }
}


// Задание 3:
namespace PR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> elements = new List<string>();

            string input;
            do
            {
                Console.Write("Введите элемент списка (для завершения введите enter): ");
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    elements.Add(input);
                }
            } while (!string.IsNullOrWhiteSpace(input));

            if (elements.Count > 0)
            {
                string shortestElement = elements[0];
                string longestElement = elements[0];

                foreach (string element in elements)
                {
                    if (element.Length < shortestElement.Length)
                    {
                        shortestElement = element;
                    }

                    if (element.Length > longestElement.Length)
                    {
                        longestElement = element;
                    }
                }

                Console.WriteLine("Самый короткий элемент: " + shortestElement);
                Console.WriteLine("Самый длинный элемент: " + longestElement);
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
        }
    }
}


// Задание 4:
namespace PR1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите начало диапозона: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конец диапозона: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] numbers = new int[end - start + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(start, end + 1);
            }

            Console.Write("Случайные числа: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}

// Задание 5:
namespace PR1
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.WriteLine("Введите строку слов (через пробел): ");
            string word =  Console.ReadLine();
      
            string[] words = word.Split(' ');
      
            int wordСount = words.Length;
            string result = "start " + word + " end";
         
            Console.WriteLine(result);
            Console.WriteLine("Количество слов: " + wordСount);
        }
    }
}





 
