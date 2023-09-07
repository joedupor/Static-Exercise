using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {

        public static double FahrenheitToCelsius(double temp)
        {
            double convertedTemp = ((temp - 32) * 5) / 9;
            return convertedTemp;
        }


        public static double CelsiusToFahrenheit(double temp)
        {
            double convertedTemp = (((temp * 9) / 5)) + 32;
            return convertedTemp;
        }


    }
}
