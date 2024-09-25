using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task7.V18.Lib
{
    public class DataService : ISprint3Task7V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            stopValue++;

            double[] ans = new double[stopValue - startValue];
            int pos = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                double d = Math.Cos(i / 180.0 * Math.PI) + i;
                if (d == 0)
                {
                    ans[pos++] = 0;
                    continue;
                }

                ans[pos++] = Math.Round((2 * i - 3) / d + 5, 3);
            }

            return ans;
        }
    }
}