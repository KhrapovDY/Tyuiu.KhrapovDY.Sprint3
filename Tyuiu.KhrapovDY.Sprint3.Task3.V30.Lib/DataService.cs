using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapovDY.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int maxcount = 0;
            char item1 = '0';
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    if (item1 == item)
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }
                    if (count > maxcount)
                    {
                        maxcount = count;
                    }
                }
                else
                {
                    count = 0;
                }
                item1 = chr;
            }
            return maxcount;
        }
    }
}
