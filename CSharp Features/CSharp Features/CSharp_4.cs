using System;

namespace CSharpFeatures
{
    /// <summary>
    /// Demonstrate key new C# 4.0 Features
    /// This features are available in Visual Studio 2010
    /// </summary>
    public class CSharp_4 : CSharp_3
    {
        /// <summary>
        /// Late Binding (dynamic) <br/>
        /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/dynamic
        /// </summary>
        public void LateBinding()
        {
            dynamic a = this;
            a = 4.0d;
            a = "string";
        }

        /// <summary>
        /// C# 4.0 Feature - we can use named arguments
        /// </summary>
        public void NamedArguments()
        {
            // we can puts arguments out of declaration order in method call
            // using named arguments
            Method(i: 5, d: 1.1, str: "string");
        }

        public void OptionalParameters()
        {
            // using optional parameters we can call function passing only required parameters
            Method("5");

            // if we like we can set value for optional parameters
            // without using named arguments we need set values in order of declaration
            Method("5", 1);
            Method("5", 1, 3d);

            // using named arguments we can pass values to parameters that we like
            // leaving rest with default values
            Method("5", d: 3d);
        }

        /// <summary>
        /// we can define default values for parameters "optional parameters"
        /// </summary>
        /// <param name="str">required</param>
        /// <param name="i">optional</param>
        /// <param name="d">optional</param>
        private void Method(string str, int i = Int32.MaxValue, double d = Double.NaN)
        {
            // ... do nothing 
        }
    }
}