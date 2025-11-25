using Tyuiu.ChetvertnyhAI.Sprint5.Task6.V14.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string path = @"C:\ТИУ\DataSprint5\InPutDataFileTask6V14.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }




        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\ТИУ\DataSprint5\InPutDataFileTask6V14.txt";
            FileInfo FileInfo = new FileInfo(path);
            bool FileExist = File.Exists(path);
            Assert.AreEqual(true, FileExist);
        }
    }





}
