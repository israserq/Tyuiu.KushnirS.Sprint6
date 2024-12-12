﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KushnirS.Sprint6.Task4.V17.Lib
{
    public class DataService : ISprint6Task4V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double F;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                F = Math.Round((Math.Sin(x)) / (x + 1.7) - Math.Cos(x) * 4 * x - 6, 2);
                valueArray[count] = F;
                count++;

            }
            return valueArray;
        }
    }
}