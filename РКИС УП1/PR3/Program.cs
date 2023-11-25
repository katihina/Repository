// Задание 1:
using System.IO;

namespace PR3
{
    public class Program
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines("input.txt");
            string[] chosenNumbers = lines[0].Split(' ');

            int n = Convert.ToInt32(lines[1]);
            string[] tickets = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] ticketNumbers = lines[i + 2].Split(' ');
                int count = 0;

                for (int j = 0; j < 6; j++)
                {
                    if (Array.IndexOf(chosenNumbers, ticketNumbers[j]) != -1)
                    {
                        count++;
                    }
                }
            
                if (count >= 3)
                {
                    tickets[i] = "Lucky";
                }
                else
                {
                    tickets[i] = "Unlucky";
                }
            }

            File.WriteAllLines("output.txt", tickets);
        }
    }
}


// Задание 2:
using System.IO;

namespace PR3
{
    public class Program
    {
        public static void Main()
        {
            string[] numbers = File.ReadAllText("nums.txt").Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) % 2 == 0)
                {
                    numbers[i] = "";
                }
            }

            string result = string.Join(" ", numbers);
            File.WriteAllText("nums.txt", result);
        }
    }
}


// Задание 3:
using System.IO;

namespace PR3
{
    public class Program
    {
        public static void Main (string[] args)
        {
            string[] heightsStrings = File.ReadAllText("quantity.txt").Split(' ');
            int[] heights = Array.ConvertAll(heightsStrings, int.Parse);

            int maxArea = MaxArea(heights);
            Console.WriteLine("Наибольшее количество воды: " + maxArea);
        }

        public static int MaxArea(int[] height) 
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                int minHeight = Math.Min(height[left], height[right]);
                int currentArea = minHeight * (right - left);

                if (currentArea > maxArea)
                {
                    maxArea = currentArea;
                }

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }
    }
}

