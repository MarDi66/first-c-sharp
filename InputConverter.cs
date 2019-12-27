using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argtextInput)
        {
            if (!double.TryParse(argtextInput, out double convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }
            return convertedNumber;
        }
    }
}
