namespace УП_1._1;

public class Program2
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