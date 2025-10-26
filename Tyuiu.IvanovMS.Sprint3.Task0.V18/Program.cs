using Tyuiu.IvanovMS.Sprint3.Task0.V18.Lib;
class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Оператор цикла for                                                      *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнила: Иванов Максим Сергеевич | ПКТБ-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение   *");
        Console.WriteLine("* ряда по формуле, при x = 1:                                             *");
        Console.WriteLine("*       6                                                                 *");
        Console.WriteLine("*       __         2      k                                               *");
        Console.WriteLine("*  P = |  | ( ---------- )                                                *");
        Console.WriteLine("*      |  |   cosx + 0.5                                                  *");
        Console.WriteLine("*      k=1                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* x = 1                                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int start = 1;
        int stop = 6;
        int x = 1;
        Console.WriteLine(ds.GetMultiplySeries(x, start, stop));
    }
}