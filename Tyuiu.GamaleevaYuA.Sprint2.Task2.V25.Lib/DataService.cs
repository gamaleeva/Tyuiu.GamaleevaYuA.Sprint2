using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task2.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5 && y >= 3 && y <= 7) || (x >= 1 && x <= 12 && y >= 5 && y <= 6) || (x >= 9 && x <= 12 && y >= 3 && y <= 8) || (x >= 6 && x <= 13 && x >= 6 && x <= 8) || (x >= 6 && x <= 7 && y >= 9 & y <= 11) || (x >= 3 && y <= 7 && y == 11) || (x == 7 && y == 12) || (x >= 10 && x <= 11 && y >= 9 && y <= 11) || (x == 10 && y == 12))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
