using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpFeatures
{
    public static class ExtensionClass
    {
        /// <summary>
        /// Extension Methods are C# 3.0 Feature
        /// This features are available in Visual Studio 2008
        /// Introduced with Linq
        /// </summary>
        public static int ExtensionMethod(this int i)
        {
            return i;
        }

        /// <summary>
        /// Linq was introduced with C# 3.0
        /// it requires Extension Methods, Generics and Lambdas
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IEnumerable<int> ExtensionMethodLinq(this IEnumerable<int> enumerable)
        {
            // Lambdas also are C# 3.0 Feature
            return enumerable.Where(o => o < 0);
        }
    }

    /// <summary>
    /// Demonstrate key new C# 3.0 Features
    /// This features are available in Visual Studio 2008
    /// </summary>
    public class CSharp_3 : CSharp
    {
        // we can't initialize Auto-Property inline in C# 3.0
        private int IntAutoProperty { get; set; } // = 0;

        // in C# 3.0 it can be initialized only in constructors
        protected static int staticIntAutoProperty { get; set; } // =0;

        // readonly Auto-Properties are not available in C# 3.0
        //private int IntProperty2 { get; }

        static CSharp_3()
        {
            // static Auto-Properties can be initialized form static Constructor
            staticIntAutoProperty = constIntField;
            staticIntAutoProperty = staticIntField;
        }

        public CSharp_3()
        {
            // static Auto-Properties can be initialized form Constructor
            staticIntAutoProperty = constIntField;
            staticIntAutoProperty = staticIntField;
        }

        /// <summary>
        /// C# 3.0 Feature - we can use var keyword
        /// </summary>
        public void ImplicitTyping()
        {
            // var keyword was introduced in C# 3.0
            var variable = 0d;
        }

        public delegate int IntDeledate();

        /// <summary>
        /// C# 3.0 Feature - we can use lambdas
        /// </summary>
        public void LambdaExpressions()
        {
            IntDeledate intDeledate = () =>
            {
                int result = 2 + 2;
                return 8 + result;
            };

            Action lambda = () => { };
            Func<int> lambdaFunc = () => 0;
            Func<int, int> lambdaFuncParam = i => i * 2;
        }

        public void ArrayImplicitInitializer()
        {
            var arr = new[] { 1, 2 };
        }
    }
}