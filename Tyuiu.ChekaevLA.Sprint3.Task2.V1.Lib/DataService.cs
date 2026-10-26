namespace Tyuiu.ChekaevLA.Sprint3.Task2.V1.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task2V1
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            do 
            {
                sum += Math.Sin(startValue) * Math.Pow(0.5, 2);
                startValue++;
            }
            while(startValue<=stopValue);
            return sum;
        }
    }
}
