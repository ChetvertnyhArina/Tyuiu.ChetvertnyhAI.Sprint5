using Tyuiu.ChetvertnyhAI.Sprint5.Task4.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формулу. Вычислить  *");
        Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после *");
        Console.WriteLine("* запятой) и вернуть полученный результат на консоль.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        
        DataService ds = new DataService();
        string path = @"C:\ТИУ\DataSprint5\InPutDataFileTask4V6.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine(res);
        
        Console.ReadKey();
    }
}