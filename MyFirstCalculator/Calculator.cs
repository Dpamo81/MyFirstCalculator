using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static int Sum(int value1, int value2)
        {
            int result = value1 + value2;
            return result;
        }
        public static int Substraction(int value1, int value2)
        {
            int result = value1 - value2;
            return result;
        }
        public static int Multiplication(int value1, int value2)
        {

            int result = value1 * value2;
            return result;
        }
        public static int Division(int value1, int value2)
        {

            int result = value1 / value2;
            return result;
        }
    }
}
