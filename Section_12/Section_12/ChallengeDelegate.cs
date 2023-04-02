using System;


namespace Section_12
{
    public class Challenge_Delegate
    {
        public delegate float DelegateOper(float a, float b);

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static float Subtract(float a, float b)
        {
            return a - b;
        }


        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        public static float Divide(float a, float b)
        {
            return a / b;
        }

        public static float ApplyOperation(float a, float b, DelegateOper oper)
        {
            float result;

            result = oper(a, b);

            return result;
        }
    }
}