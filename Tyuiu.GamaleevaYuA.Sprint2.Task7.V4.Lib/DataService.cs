using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task7.V4.Lib
{
    public class DataService : ISprint2Task7V4
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            return (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= 0) && (y <= 1) && (x <=1 ) && (x >= -1) && (Math.Pow(x, 2) + Math.Pow(y,2) >= 0.3*0.3);
        }
    }
}
