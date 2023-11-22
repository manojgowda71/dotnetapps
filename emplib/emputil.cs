using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public class emputil
    {
        public static List<employee> empdb { get; set; } = new List<employee>(); //list must be assigned like this
        public static int empcount { get; set; }
        public static void log<T>(T[] pvalues)
        {
            string result = "";
            foreach (var item in pvalues)
            {
                result = $"{result}{item}";
            }
            var finalresult = $"[{DateTime.Now.ToString()}]:{result}";
            //console logging
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------");
            Console.WriteLine(finalresult);

            //output window
            Debug.WriteLine("-----LOG-------");
            Debug.WriteLine(finalresult);
        }
    }
}
