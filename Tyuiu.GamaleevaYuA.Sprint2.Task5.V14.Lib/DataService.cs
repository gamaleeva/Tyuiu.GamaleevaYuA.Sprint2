using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GamaleevaYuA.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            int z = 1;
            string res = "";
            int x = d + k - 1;
            int p = 0;

            for (int i = 0; i < 53; i++)
            {
                z = i * 7 + 1;
                if (x == z)
                {
                    p = 1;
                    break;
                }
                else
                {
                    z = i * 7 + 2;
                    if (x == z)
                    {
                        p = 2;
                        break;
                    }
                    else
                    {
                        z = i * 7 + 3;
                        if (x == z)
                        {
                            p = 3; break;
                        }
                        else
                        {
                            z = i * 7 + 4;
                            if (x == z)
                            {
                                p = 4; break;
                            }
                            else
                            {
                                z = i * 7 + 5;
                                if (x == z)
                                {
                                    p = 5;
                                    break;
                                }
                                else
                                {
                                    z = i * 7 + 6;
                                    if (x == z)
                                    {
                                        p = 6;
                                        break;
                                    }
                                    else
                                    {
                                        z = (i * 7 + 7);
                                        if (x == z)
                                        {
                                            p = 7;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
            switch (p)
            {
                case 1:
                    res = "Понедельник";
                    break;
                case 2:
                    res = "Вторник";
                    break;
                case 3:
                    res = "Среда";
                    break;
                case 4:
                    res = "Четверг";
                    break;
                case 5:
                    res = "Пятница";
                    break;
                case 6:
                    res = "Суббота";
                    break;
                case 7:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException($"Дата или параметр первого дня недели введен некорректно. Значение {k},{d}");
            }
            return res;
        }
    }
}
