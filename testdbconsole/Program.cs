// See https://aka.ms/new-console-template for more information
using TestDal;
using testdbconsole;

Console.WriteLine("Hello, World!");
CrudEF<parent>.add("likith", true);
CrudEF<parent>.add("nithu", false);
CrudEF<parent>.add("suni", false);
CrudEF<parent>.update("likith", "baby barbie");
CrudEF<parent>.add("vidya`", true);
CrudEF<parent>.delete("suni");
var result1 = CrudEF<parent>.SearchOne("nithu");
Console.WriteLine($"search matches:{result1.Name}");


//get records
CrudEF<parent>.get().ForEach((p) =>
{
    if (p.IsActive ==true )
        Console.WriteLine($"{p.Name} is an {p.IsActive} individual");
    else
        Console.WriteLine($"{p.Name} is a child");
});

