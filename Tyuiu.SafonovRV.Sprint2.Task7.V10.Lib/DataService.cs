using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SafonovRV.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            {
                bool res;
                if ((y <= (2 - x * x)) && (y >= x) && (x <= 0))
                {
                    res = true;
                }
                if ((y <= (2 - x * x)) && (y > 0) && (x <= Math.Sqrt(2)))
                {
                    res = false;
                }
                else
                {
                    res = false;
                }
                return res;
            }
        }
    }
}
