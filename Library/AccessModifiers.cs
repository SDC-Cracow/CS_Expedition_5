using System;

namespace Library
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers
    public class PublicClass
    {
        private class PrivateInnerClass { }

        public class PublicInnerClass { }

        internal class InternalInnerClass { }
    }

    internal class InternalClass
    {
        readonly int _int = Int32.MaxValue;

        //public int I { get; } = _int;

        InternalClass()
        {
            _int = 0;
            //I = _int;
        }

        InternalClass(int a) : this()
        {

        }

        void Method()
        {
            //_int = 0;
            //I = 1;
        }
    }

    //private class PrivateClass
    //{
    //}
}