using Tyuiu.AroyanAV.Sprint4.Task0.V18.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] a = { 9, 8, 7, 6, 5, 7, 3, 2, 7, 3 };
            int res = ds.GetSumOddArrEl(a);
            int wait = 41;
            Assert.AreEqual(res, wait);
        }
    }
}
