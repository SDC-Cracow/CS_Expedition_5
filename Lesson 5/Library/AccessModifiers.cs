using System;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers
namespace Library
{
    // // only inner classes can be private
    // private class PrivateClass
    // {
    // }

    public class PublicClass
    {
        // can be reached from other assembly
        public class PublicInnerClass { }

        // internal in assembly (inside assembly behave as public, outside as private)
        internal class InternalInnerClass { }

        // only inner classes can be private
        private class PrivateInnerClass { }
    }

    // internal in assembly (inside assembly behave as public, outside as private)
    internal class InternalClass
    {
        private readonly int _int = Int32.MaxValue;

        //public int I { get; } = _int;

        internal InternalClass()
        {
            _int = 0;
            //I = _int;
        }

        internal InternalClass(int a) : this()
        {
        }

        public bool PublicMethod()
        {
            return true;
        }

        internal bool InternalMethod()
        {
            return true;
        }

        private void Method()
        {
            // readonly fields can be assign only in constructor
            //_int = 0;

            // get only properties can be assign only in constructor
            //I = 1;
        }

        private bool PrivateMethod()
        {
            return true;
        }
    }
}