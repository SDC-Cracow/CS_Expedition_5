using System;

namespace CSharpFeatures
{
    /// <summary>
    /// Delegates are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegate(int val);

    /// <summary>
    /// Delegates are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegateOut(out int val);

    /// <summary>
    /// Delegates are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public delegate int MyDelegateRef(ref int val);

    /// <summary>
    /// Interfaces are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public interface IInterface
    {
        int IntValue { get; }
    }

    /// <summary>
    /// Structures are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public struct Structure : IInterface
    {
        public int IntValue { get { return 2; } }
    }

    /// <summary>
    /// Attributes are C# 1.0 Feature
    /// </summary>
    [Author("John", version = 1.0d)]
    public class AttrClass { }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class Author : Attribute
    {
        public double version;

        private string name;

        public Author(string name)
        {
            this.name = name; version = 1.0;
        }
    }

    /// <summary>
    /// Classes are C# 1.0 Feature
    /// Feature are available in Visual Studio 2002
    /// </summary>
    public class Class : IInterface
    {
        public int IntValue { get { return 1; } }

        /// <summary>
        /// Operators are C# 1.0 Feature
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static int operator -(Class a)
        {
            return 5;
        }

        public static bool operator >(Class a, Class b)
        {
            return true;
        }

        public static bool operator <(Class a, Class b)
        {
            return !(a > b);
        }

        public static int operator +(Class a, Class b)
        {
            return 5;
        }

        public static int operator +(Class val, int w)
        {
            return 5;
        }
    }

    /// <summary>
    /// Demonstrate key new C# 1.0 Feature
    /// This features are available in Visual Studio 2002
    /// </summary>
    public class CSharp
    {
        public MyDelegate MyDelegate;
        public MyDelegateOut MyDelegateOut;
        public MyDelegateRef MyDelegateRef;

        /// <summary>
        /// we can initialize const field inline with value (literals)
        /// </summary>
        protected const int constIntField = 2;

        /// <summary>
        /// we can initialize static field inline with value (literals)
        /// </summary>
        protected static int staticIntField = 3;

        protected int intField;

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
        /// Events are C# 1.0 Feature
        /// </summary>
        public event MyDelegate MyDelegateEvent;

        public event MyDelegateOut MyDelegateEventOut;

        public event MyDelegateRef MyDelegateEventRef;

        /// <summary>
        /// Properties are C# 1.0 Feature
        /// </summary>
        public static int StaticIntProperty
        {
            get { return staticIntField; }
            set { staticIntField = value; }
        }

        /// <summary>
        /// Properties are C# 1.0 Feature
        /// </summary>
        public int IntProperty
        {
            get { return intField; }
            set { intField = value; }
        }

        /// <summary>
        /// readonly Property with backing field are C# 1.0 Feature
        /// </summary>
        public int IntReadOnlyProperty
        {
            get { return constIntField; }
        }

        /// <summary>
        /// set-only Property with backing field are C# 1.0 Feature
        /// </summary>
        public int IntSetOnlyProperty
        {
            set { intField = value; }
        }

        /// <summary>
        /// Delegates are C# 1.0 Feature
        /// </summary>
        public void DelegateAssignment()
        {
            MyDelegate myDelegate = MyDelegateMethod;
        }

        /// <summary>
        /// Show how to receive Attribute for given Type
        /// Also show usage of typeof operator C# 1.0 Feature
        /// </summary>
        public void GetAttributeUsage()
        {
            // Get instance of the attribute.
            Author author = (Author)Attribute.GetCustomAttribute(typeof(AttrClass), typeof(Author));

            //CSharp a = (new Class()) as CSharp;

            if (author != null)
            {
                // do something
            }
        }

        /// <summary>
        /// since C# 1.0 we can use out and ref to Method parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void OutAndRefParameters(out int a, ref int b)
        {
            a = 5;
            b = 8;
        }

        public void ArrayInitializer()
        {
            int[] arr = { 1, 2 };

            foreach (int i in arr) { }
        }

        private int MyDelegateMethod(int val)
        {
            return val;
        }
    }
}