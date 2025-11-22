using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutputFileTask0.txt";
            double y = Math.Log(((double)x + 1) / ((double)x + 2));
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
