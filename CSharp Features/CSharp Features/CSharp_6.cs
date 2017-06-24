using System;
using System.Collections.Generic;

namespace CSharpFeatures
{
    // C# 6.0 - Language Feature : using static
    using static Math;

    /// <summary>
    /// Demonstrate key new C# 6.0 Features
    /// This features are available in Visual Studio 2015
    /// </summary>
    public class CSharp_6 : CSharp_5
    {
        // since C# 6.0 we can initialize Properties, Fields (including Read-Only) using const or static variable
        public int X1 { get; set; } = constIntField;

        public int X2 { get; } = constIntField;

        public int Z1 { get; set; } = staticIntField;
        public int Z2 { get; } = staticIntField;

        /// <summary>
        /// C# 6.0 and VB 14 - Language Feature - Constructor assignment to getter-only auto Property
        /// </summary>
        public int GetOnlyAutoProperty { get; }

        public CSharp_6()
        {
            // C# 6.0 and VB 14 - Language Feature - Constructor assignment to getter-only auto Property
            GetOnlyAutoProperty = 5;
        }

        /// <summary>
        /// C# 6.0 - Language Feature : Dictionary initializer
        /// Syntax sugar
        /// </summary>
        public void DictionaryInitializer()
        {
            // before C# 6.0 we can initialize Dictionary using {} brackets
            var dict_cs5 = new Dictionary<string, int>()
            {
                {"key1", 1},
                {"key2", 2}
            };

            // since C# 6.0 we can initialize Dictionary using [] brackets
            var dict_cs6 = new Dictionary<string, int>
            {
                ["key1"] = 1,
                ["key2"] = 2,
            };

            // //those can't be mixed up
            // var dict_mix = new Dictionary<string, int>
            // {
            //     {"key1", 1},
            //    ["key2"] = 2,
            // };
        }

        /// <summary>
        /// C# 6.0 - Language Feature : Expression-bodied members
        /// Method Expressions
        /// Syntax sugar for get
        ///
        /// public double ExpressionMethod(double a, double b)
        /// {
        ///    // C# 5.0 static method form System.Math
        ///    return System.Math.Max(a, b);
        ///
        ///    // C# 6.0 - Language Feature : Using static members
        ///    return Max(a, b);
        /// }
        /// </summary>
        public double ExpressionMethod(double a, double b) => Max(a, b);

        /// <summary>
        /// C# 6.0 - Language Feature : Expression-bodied members
        /// Property Expressions
        /// Syntax sugar for get
        ///
        /// public double ExpressionProperty
        /// {
        ///    get { return ExpressionMethod(roInt1, roInt2); }
        /// }
        /// </summary>
        public double ExpressionProperty => ExpressionMethod(roIntField, rostaticIntField);

        /// <summary>
        /// C# 6.0 Inline Declarations for Out Parameters
        /// Syntax sugar
        /// </summary>
        public void OutParametersInlineDeclaration()
        {
            // before C# 6.0 we need to declare variable before using it as a method parameter

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
            y = this.X2;
        }
    }
}