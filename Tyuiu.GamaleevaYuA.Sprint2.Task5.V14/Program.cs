using Tyuiu.GamaleevaYuA.Sprint2.Task5.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #2 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
        Console.WriteLine("* требуемое значение и возвращает результат.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x, y;
        Console.WriteLine("Введите день месяца: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер дня недели первого дня года: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if ((x <= 365) && (x >= 1) && (y >= 1) && (y <= 7))
        {
            string res = ds.FindDayName(x, y);
            Console.WriteLine("День недели: " + res);
        }
        else
        {
            Console.WriteLine("Значения введены некорректно");
        }
        Console.ReadKey();


    }
}