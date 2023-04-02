using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Run
    {
        static Func<float, float, float> Plus = (a, b) => a + b;
        static Func<float, float, float> Minus = (a, b) => a - b;
        static Func<float, float, float> Divide = (a, b) => a / b;
        static Func<float, float, float> Multiply = (a, b) => a * b;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>();

        static Run()
        {
            Operators.Add("-", Minus);
            Operators.Add("+", Plus);
            Operators.Add("/", Divide);
            Operators.Add("*", Multiply);
        }

        public static Func<float, float, float> OperationGet(string s)
        {
            return Operators.ContainsKey(s) ? Operators[s] : null;
        }
    }
}