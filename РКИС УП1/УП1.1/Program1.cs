namespace УП_1._1;

public class Program1
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
