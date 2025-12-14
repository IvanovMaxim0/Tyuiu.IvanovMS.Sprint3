using Tyuiu.IvanovMS.Sprint3.Task1.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла While                                                    *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
        Console.WriteLine("* ряда по формуле, при a = 1.5:                                           *");
        Console.WriteLine("*       20                                                                *");
        Console.WriteLine("*       __    k                                                           *");
        Console.WriteLine("*  S = |  | (a  + 0.5) * cos k                                            *");
        Console.WriteLine("*      |  |                                                               *");
        Console.WriteLine("*      k=1                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* a = 1.5                                                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        double a = 1.5; int startValue = 1; int stopValue = 20;
        Console.WriteLine(ds.GetSumSeries(a, startValue, stopValue));
    }
}