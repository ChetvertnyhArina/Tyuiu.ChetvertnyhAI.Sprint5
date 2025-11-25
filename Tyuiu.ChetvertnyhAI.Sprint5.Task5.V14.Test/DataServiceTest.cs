using Tyuiu.ChetvertnyhAI.Sprint5.Task5.V14.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\ТИУ\DataSprint5\InPutDataFileTask5V14.txt";
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }
}
