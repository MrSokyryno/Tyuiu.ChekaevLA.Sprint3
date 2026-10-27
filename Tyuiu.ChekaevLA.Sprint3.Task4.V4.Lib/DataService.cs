namespace Tyuiu.ChekaevLA.Sprint3.Task4.V4.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y = 0;
            for (;startValue<=stopValue; startValue++) 
            {
                y += startValue / (Math.Cos(startValue) + Math.Sin(startValue));
                if (startValue == 0) break;
            }
            return Math.Round(y,3);
        }
    }
}
