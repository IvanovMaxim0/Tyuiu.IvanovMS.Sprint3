using Tyuiu.IvanovMS.Sprint3.Task5.V16.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Вложенные циклы                                                         *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*        3    10                                                          *");
        Console.WriteLine("*       ___   ___            2                                            *");
        Console.WriteLine("*  y = |   | |   | cos(k) + x  , при x = 2                                *");
        Console.WriteLine("*      |   | |   |                                                        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*       i=1   k=1                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int x = 2;
        int start1 = 1;
        int start2 = 1;
        int stop1 = 3;
        int stop2 = 10;
        Console.WriteLine(ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
    }
}