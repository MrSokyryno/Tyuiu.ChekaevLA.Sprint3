using Tyuiu.ChekaevLA.Sprint3.Task7.V27.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 3 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = cos(x)/(x+1) - cos(x) * 1,3 + 3x(произвести табулирование) на    *");
            Console.WriteLine("* заданном диапазоне [-5; 5] с шагом 1. Произвести проверку деления на    *");
            Console.WriteLine("* ноль. При делении на ноль вернуть значение 0. Значения округлить до двух*");
            Console.WriteLine("* знаков после запятой                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X=[-5,5]                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X \t f(X)");

            int n = -5;
            foreach (double i in dataService.GetMassFunction(-5, 5)) 
            {
                Console.WriteLine($"{n} \t {i}");
                n++;
            }

            Console.ReadKey();
        }
    }
}
