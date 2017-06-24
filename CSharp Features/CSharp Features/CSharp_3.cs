using System;

namespace CSharpFeatures
{
    /// <summary>
    /// Delegates are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegate(int val);

    /// <summary>
    /// Delegates are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegateRef(ref int val);

    /// <summary>
    /// Delegates are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegateOut(out int val);

    /// <summary>
    /// Interfaces are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public interface IInterface
    {
        int IntValue { get; }
    }

    /// <summary>
    /// Classes are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public class Class : IInterface
    {
        public int IntValue { get { return 1; } }
    }

    /// <summary>
    /// Structures are C# 1.0 Features
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public struct Structure : IInterface
    {
        public int IntValue { get { return 2; } }
    }

    /// <summary>
    /// Demonstrate key new C# 1.0 Features
    /// This features are available in Visual Studio 2002
    /// </summary>
    public class CSharp
    {
        public MyDelegate MyDelegate;

        public MyDelegateRef MyDelegateRef;

        public MyDelegateOut MyDelegateOut;

        /// <summary>
        /// Events are C# 1.0 Feature
        /// </summary>
        public event MyDelegate MyDelegateEvent;

        public event MyDelegateRef MyDelegateEventRef;

        public event MyDelegateOut MyDelegateEventOut;

        /// <summary>
        /// we can initialize const field inline with value (literals)
        /// </summary>
        protected const int constIntField = 2;

        /// <summary>
        /// we can initialize static field inline with value (literals)
        /// </summary>
        protected static int staticIntField = 3;

        // readonly Property with backing field are available in C# 3.0
        public int IntReadOnlyProperty
        {
            get { return constIntField; }
        }

        protected int intField;

        public int IntProperty
        {
            get { return intField; }
            set { intField = value; }
        }

        public static int StaticIntProperty
        {
            get { return staticIntField; }
            set { staticIntField = value; }
        }

        /// <summary>
        /// Static constructor is called before first use of class
        /// in C# in static Constructor we can initialize static Properties
        /// </summary>
        static CSharp()
        {
            // only static Fields and Properties can be initialized from static Constructor
            StaticIntProperty = 0;
            StaticIntProperty = staticIntField;

            // non static (normal) Fields and Properties can't be initialized from static Constructor
            //IntProperty = 0;
        }

        public CSharp()
        {
            // static Fields and Properties can be initialized from Constructor
            staticIntField = 0;
            StaticIntProperty = 0;

            // non static (normal) Fields and Properties can be initialized from Constructor
            intField = 0;
            IntProperty = 0;
        }

        /// <summary>
        /// since C# 1.0 we can use out and ref to Method parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Method(out int a, ref int b)
        {
            a = 5;
            b = 8;
        }

        public void DelegateAssignment()
        {
            MyDelegate myDelegate = MyDelegateMethod;
        }

        private int MyDelegateMethod(int val)
        {
            return val;
        }
    }

    /// <summary>
    /// Demonstrate key new C# 2.0 Features
    /// This features are available in Visual Studio 2005
    /// </summary>
    public class CSharp_2 : CSharp
    {
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
    }
}