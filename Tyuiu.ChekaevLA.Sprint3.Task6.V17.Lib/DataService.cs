namespace Tyuiu.ChekaevLA.Sprint3.Task6.V17.Lib
{
    public class DataService: tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task6V17
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int dels = 0;
            for (int i = startValue; i <= stopValue; i++)
            { 
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) 
                    { 
                        dels++;
                    }
                }
            }
            return dels;
        }
    }
}
