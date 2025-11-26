using Tyuiu.AroyanAV.Sprint4.Task5.V5.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Ароян А. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема:   двумерные массивы (генератор случайных чисел)                            *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                           *");
        Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -5 до 8. Найти сумму положительных *");
        Console.WriteLine("* элементов.                                                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 5;

        int[,] mtrx = new int[rows, columns];
        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i, j] = rnd.Next(-5, 9);
            }
        }

        Console.WriteLine("Массив 5x5 (случайные числа от -5 до 8):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("****************************************************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                                *");
        Console.WriteLine("********************************************************************************************************************************************");

        int res = ds.Calculate(mtrx);

        Console.WriteLine("Сумма положительных элементов = " + res);
        Console.ReadKey();
    }
}