using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            stopValue++;
            var ans = Math.Pow(value, startValue++) + 0.5;
            for (int i = startValue; i < stopValue; i++)
            {
                ans *= Math.Pow(value, i) + 0.5;
            }
            return ans;
        }
    }
}