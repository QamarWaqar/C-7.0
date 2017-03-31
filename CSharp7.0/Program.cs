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
            #region 2nd Feature: Patterns: "is" Clause
            // Previously you can only use "is" to check type of a variable //
            // Previously is clause can only have a type on its right hand side //
            // where as left hand side a Variable //
            if (typeof(Program) is int[]) { Console.WriteLine("This line of code will never execute."); }
            if (a is int[]) { Console.WriteLine("This line of code will never execute."); }
            // but now you can do 3 more things with "is" clause //
            // the right hand side of an is clause can have a pattern //
            // Constant Pattern //
            int? q = null;
            if (q is null) { Console.WriteLine("Yep q is null."); }
            // Type Pattern //
            if (q is int p) { Console.WriteLine("Just Declared a Variable p in local scope and this line is never going to be execute."); }
            // Last but not the least, you can use Patters in Switch's case //
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
