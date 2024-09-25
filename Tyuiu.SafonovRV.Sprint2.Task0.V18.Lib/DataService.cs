using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SafonovRV.Sprint2.Task0.V18.Lib
{
    public class DataService : ISprint2Task0V18
    {
        public bool[] GetCompareOperations(int x, int y)
        {
                bool[] res = new bool[6];

                res[0] = x == y;
                res[1] = x != y;
                res[2] = x < y + 4631;
                res[3] = x + 2 > y;
                res[4] = x <= y + 4630;
                res[5] = x - 4631 >= y;

                return res;
            }
    }
}
