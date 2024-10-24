using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapovDY.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                double k = startValue;
                MultiplySeries *= Math.Pow((0.5 + k / 5) / (Math.Cos(value) + 0.5), 3);
                startValue++;
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
