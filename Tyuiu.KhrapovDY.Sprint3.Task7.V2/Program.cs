using Tyuiu.KhrapovDY.Sprint3.Task7.V2.Lib;

namespace Tyuiu.KhrapovDY.Sprint3.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Храпов Д. Ю. | СМАРТб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Оператор цикла while                                                        *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #2                                                                        *");
            Console.WriteLine("* Выполнил: Храпов Даниил Юрьевич | СМАРТб-24-1                                     *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции (произвести          *");
            Console.WriteLine("* (произвести  табулирование) f(x) = cos x / x - 0.7 - sin x * 12x + 2 на заданном  *");
            Console.WriteLine("* диапазоне [-5,5] с шагом 1. Произвести проверку деления на ноль. При делении на   *");
            Console.WriteLine("* ноль вернуть значение 0. Значение округлить до двух значений после запятой.       *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("+----------+-----------");
            Console.WriteLine("|    x     |   f(x)   |");
            Console.WriteLine("+----------+-----------");
            for (int i = 0;i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |   {1, 6:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------");
            Console.ReadKey();
        }
    }
}
