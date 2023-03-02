using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        public static int Add(int num1, int num2)
        {
            return checked ( num1 + num2 );
        }

        public static int Subtract(int num1, int num2)
        {
            return checked ( num1 - num2 );
        }

        public static int Multiply(int num1, int num2)
        {
            return checked ( num1 * num2 );
        }

        public static int Divide(int num1, int num2)
        {
            try
            {
                return checked ( num1 / num2 );
            }
            catch
            {
                throw new ArgumentException("Can't divide by zero");
            }
        }

        public static int Modulus(int num1, int num2)
        {
            try
            {
                return checked ( num1 % num2 );
            }
            catch
            {
                throw new ArgumentException("Can't modulo by zero");
            }
        }
    }
}
