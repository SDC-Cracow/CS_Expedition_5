using System;

namespace CSharpFeatures
{
    /// <summary>
    /// Static Classes are C# 2.0 Feature
    /// </summary>
    public static class StaticClass
    {
    }

    /// <summary>
    /// Demonstrate key new C# 2.0 Features
    /// This features are available in Visual Studio 2005
    /// </summary>
    public class CSharp_2 : CSharp
    {
        /// <summary>
        /// Generics are C# 2.0 Feature
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GenericMethods<T>()
        {
            return (T)new object();
        }

        public class GenericInnerClass<T> { }

        public interface IGenericInterface<T> { }

        /// <summary>
        /// Anonymous Methods are C# 2.0 Feature
        /// </summary>
        public void AnonymousMethods()
        {
            MyDelegate myDelegate = delegate (int a) { return 0; };
        }

        /// <summary>
        /// Nullable Types are C# 2.0 Feature
        /// </summary>
        private int? NullableIntField1;

        /// <summary>
        /// Nullable Types are C# 2.0 Feature
        /// </summary>
        private Nullable<int> NullableIntField2;
    }
}