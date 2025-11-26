using Tyuiu.AroyanAV.Sprint4.Task5.V5.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { -5, 2, -2, 8, 6 },
                                          { 5, -2, 5, 1, 6 },
                                          { 8, 3, -3, 5, 7 },
                                          { 1, 4, 2, -4, 5 },
                                          { 8, 8, 9, 5, 6 } };
            int res = ds.Calculate(mas);
            int wait = 104;
            Assert.AreEqual(res, wait);
        }
    }
}
