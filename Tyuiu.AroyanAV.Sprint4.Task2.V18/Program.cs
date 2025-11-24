using Tyuiu.AroyanAV.Sprint4.Task2.V18.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task2.V18
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.Title = "Спринт #4 | Выполнила: Ароян А. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 2 до 8 подсчитать произведение четных         *");
            Console.WriteLine("* элементов массива                                                       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len, i;
            Console.WriteLine("* Введите длину массива: ");
            len = int.Parse(Console.ReadLine());
            int[] nums = new int[len];
            for (i = 0; i < len; i++)
            {
                nums[i] = rnd.Next(2, 8);
            }
            Console.WriteLine("* Данный массив: "); ;
            for (i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(nums));
        }
    }
}