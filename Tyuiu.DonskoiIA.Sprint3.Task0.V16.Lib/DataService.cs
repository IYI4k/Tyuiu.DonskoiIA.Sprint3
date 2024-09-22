using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DonskoiIA.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x >= 0 && x <= Math.PI && y >= 0 && y <= 0.5 && y <= Math.Sin(x))
            {
                return true;
            }
            return false;
        }
    }
}