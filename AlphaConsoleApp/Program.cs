using System;

namespace AlphaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 10;
            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = random.Next(1, 100);

            Array.Sort(nums);
            Array.Reverse(nums);

            Console.WriteLine("Рандомный отсортированный по убыванию массив целых чисел:");
            foreach (int i in nums) Console.Write($"{i} ");

            Console.Write("\n\nВведите целое число(X): ");
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                bsearch(nums, x);
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не корректные данные!");
            }            
        }

        private static int bsearch(int[] nums, int x)
        {
            int res = 0;
            bool check = false;
            foreach(int i in nums)
            {                
                if (i < x)
                {
                    check = true;
                    res = Array.IndexOf(nums, i);
                    Console.WriteLine($"Индекс первого элемента массива, строго меньшего {x}: {res} (число {i})");
                    break;
                }                
            }
            if (!check)
                Console.WriteLine($"В массиве нет элементов меньше {x}");

            return res;
        }
    }
}
