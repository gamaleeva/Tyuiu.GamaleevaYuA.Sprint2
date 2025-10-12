using Tyuiu.GamaleevaYuA.Sprint2.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи         *");
        Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("Введите день: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер месяца: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if ((x <= 31)&&(x>=1)&&(y >= 1)&&(y<=12))
        {
            string res = ds.FindDateOfPreviousDay(x, y);
            Console.WriteLine("Прошлый день: " + res);
        }
        else
        {
            Console.WriteLine("Значения введены некорректно");
        }
        Console.ReadKey();
    }
}