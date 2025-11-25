using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task4.V6.Lib
{
    public class DataService : ISprint5Task4V6
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace(".", ",");
            double res = Math.Round(((1 / Math.Cos(Convert.ToDouble(strX))) + 2.2 * Math.Pow(Convert.ToDouble(strX), 2)), 3);
            return res;
        }
    }
}
