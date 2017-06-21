using System.Linq;
using Library;

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



            // access modifiers

            // public class form another assembly
            Library.PublicClass pc = new PublicClass();

            // public inner class form another assembly
            Library.PublicClass.PublicInnerClass pcic = new PublicClass.PublicInnerClass();

            // internal class from another assembly
            // is not visible in client application
            //Library.InternalClass ic = new InternalClass();

            // private inner class form another assembly
            // is not visible in client application
            //Library.PublicClass.PrivateInnerClass pcic1 = new PublicClass.PrivateInnerClass();

            // internal inner class form another assembly
            // is not visible in client application
            //Library.PublicClass.InternalInnerClass pcic2 = new PublicClass.InternalInnerClass();

        }
    }
}