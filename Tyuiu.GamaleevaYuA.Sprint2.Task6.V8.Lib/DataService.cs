using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n == 1)
            {
                m -= 1;
                if ((m == 1) || (m == 3) ||  (m==5) ||(m==7) || (m==8) || (m==10) || (m == 12))
                {
                    n = 31;
                }
                else if (m == 2)
                {
                    n = 28;
                }
                else
                {
                    n = 30;
                }
            }
            else
            {
                n -= 1;
            }
                switch (m)
                {
                    case 1: return $"{n} января";
                    case 2: return $"{n} февраля";
                    case 3: return $"{n} марта";
                    case 4: return $"{n} апреля";
                    case 5: return $"{n} мая";
                    case 6: return $"{n} июня";
                    case 7: return $"{n} июля";
                    case 8: return $"{n} августа";
                    case 9: return $"{n} сентября";
                    case 10: return $"{n} октября";
                    case 11: return $"{n} ноября";
                    case 12: return $"{n} декабря";
                    default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
        }
    }
}
