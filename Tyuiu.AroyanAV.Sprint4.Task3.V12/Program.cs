using Tyuiu.AroyanAV.Sprint4.Task3.V12.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task3.V12
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Ароян А. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:   двумерные массивы (статический ввод)                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найдите минимальный элемент третьем столбце массива.                    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            int[,] mas = new int[5, 5] { { 9, 7, 4, 9, 7 },
                                          { 5, 2, 5, 7, 6 },
                                          { 8, 3, 3, 5, 7 },
                                          { 8, 4, 2, 4, 5 },
                                          { 8, 8, 9, 5, 6 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas);
            Console.WriteLine("Минимальный элемент в третьем столбце = " + res);
        }
    }
}