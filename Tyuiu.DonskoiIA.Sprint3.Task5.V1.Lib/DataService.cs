using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task5.V1.Lib
{
    public class DataService : ISprint3Task5V1
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            stopValue1++;
            stopValue2++;

            double ans = 0;

            for (int i = startValue1; i < stopValue1; i++)
            {
                for (int j = startValue2; j < stopValue2; j++)
                {
                    ans += 1 / (Math.Cos(j / 180.0 * Math.PI) + x);
                }
            }
            
            return Math.Round(ans, 3);

        }
    }
}