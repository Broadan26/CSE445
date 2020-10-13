using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureConverter
{
    public class TemperatureConvert : ITemperatureConvert
    {
        public int c2f(int celsius) //Converts celsius to fahrenheit
        {
            int fahrenheit;
            fahrenheit = (int) (celsius * 1.8) + 32;

            return fahrenheit;
        }

        public int f2c(int fahrenheit) //Converts fahrenheit to celsius
        {
            int celsius;
            celsius = (int) ((fahrenheit - 32) / 1.8);

            return celsius;
        }
    }
}
