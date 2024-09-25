using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DonskoiIA.Sprint3.Task6.V1.Lib
{
    public class DataService : ISprint3Task6V1
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int ans = stopValue++ - startValue + 1;
            if (startValue == 1) {
                startValue++;
                if (startValue==stopValue)
                {
                    return 1;
                }
            }
            for (int i = startValue; i < stopValue; i++)
            {
                int t = Convert.ToInt32(Math.Pow(i, 0.5)) + 1;
                for (int j = 2; j < t; j++)
                {
                    if (i % j == 0)
                    {
                        ans += j;
                    }
                }
                ans += i;
            }

            return ans;
        }
    }
}