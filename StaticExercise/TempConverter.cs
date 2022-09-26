using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double enteredNumber)
        {
            double celciusAnswer = enteredNumber - 32 * 5 / 9;
            return celciusAnswer;
        }
        public static double CelsiusToFahrenheit(double enteredNumber2)
        {
            double fahrenheitAnswer = enteredNumber2 * 9 / 5 + 32;
            return fahrenheitAnswer;
        }
    }
}
