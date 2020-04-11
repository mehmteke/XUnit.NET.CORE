using System;
using System.Collections.Generic;
using System.Text;

namespace Calculations
{
    public class Calcolator
    {
        public string NickName { get; set; }
        public static int Add(int a, int b) {
            return a + b;
        }

        public static double AddDouble(double number1, double number2)
        {
            return number1 + number2;
        }

        public string MakeFullName(string name, string surname)
        {
            return $"{name}-{surname}";
        }
    }
}
