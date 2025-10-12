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
                    case 1: return $"{m}.01";
                    case 2: return $"{m}.02";
                    case 3: return $"{m}.03";
                    case 4: return $"{m}.04";
                    case 5: return $"{m}.05";
                    case 6: return $"{m}.06";
                    case 7: return $"{m}.07";
                    case 8: return $"{m}.08";
                    case 9: return $"{m}.09";
                    case 10: return $"{m}.10";
                    case 11: return $"{m}.11";
                    case 12: return $"{m}.12";
                    default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
                }
        }
    }
}
