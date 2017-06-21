using System.Linq;

namespace CS_Expedition_5
{
    /// <summary>
    /// This is only general algorithms tools static class
    /// </summary>
    public static class Tools
    {
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// You can define static fields but it is strongly recommended to not to do so
        /// </summary>
        public static int StsticIntField;

        /// <summary>
        /// Same as in field case
        /// <see cref="StsticIntField"/>
        /// </summary>
        public static int StaticIntProp { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = Tools.Max(0, 1);

            Tools.StsticIntField = 0;
            Tools.StaticIntProp = 1;

            // Example of static class and methods usage - Linq Expression 
            var arr = new[] { 0, 1, 0, };
            arr.Where(o => o > 0);
            Enumerable.Where(arr, o => o > 0);
        }
    }
}