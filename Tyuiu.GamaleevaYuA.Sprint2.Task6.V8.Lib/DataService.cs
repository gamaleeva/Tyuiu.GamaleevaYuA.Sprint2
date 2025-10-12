using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (m == 1)
            {
                n -= 1;
                if ((n == 1) || (n == 3) ||  (n ==5) ||(n==7) || (n ==8) || (n==10) || (n == 12))
                {
                    m = 31;
                }
                else if (n == 2)
                {
                    m = 28;
                }
                else
                {
                    m = 30;
                }
            }
            else
            {
                m -= 1;
            }
                switch (n)
                {
                    case 1: return $"{m} января";
                    case 2: return $"{m} февраля";
                    case 3: return $"{m} марта";
                    case 4: return $"{m} апреля";
                    case 5: return $"{m} мая";
                    case 6: return $"{m} июня";
                    case 7: return $"{m} июля";
                    case 8: return $"{m} августа";
                    case 9: return $"{m} сентября";
                    case 10: return $"{m} октября";
                    case 11: return $"{m} ноября";
                    case 12: return $"{m} декабря";
                    default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
                }
        }
    }
}
