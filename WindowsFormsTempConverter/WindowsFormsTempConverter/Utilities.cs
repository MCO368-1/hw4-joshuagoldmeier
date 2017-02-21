using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTempConverter
{
    public enum TempUnits { Celsius, Kelvin, Fahrenheit };

    public class Utilities
    {
        public static double FahrenheitToCelsius(double temp)
        {
            return (temp - 32) / 1.8;
        }
        public static double CelsiusToFahrenheit(double temp)
        {
            return 9 / 5 * (temp) + 32;
        }
        public static double KelvinToCelsius(double temp)
        {
            return temp - 273.15;
        }
        public static double CelsiusToKelvin(double temp)
        {
            return temp + 273.15;
        }
        public static double FahrenheitToKelvin(double temp)
        {
            return (temp + 459.67) / 1.8;
        }
        public static double KelvinToFahrenheit(double temp)
        {
            return (temp * 1.8) - 459.67;
        }

        public static double universalConverter(TempUnits initial, TempUnits final, double temp)
        {

            if (initial == TempUnits.Celsius)
            {
                if (final == TempUnits.Celsius)
                {
                    return temp;
                }
                if (final == TempUnits.Fahrenheit)
                {
                    return CelsiusToFahrenheit(temp);
                }
                if (final == TempUnits.Kelvin)
                {
                    return CelsiusToKelvin(temp);
                }
            }
            if (initial == TempUnits.Fahrenheit)
            {
                if (final == TempUnits.Celsius)
                {
                    return FahrenheitToCelsius(temp);
                }
                if (final == TempUnits.Fahrenheit)
                {
                    return temp;
                }
                if (final == TempUnits.Kelvin)
                {
                    return FahrenheitToKelvin(temp);
                }
            }
            if (initial == TempUnits.Kelvin)
            {
                if (final == TempUnits.Celsius)
                {
                    return KelvinToCelsius(temp);
                }
                if (final == TempUnits.Fahrenheit)
                {
                    return KelvinToFahrenheit(temp);
                }
                if (final == TempUnits.Kelvin)
                {
                    return temp;
                }
            }

            return 2;
        }
    }
}
