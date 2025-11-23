using Tyuiu.ChetvertnyhAI.Sprint5.Task1.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Произвести табулирование функции на заданном диапазоне [-5; 5] с        *");
        Console.WriteLine("* шагом 1. Произвести проверку деления на ноль. При делении на ноль       *");
        Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                *");
        Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль в таблицу. Значения округлить  *");
        Console.WriteLine("* до двух знаков после запятой.                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        DataService ds = new DataService();
        Console.WriteLine("startValue = " + startValue);
        Console.WriteLine("stopValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);
        

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}