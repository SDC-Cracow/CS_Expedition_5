#define CSHARP6

#if CSHARP6

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        /// <summary>
        /// Auto-Property Initializers are C# 6.0
        /// We can initialize Properties, Fields (including Read-Only) using const variable
        /// </summary>
        private int IntAutoPoperty1 { get; set; } = constIntField;

        /// <summary>
        /// Auto-Property Initializers are C# 6.0
        /// We can initialize Properties, Fields (including Read-Only) using static variable
        /// </summary>
        private int IntAutoPoperty2 { get; set; } = staticIntField;

        /// <summary>
        /// read-only Auto-Properties are C# 6.0 Feature
        /// We can initialize Properties, Fields (including Read-Only) using const variable
        /// </summary>
        private int IntReadOnlyAutoPoperty1 { get; } = constIntField;

        /// <summary>
        /// read-only Auto-Properties are C# 6.0 Feature
        /// We can initialize Properties, Fields (including Read-Only) using static variable
        /// </summary>
        private int IntReadOnlyAutoPoperty2 { get; } = staticIntField;

        /// <summary>
        /// C# 6.0 and VB 14 - Language Feature - Constructor assignment to getter-only auto Property
        /// </summary>
        public int GetOnlyAutoProperty { get; }

        public CSharp_6()
        {
            // C# 6.0 and VB 14 - Language Feature - Constructor assignment to getter-only auto Property
            IntReadOnlyAutoPoperty1 = 5;
        }

        /// <summary>
        /// IndexInitializers are C# 6.0 Feature : Dictionary initializer
        /// Syntax sugar
        /// </summary>
        public void IndexInitializers()
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
        public double ExpressionProperty => ExpressionMethod(1, 5);

        /// <summary>
        /// Null Conditional Operators are C# 6.0 Feature
        /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#null-conditional-operators
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> NullConditionalOperators()
        {
            return this as IEnumerable<int> ?? new List<int>();
        }

        /// <summary>
        /// Interpolated String are C# 6.0 Feature
        /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#string-interpolation
        /// </summary>
        /// <returns></returns>
        public string StringInterpolation()
        {
            return $"{IntAutoPoperty1} : {intField2}";
        }

        /// <summary>
        /// Exception filters are C# 6.0 Feature
        /// </summary>
        /// <returns></returns>
        public static async Task<string> ExceptionFilters()
        {
            var client = new System.Net.Http.HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
        }

        /// <summary>
        /// nameof Expressions are C# 6.0 Feature
        /// </summary>
        /// <param name="param"></param>
        public void NameofExpressions(string param)
        {
            string nameofParam = nameof(param);
        }

        /// <summary>
        /// await in catch and finally blocks are C# 6.0 Feature
        /// </summary>
        public async Task AwaitInCatchAndFinallyBlocks()
        {
            try
            {
                await ExceptionFilters();
            }
            catch (Exception e)
            {
                await ExceptionFilters();
            }
            finally
            {
                await ExceptionFilters();
            }
        }

        public void ExtensionMethodsForCollectionInitializers()
        {
            // PLEASE LOOK AT
            // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#extension-add-methods-in-collection-initializers
        }

        public void ImprovedOverloadResolution()
        {
            // PLEASE LOOK AT
            // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#improved-overload-resolution
        }
    }
}

#endif