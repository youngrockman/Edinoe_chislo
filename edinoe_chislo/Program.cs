using System;


namespace edinoe_chislo
{
    class Program
    {
        static void Main()
        {
            // Ввод массива пользователем
            Console.WriteLine("Введите числа через пробел:");
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);

            // Поиск чисел, которые встречаются только один раз
            int first = 0, second = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    if (first == 0)
                    {
                        first = nums[i];
                    }
                    else
                    {
                        second = nums[i];
                    }
                }
            }

            // Вывод результата
            Console.WriteLine("Два числа, которые появляются только один раз: " + first + ", " + second);
        }
    }
}
