using System;

namespace CSharpFeatures
{
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

        // we can initialize normal Field with const Field
        private int IntField1 = constIntField;

        // we can initialize const Field with const Field
        private const int constIntField1 = constIntField;

        // we can initialize readonly Field with const Field
        private readonly int roIntField1 = constIntField;

        // we can initialize normal Field with static Field
        private int IntField2 = staticIntField;

        // we can initialize readonly Field with static Field
        private readonly int roIntField2 = staticIntField;

        // we can't initialize const Field with static Field
        //private const int constIntField2 = staticIntField;

        // we can't initialize Auto-Property
        //private int Intproperty1 { get; set; } = constIntField;

        // we can't define const Property
        // protected const int constIntProperty { get; set;}

        // we can't declare const readonly Field
        //private readonly const int constIntField3;

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