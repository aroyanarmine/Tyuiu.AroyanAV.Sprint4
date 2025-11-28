using Tyuiu.AroyanAV.Sprint4.Task6.V15.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выполнила: Ароян А. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема:   класс Array                                                     *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Ароян Армине Вачагановна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [\"Чикаго\", \"Хьюстон\", \"Феникс\",       *");
        Console.WriteLine("* \"Филадельфия\", \"Сан-Антонио\", \"Сан-Диего\", \"Даллас\"] используя  *");
        Console.WriteLine("* класс Array подсчитайте количество элементов, длина которых меньше 7    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        var str = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i <= str.Length - 1; i++)
        {
            Console.WriteLine(str[i]);
        }
        int res = ds.Calculate(str);

        Console.WriteLine();
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine("Элементы массива, длина которых меньше 7: " + res);
        Console.ReadKey();
    }
}
