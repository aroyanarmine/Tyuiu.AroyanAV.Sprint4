using Tyuiu.AroyanAV.Sprint4.Task7.V15.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int rows = 4;
            int colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "10293847";
            int res = ds.Calculate(rows, colums, str);
            int wait = 4;

            Assert.AreEqual(res, wait);
        }
    }
}
