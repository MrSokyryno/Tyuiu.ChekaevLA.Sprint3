using Tyuiu.ChekaevLA.Sprint3.Task5.V16.Lib;

namespace Tyuiu.ChekaevLA.Sprint3.Task5.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();

            Console.Title = "Спринт 3 | Выполнил: Чекаев Л. А.| АСОИУб-1-26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Чекаев Л. А.| АСОИУб-1-26                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* (сумма от i = 1 до 3) ((сумма от k = 1 до 10) (cos(k))) + x^2 при X = 2 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X=2                                                                     *");
            Console.WriteLine("* начальное i=1                                                           *");
            Console.WriteLine("* конечное i=3                                                            *");
            Console.WriteLine("* начальное k=1                                                           *");
            Console.WriteLine("* конечное k=10                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(dataService.GetSumSumSeries(2,1,1,3,10));

            Console.ReadKey();
        }
    }
}
