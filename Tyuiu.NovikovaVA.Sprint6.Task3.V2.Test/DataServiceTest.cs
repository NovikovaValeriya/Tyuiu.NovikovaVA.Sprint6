using Tyuiu.NovikovaVA.Sprint6.Task3.V2.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5]  {{-12, -4, -20, 5, -5},{2, 15, 1, -20, 7},{15, -15, 2, 11, 5},{-19, -9, 16, 0, 1},{17, 16, 5, 12, -8}};
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { 0, 0, 0, 5, -5 }, { 2, 15, 1, -20, 7 }, { 15, -15, 2, 11, 5 }, { -19, -9, 16, 0, 1 }, { 17, 16, 5, 12, -8 } };
            CollectionAssert.AreEqual(mas2, wait);
        }
    }
}