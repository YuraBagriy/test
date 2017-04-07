using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ініціалізуємо масив
            int[] nums = new int[20];
            //Створюєм об'єкт класу Random для подальшого заповнення масиву
            Random random = new Random();

            int x;
            int y;

            Console.WriteLine("Введiть найменше число, яке може бути в масивi: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть найбілше число, яке може бути в масивi: ");
            y = int.Parse(Console.ReadLine());

            //Заповнюємо масив випадковими числами
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(random.Next(x, y));
            }
            //Виводимо поточний заповнений масив
            Console.WriteLine("Ваш поточний, згенерований масив: ");
            foreach (var tempArray in nums)
            {
                Console.Write(tempArray + " ");
            }
            //Сортування
            //Змінні temp - тимчасова змінна для використання її в масиві
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    //Перевіряєм чи поточний елемент більший за наступний
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            //Виводимо відсортований масив
            Console.WriteLine("\n" + "Вiдсортований масив: ");
            foreach (var tempArray in nums)
            {
                Console.Write(tempArray + " ");
            }

            Console.WriteLine("\n" + "Натиснiть Enter для виходу з програми.");
            Console.ReadKey();
        }
    }
}