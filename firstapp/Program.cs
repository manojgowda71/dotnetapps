// See https://aka.ms/new-console-template for more information
/*int num1 = 10;
int num2 = 10;  
Console.WriteLine("the sum is:" + (num1 + num2) + "\n");*/
using System.Diagnostics;

void conversionoftypes()
{
    int num3 = 100;
    double num4 = 120;
    bool isok=false;
    string str = "hello";
    string str1 = "100";
    var result1 = (double)num3;
    var result2 = (int)num4;

    //var result3=(string)isok; //string and int on bool cannot be used.
    var convert1=Convert.ToInt32(str1);
    var convert2=Convert.ToString(num3);
    //var convert3=Convert.ToInt32(str); //error at runtime
}
//conversionoftypes();
void workingwitharrays()
{
    int[] arr = new int[3];
    arr[0] = 1;
    arr[1] = 2;
    arr[2] = 3;

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    string[] greetings = { "hello", "namaskara", "vandanegalu" };
    int k = 0;
    while (k < greetings.Length)
    {
        Console.WriteLine(greetings[k]);
        k++;
    }
    int[] evens = { 2, 4, 6, 8, 10 };
    int j = 0;
    do
    {
        Console.WriteLine(evens[j]);
        j++;
    } while (j < evens.Length);
    object[] objarray = { 100, "ok", new int[] { 1, 2, 3 } };
    foreach (var singleitem in objarray)
    {
        if (singleitem.GetType().Name == "Int32[]")
        {
            foreach (var item in (Int32[])singleitem)
            {
                Console.WriteLine(item);

            }
        }
        else
        {
            Console.WriteLine($"simple item in {nameof(objarray)}:{singleitem}");
        }
    }
}

workingwitharrays();

void workingwithlists()
{
    List<string> shoppinglist = new List<string>();
    Console.WriteLine($"tOTAL ITEMS IN SHOPPING BAG:{shoppinglist.Count()}");
    shoppinglist.Add("bags1");
    log(new object[] { "ITEM ADDED:", shoppinglist[0] });
    shoppinglist.Add("bags2");
    log(new object[] { "ITEM ADDED:", shoppinglist[1] });
    shoppinglist.Add("bags3");
    log(new object[] { "ITEM ADDED:", shoppinglist[2] });
    printvalues(shoppinglist);
    Console.WriteLine($"total items in shopping bag:{shoppinglist.Count()}");
    shoppinglist.Remove("bags3");
    log(new object[] { "ITEM REMOVED:", "bags3" });
    Console.WriteLine($"total items in shopping bag:{shoppinglist.Count()}");
    print(new object[] { "comma-separated values of the shopping list",
        shoppinglist[0], 
        shoppinglist[1],
        "\n the total no of items is:",shoppinglist.Count()});
  
}
workingwithlists();

void printvalues<T>(List<T> pcollection)
{
    foreach (var item in pcollection)
    {
        Console.WriteLine(item);
        
    }
}
void print<T>(T[] pvalues)
{
    string result = "";
    foreach (var item in pvalues)
    {
        result = $"{result},{item}";   
    }
    result = result.TrimStart(',');
    Console.WriteLine(result);  
}
void log(object[] pvalues)
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

