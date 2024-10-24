﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhrapovDY.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            do
            {
                MultiplySeries = MultiplySeries * Math.Cos(value) + Math.Pow(startValue / 8, 3);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(MultiplySeries, 3);
        }
    }
}
