using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AroyanAV.Sprint4.Task4.V22.Lib
{
    public class DataService : ISprint4Task4V22
    {
        public int[,] Calculate(int[,] matrix)
        {
            int str = matrix.GetUpperBound(0) + 1;
            int stolb = matrix.Length / str;

            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;

        }
    }
}
