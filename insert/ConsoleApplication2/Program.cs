using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створюємо масив з 20 рандомних чисел
            Random random = new Random();
            int[] nums = new int[20];
            //цикл який виводить поточний масив з рандомних чисел
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(random.Next(0, 100));
            }
            Console.WriteLine("Поточний масив: ");
            foreach (var tempArray in nums)
            {
                Console.Write(tempArray + " ");
            }
            //Сортує та виводить масив вставкою
            Console.WriteLine("\n" + "Відсортований масив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i]; //заповнюємо елемент
                int j = i - 1;//починати будемо з 1-го елементу
                while (j >= 0 && nums[j] > temp)
                // поки не досягли початку масиву 
                // чи не знайшли менший елемент масиву, який зберігається в змінній temp
                {
                    nums[j + 1] = nums[j];
                    //переміщаємо елемент вгору
                    j--;
                }
                nums[j + 1] = temp;
                // повертаємо i-1 елемент
            }
            // Виводимо відсортований масив 
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
