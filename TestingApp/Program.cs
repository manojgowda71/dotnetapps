
using System;
namespace TestingApp
{
    public class Program
    {   
        
        public void Method1()
        {
            Console.WriteLine($"I'm a part time driver working in bengaluru");
        }
        public void Method2()
        {
            Console.WriteLine($"I'm a part time driver working in mangalore");
        }
        public void Method3()
        {
            Console.WriteLine($"I'm a part time driver working in mysore");
        }
        public void Method4()
        {
            Console.WriteLine($"I'm a part time driver working in tumkur");
        }
        public static void Test123()
        {
            Program manoj = new();
            manoj.Method1();
        }

    }

}


