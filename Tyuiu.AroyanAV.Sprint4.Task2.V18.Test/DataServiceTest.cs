using Tyuiu.AroyanAV.Sprint4.Task2.V18.Lib;

namespace Tyuiu.AroyanAV.Sprint4.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 7, 5, 6 };
            int expected = 12;

            int actual = ds.Calculate(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
