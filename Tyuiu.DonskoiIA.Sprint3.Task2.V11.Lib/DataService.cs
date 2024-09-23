using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            stopValue++;
            double ans = 0;
            do
            {
                ans += Math.Pow(1.0 / (3 + Math.Pow(value, startValue)), startValue++);
            }
            while (startValue < stopValue);

            return Math.Round(ans, 3);
        }
    }
}