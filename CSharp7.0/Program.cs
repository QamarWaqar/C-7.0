using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7._0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1st Feature: out Variables Wild card and Parameter Declaration
            // Old way of calling an out variable Function //
            int a, b = 0;
            OutVarFunction(out a, out b);
            // This is new in C# 7.0 //
            // Now you can call an out Variable Function and //
            // Declare the variable right when you are calling the function //
            // Variable have to be modified before the function returns //
            OutVarFunction(out int c, out int d);
            // Keep in mind that c,d,e,f are now local variables of thie function //
            OutVarFunction(out var e, out var f);

            // the code underneath uses sterik as second parameter //
            // which means that I only care about first parameter, ignore the second one //
            // because the inner function will modify both variables any ways //
            // so I am ignoring the second one, what ever type or value it has before hand //
            // this is not yet supported but it's in focus //

            // OutVarFunction(out var g, out *);
            #endregion

        }
        #region 1st Feature: out Variables Wild card and Parameter Declaration
        static void OutVarFunction(out int y, out int x)
        {
            x = 0; y = 0;
            Console.WriteLine("The x is: " + x + "\nThe y is: " + y);
        }
        #endregion
    }
}
