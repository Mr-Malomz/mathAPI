using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mathAPI.NetCore.Functions
{
    public static class Calculation
    {
        public static double BMICalc(double weight, double height, double power = 2)
        {
            double bmi = weight / Math.Pow(height, power);

            return bmi;
        }

        public static double AreaCalc(double length, double breath)
        {
            double area = length * breath;

            return area;
        }
    }
}
