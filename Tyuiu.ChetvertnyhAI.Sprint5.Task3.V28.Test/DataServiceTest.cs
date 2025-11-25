using Tyuiu.ChetvertnyhAI.Sprint5.Task3.V28.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }
}
