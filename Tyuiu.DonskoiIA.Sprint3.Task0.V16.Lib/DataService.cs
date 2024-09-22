using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            stopValue++;
            double x = Convert.ToDouble(value);
            var ans = Math.Pow(x/startValue++, 3);
            for (int i = startValue; i < stopValue; i++)
            {
                ans *= Math.Pow(x / i, 3);
            }
            return ans;
        }
    }
}