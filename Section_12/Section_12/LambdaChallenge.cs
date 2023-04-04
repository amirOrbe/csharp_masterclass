using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class Run
    {
        private static readonly Dictionary<string, Func<float, float, float>> Dictionary = new Dictionary<string, Func<float, float, float>>();
        private static Func<float, float, float> plus = (a, b) => a + b;
        private static Func<float, float, float> minus = (a, b) => a - b;
        private static Func<float, float, float> divide = (a, b) => a / b;
        private static Func<float, float, float> multiply = (a, b) => a * b;
        private static Dictionary<string, Func<float, float, float>> operators = Dictionary;

        static Run()
        {
            operators.Add("-", minus);
            operators.Add("+", plus);
            operators.Add("/", divide);
            operators.Add("*", multiply);
        }

        public static Func<float, float, float>? OperationGet(string s)
        {
            return operators.ContainsKey(s) ? operators[s] : null;
        }
    }
}