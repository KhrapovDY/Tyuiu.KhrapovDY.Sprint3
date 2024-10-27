using Tyuiu.KhrapovDY.Sprint3.Task3.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                      *");
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #30                                                                       *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y, находящихся     *");
            Console.WriteLine("* на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh                             *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + item);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Максимальное количество символов = " + ds.GetMaxCharCount(value, item));

            Console.ReadKey();
        }
    }
}
