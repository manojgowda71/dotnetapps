// See https://aka.ms/new-console-template for more information
using System;

partial class program
{
    //declaration
    delegate void compute(int n1, int n2);
    delegate void contractor(double budget);
    static void Main()
    {
        usinggenericdelegates2();

    }

    private static void usinggenericdelegates2()
    {
        Action<string, bool> work = new Action<string, bool>((work1, work2) =>
        {
            Console.WriteLine($"coding in c#:{work1} and {work2}");
        });
        Func<string, string> printing = (stringing) => $"output string is{stringing}";
        Predicate<string> updatebd = (v1) =>
        {
            if (v1 == null) return false;
            else return true;
        };
        work("manojgoda", false);
        Console.WriteLine(printing("sneha"));
        Console.WriteLine(updatebd(null));
    }

    private static void usinggenericdelegates()
    {
        Action<double> registermarriage = new Action<double>((budget) =>
        {
            Console.WriteLine($"registration fees:{budget * 95 / 100}");
            Console.WriteLine($"receiption fees:{budget * 95 / 100}");
        }
        );
        Func<int, int, string> modifiedcompute = (n1, n2) => $"addition:{n1 + n2}";
        modifiedcompute += (n1, n2) => $"subtraction:{n1 - n2}";
        Predicate<int> isactive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };
        //invoke all above delegates
        registermarriage(50000);
        Console.WriteLine(modifiedcompute(100, 200));
        Console.WriteLine($"output of predicate:{isactive(0)}");
    }

    private static void rockyranimarriagedelegate()
    {
        //instantiation
        contractor rockyranimarriage = new contractor((b) => Console.WriteLine($"pandit charges:{b * 20 / 100}"));
        rockyranimarriage += (b) => Console.WriteLine($"catering charges:{b * 50 / 100}");
        rockyranimarriage += (b) => Console.WriteLine($"mandap decoration:{b * 5 / 100}");
        rockyranimarriage += (b) => Console.WriteLine($"couple arrive in porsche reserved for 2 days:{b * 15 / 100}");
        rockyranimarriage(5000000);
    }

    private static void usinglamdas()
    {
        compute objshortcompute = new compute((a, b) => Console.WriteLine($"addition:{a + b}"));
        objshortcompute += (s, t) => Console.WriteLine($"subtraction:{s - t}");
        objshortcompute += (a, b) => Console.WriteLine($"multiplication:{a * b}");
        objshortcompute += (s, t) => Console.WriteLine($"division:{s / t}");

        //invocation like calling a function
        objshortcompute(20, 30);
    }

    private static void delegatesusinglongcutTechnique()
    {
        //instantiate
        compute objcompute = new compute(addfn);
        objcompute += subfn;
        objcompute += mulfn;
        objcompute += divfn;
        //invoke the delegate exactly like a function
        objcompute(100, 200);
    }

    static void addfn(int n1, int n2)
    {
        Console.WriteLine($"output of addition:{n1 + n2}");
    }



    static void subfn(int n1, int n2)
    {
        Console.WriteLine($"output of subtraction:{n1 - n2}");
    }



     static void mulfn(int n1, int n2)
    {

        Console.WriteLine($"output of multiplication:{n1 * n2}");
    }



     static void divfn(int n1, int n2)
    {

        Console.WriteLine($"output of division:{n1 / n2}");
    }
}
