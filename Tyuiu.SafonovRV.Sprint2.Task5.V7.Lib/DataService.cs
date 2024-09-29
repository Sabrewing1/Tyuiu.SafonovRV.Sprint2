using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SafonovRV.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            while (n > 12)
            {
                n = n - 12;
            }
            n += 0;
            string a;
            
            switch (n)
            {
                case 1:
                    a = "январь";
                    break;
                case 2:
                    a = "февраль";
                    break;
                case 3:
                    a = "март";
                    break;
                case 4:
                    a = "апрель";
                    break;
                case 5:
                    a = "май";
                    break;
                case 6:
                    a = "июнь";
                    break;
                case 7:
                    a = "июль";
                    break;
                case 8:
                    a = "август";
                    break;
                case 9:
                    a = "сентябрь";
                    break;
                case 10:
                    a = "октябрь";
                    break;
                case 11:
                    a = "ноябрь";
                    break;
                case 12:
                    a = "декабрь";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {n}");
                    
             
                
            }
            return a;
        }
    }
}
