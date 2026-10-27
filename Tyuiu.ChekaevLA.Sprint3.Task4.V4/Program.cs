using Tyuiu.ChekaevLA.Sprint3.Task4.V4.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 3 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=x/(cos(x)+sin(x))                                             *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* начальное x=-5                                                          *");
            Console.WriteLine("* конечное x=5                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.Calculate(-5, 5));

            Console.ReadKey();
        }
    }
}
