using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester.Classes
{
    public static class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        } 
        public static float Substract(float a, float b)
        {
            return a - b;
        } 
        public static float Divide(float a, float b)
        {
            if(b == 0)
            {
                throw new System.ArgumentException("You can not divide by 0");
            }
            return a / b;
        } 
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
    }
}
