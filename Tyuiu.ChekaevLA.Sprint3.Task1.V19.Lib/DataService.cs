namespace Tyuiu.ChekaevLA.Sprint3.Task1.V19.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multi = 1.0;
            while (startValue <= stopValue) 
            {
                multi *= Math.Cos(value) + startValue / 4.0;
                startValue++;
            }
            return Math.Round(multi,3);
        }
    }
}
