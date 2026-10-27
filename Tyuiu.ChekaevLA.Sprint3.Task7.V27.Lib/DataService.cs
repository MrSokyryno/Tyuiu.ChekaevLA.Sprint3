namespace Tyuiu.ChekaevLA.Sprint3.Task7.V27.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mass = new double[stopValue-startValue+1];
            int n = -1;
            for (double i = startValue; i<=stopValue; i++) 
            {
                n++;
                if (i==-1.0) mass[n] = 0.0;
                else
                {
                    mass[n] = (Math.Round(Math.Cos(i) / (i + 1) - Math.Cos(i) * 1.3 + 3*i , 2));
                }
            }
            return mass;
        }
    }
}
