//#define CSHARP_EXPERIMANTAL

#if CSHARP_EXPERIMANTAL

namespace CSharpFeatures
{
    /// <summary>
    /// Demonstrate some Experimental C# Features
    /// This features are available in Visual Studio 2017
    /// </summary>
    public class CSharp_Experimantal(int x) // Experimental C# Feature Language Feature - Primary Constructor

    {
        // Primary Constructor variable usage
        private readonly int x = x;
    }

    // ---------------------------------------------------------------------
    // THOSE ARE FORBIDDEN AND ALWAYS WILL BE

    // we can't initialize const Field with static Field
    //private const int constIntField2 = staticIntField;

    // we can't define const Property
    // protected const int constIntProperty { get; set;}

    // we can't declare const readonly Field
    //private readonly const int constIntField3;
}

#endif