using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AroyanAV.Sprint4.Task2.V18.Lib
{
    public class DataService : ISprint4Task2V18
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length == 0) return 0;
            int product = 1;

            foreach (int number in array)
            {
                if (number % 2 == 0) product *= number;
            }

            return product;
        }
    }
}