using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task3.V23.Lib
{
    public class DataService : ISprint2Task3V23
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x >0)
            {
                y = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if ( x == 0)
            {
                y = (Math.Pow(x, 2) + Math.Cos(x * x) - 17) / ((Math.Pow(x, 2) - Math.Sin(x * x) + 3));
            }
            else if ((x < 2) && (x > -27))
            {
                y = Math.Pow(3 + 1 / Math.Pow(x, 2), 2);
            }
            else if (x < -27)
            {
                y = x + 10 * x - (1 / (x * x));
            }
            return Math.Round(y, 3);
        }
    }
}
