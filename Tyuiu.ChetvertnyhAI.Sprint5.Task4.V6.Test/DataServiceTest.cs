using Tyuiu.ChetvertnyhAI.Sprint5.Task4.V6.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V6.txt";
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }
}
