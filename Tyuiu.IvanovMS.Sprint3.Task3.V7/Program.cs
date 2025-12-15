using Tyuiu.IvanovMS.Sprint3.Task3.V7.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выолнил: Иванов М. С. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла foreach                                                  *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Иванов Максим Сергеевич | ПКТБ-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4 в строке:            *");
        Console.WriteLine("* gft hggt ntg                                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string str = "gft hggt ntg";
        char replaceable = 'g';
        char replacement = '4';
        Console.WriteLine(ds.ReplaceCharOnNum(str, replaceable, replacement));
    }
}