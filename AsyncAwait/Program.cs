// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void Method1()
{
    for(int i = 0; i < 1000; i++)
    {
        Console.WriteLine($"method 1:i={i}");
    }
}
void Method2()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"method 2:i={i}");
    }
}
await simpletask();

File.WriteAllText("SomeFile.txt", "EFJENFJEFNJEFN");
string contents = await ReadFile();
Console.WriteLine(contents);
async Task simpletask()
{
    Console.WriteLine("Starting of the task");
    await  Task.Delay(10000);
    Console.WriteLine("Task complete");
}
 async Task<string> ReadFile()
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt")) 
    {
        return await r.ReadToEndAsync();
    }
}
