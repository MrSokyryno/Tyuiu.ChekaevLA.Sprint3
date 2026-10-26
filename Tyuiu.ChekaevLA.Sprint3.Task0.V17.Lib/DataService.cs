namespace Tyuiu.ChekaevLA.Sprint3.Task0.V17.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for(int i=startValue; i<=10; i++) 
            {
                sum += Math.Cos(i) * 0.5;
            }
            return Math.Round(sum,3);
        }
    }
}
