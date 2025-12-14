using Tyuiu.IvanovMS.Sprint3.Task2.V19.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла do-while                                                 *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #19                                                             *");
        Console.WriteLine("* Выполнила: Иванов Максим Сергеевич | ПКТБ-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
        Console.WriteLine("* произведение ряда по формуле                                            *");
        Console.WriteLine("*       10                                                                *");
        Console.WriteLine("*       __                                                                *");
        Console.WriteLine("*  S = |  | cos i * 0.5                                                   *");
        Console.WriteLine("*      |  |                                                               *");
        Console.WriteLine("*      i=1                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int start = 1;
        int stop = 10;
        Console.WriteLine(ds.GetSumSeries(start, stop));
    }
}