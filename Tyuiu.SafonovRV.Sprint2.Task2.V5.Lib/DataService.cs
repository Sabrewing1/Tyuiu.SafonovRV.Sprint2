using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SafonovRV.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;
            if ((x >= 3) && (x <= 12) && (y >= 3) && (y <= 12))
            {
                if ((x >= 3) && (x <= 4) && (y >= 6) && (y <= 8))
                {
                    return a = false;
                }
                if ((x >= 3) && (x <= 5) && (9 <= x) && (x <= 10) && (y == 13))
                {
                    return a = false;
                }
                if ((x == 12) && (y == 11))
                {
                    return a = false;
                }
                if ((x == 12) && (y >= 3) && (y <= 6))
                {
                    return a = false;
                }
                if ((x >= 6) && (x <= 10) && (y >= 3) && (y <= 5))
                {
                    return a = false;
                }

                return a;
            }
            else
            {
                return false;
            }
        }
    }
}

            
           
            
        
    

