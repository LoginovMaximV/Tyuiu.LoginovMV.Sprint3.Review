using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LoginovMV.Sprint3.TaskReview.V22.Lib
{
    public class DataService : ISprint3Task7V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueWa;
            int len = stopValue - startValue + 1;
            valueWa = new double[len];
            double res;
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round((Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x),2);
                valueWa[i] = res;
                i++;
            }
            return valueWa;
        }
    }
}
