using Tyuiu.AroyanAV.Sprint4.Task1.V24.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int res = ds.Calculate(numsArray);
            int Wait = 84375;

            Assert.AreEqual(Wait, res);
        }
    }
}