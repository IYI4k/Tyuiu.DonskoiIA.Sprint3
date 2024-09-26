using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task4.V6.Lib
{
    public class DataService : ISprint3Task4V6
    {
        /*private double dsin(double angle)
        {
            return (Math.Sin(angle / 180 * Math.PI));
        }
        private double dcos(double angle)
        {
            return (Math.Cos(angle / 180 * Math.PI));
        }*/

        public double Calculate(int startValue, int stopValue)
        {
            stopValue++;
            double ans = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                if (i == 0) break;
                //ans += i / (dcos(i) - dsin(i));
                ans += i / (Math.Cos(i) - Math.Sin(i));
            }

            return Math.Round(ans, 3);
        }
    }
}