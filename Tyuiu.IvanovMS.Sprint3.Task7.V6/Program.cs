using Tyuiu.IvanovMS.Sprint3.Task7.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
        Console.WriteLine("* F(x) = 3cos(x)/4x-0.5+sin(x)-5x-2  (произвести табулирование) f(x) на   *");
        Console.WriteLine("* заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на    *");
        Console.WriteLine("* ноль. При делении на ноль вернуть значение 0.Значения округлить до двух *");
        Console.WriteLine("* знаков после запятой.                                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int start = -5;
        int stop = 5;

        Console.WriteLine("Старт шага = " + start);
        Console.WriteLine("Конец шага = " + stop);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|     X    |   f(x)   |");
        Console.WriteLine("+----------+----------+");
        int len = ds.GetMassFunction(start, stop).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(start, stop);

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1, 6:f2}  |", start, valueArray[i]);
            start++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();

    }
}