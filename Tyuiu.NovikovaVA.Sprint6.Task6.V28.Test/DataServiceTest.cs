using Tyuiu.NovikovaVA.Sprint6.Task6.V28.Lib;
namespace Tyuiu.NovikovaVA.Sprint6.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string path = @"C:\Users\User\source\repos\Tyuiu.NovikovaVA.Sprint6\DataSprint6\InPutDataFileTask6V28.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}