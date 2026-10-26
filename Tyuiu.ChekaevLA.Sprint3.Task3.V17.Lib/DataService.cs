namespace Tyuiu.ChekaevLA.Sprint3.Task3.V17.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint3.ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            foreach(char c in value) 
            {
                if (!Char.IsDigit(c)) 
                {
                    value = value.Replace(c, ' ');
                }
            }
            return Convert.ToInt32(value);
        }
    }
}
