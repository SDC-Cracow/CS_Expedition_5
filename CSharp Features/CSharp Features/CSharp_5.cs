using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    /// <summary>
    /// Demonstrate key new C# 5.0 Features
    /// This features are available in Visual Studio 2012
    /// </summary>
    public class CSharp_5 : CSharp_4
    {
        /// <summary>
        /// <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/async">async</a> / 
        /// <a href="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/await">await</a> keywords and 
        /// <a href="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/index">programming-guide</a>
        /// </summary>
        public async void MethodVoidAsync()
        {
            await Task.Delay(10);
        }

        /// <summary>
        /// async / await keywords and pattern
        /// </summary>
        public async Task MethodTaskAsync()
        {
            await Task.Delay(10);
        }

        /// <summary>
        /// async / await keywords and pattern
        /// </summary>
        public async Task<int> MethodTaskIntAsync()
        {
            return await Task.FromResult(1);
        }

        /// <summary>
        /// Caller Information usage example
        /// </summary>
        public void DoProcessing()
        {
            // Sample Output:
            // message: Something happened.
            // member name: DoProcessing
            // source file path: c: \Users\username\Documents\Visual Studio 2012\Projects\CallerInfoCS\CallerInfoCS\Form1.cs
            // source line number: 31
            TraceMessage("Something happened.");
            MethodVoidAsync();
        }

        /// <summary>
        /// Caller Information C#
        /// </summary>
        /// <param name="message">Normal parameter</param>
        /// <param name="memberName">Name of caller method</param>
        /// <param name="sourceFilePath">Path to source file (from build machine)</param>
        /// <param name="sourceLineNumber">Call line number</param>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/caller-information"/>
        public void TraceMessage(string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0)
        {
            Trace.WriteLine("message: " + message);
            Trace.WriteLine("member name: " + memberName);
            Trace.WriteLine("source file path: " + sourceFilePath);
            Trace.WriteLine("source line number: " + sourceLineNumber);
        }
    }
}