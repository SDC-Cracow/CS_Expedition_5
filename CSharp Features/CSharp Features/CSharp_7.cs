//#define CSHARP7

#if CSHARP7

using System;
using System.Collections.Generic;

namespace CSharpFeatures
{
    /// <summary>
    /// Demonstrate key new C# 7.0 Features
    /// This features are available in Visual Studio 2017
    /// </summary>
    public class CSharp_7 : CSharp_6
    {
        /// <summary>
        /// C# 7.0 Inline Declarations for Out Parameters
        /// Syntax sugar
        /// </summary>
        public void OutParametersInlineDeclaration()
        {
            // before C# 7.0 we need to declare variable before using it as a method parameter

            // inline declaration of int variable
            if (int.TryParse("256", out int i))
            {
                // we can use this variable
                Console.WriteLine(i);
            }

            // inline declaration of int by var keyword
            if (int.TryParse("256", out var v))
            {
                Console.WriteLine(v);
            }

            // we can use i variable later on in method (if scope allow)
            if (i != 0) { }
        }

        /// <summary>
        /// Tuples are C# 7.0 Feature
        /// </summary>
        protected internal void PrivateExternal_ProtectedInternal()
        {
            (string a, string b) myTuple = ("a", "b");

            var alphabetStart = (Alpha: "a", Beta: "b");

            (string First, string Second) firstLetters = (Alpha: "a", Beta: "b");

            var min = Range(1, 2, 4).Min;

            (double c, double d) = this;
        }

        private static (int Max, int Min) Range(params int[] numbers)
        {
            return Range(numbers as IEnumerable<int>);
        }

        private static (int Max, int Min) Range(IEnumerable<int> numbers)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (var n in numbers)
            {
                min = (n < min) ? n : min;
                max = (n > max) ? n : max;
            }
            return (max, min);
        }

        public void Deconstruct(out double x, out double y)
        {
            x = this.X1;
            y = this.IntReadOnlyAutoProperty;
        }
    }
}

#endif