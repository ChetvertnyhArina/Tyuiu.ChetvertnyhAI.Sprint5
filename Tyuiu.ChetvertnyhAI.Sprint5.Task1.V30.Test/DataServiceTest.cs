using Tyuiu.ChetvertnyhAI.Sprint5.Task1.V30.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\chetv\source\repos\Tyuiu.ChetvertnyhAI.Sprint5\Tyuiu.ChetvertnyhAI.Sprint5.Task1.V30\bin\Debug\net8.0\OutputFileTask1.txt";
            
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
