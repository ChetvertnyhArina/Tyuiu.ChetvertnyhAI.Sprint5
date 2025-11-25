using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ChetvertnyhAI.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            int maxDivisibleBy3 = int.MinValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');
                    foreach (string number in numbers)
                    {
                        if (double.TryParse(number, CultureInfo.InvariantCulture, out double num))
                        {
                            
                            double roundedNum = Math.Round(num, 3);
                            
                            if (Math.Abs(roundedNum - Math.Round(roundedNum)) < 1e-9)
                            {
                                int intNum = (int)Math.Round(roundedNum);
                                if (intNum % 3 == 0 && intNum > maxDivisibleBy3)
                                {
                                    maxDivisibleBy3 = intNum;
                                }
                            }
                        }
                    }
                }
            }
            if (maxDivisibleBy3 == int.MinValue)
                throw new Exception("Нет чисел, делящихся на 3.");

            
            BigInteger factorial = 1;
            for (int i = 2; i <= maxDivisibleBy3; i++)
            {
                factorial *= i;
            }
            return (double)factorial;
        }
    }
}
