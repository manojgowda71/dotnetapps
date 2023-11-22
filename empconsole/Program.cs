// See https://aka.ms/new-console-template for more informatio
using emplib;
using HolidayDal;
person manoj = new person();
manoj.Name = "manoj gowda";
Console.WriteLine(manoj.work());
person sneha = new person();
sneha.Name = "sneha gangaraju";
Console.WriteLine(sneha.eat());
person amelin = new person();
amelin.Name = "fernandes";
Console.WriteLine(amelin.sleep());

employee employee1= new employee();
employee1.Name = "manoj";
Console.WriteLine(employee1.attendtraining("on testing"));

employee employee2 = new employee();
employee2.Name = "manoj gowda";
List<string> ptasks= new List<string> { "dbms", "sql-queries", ".net& c#" };
Console.WriteLine(employee2.filltimesheet(ptasks));

person aish=new employee() {designation="intern",DOJ=DateTime.Now.AddMonths(-1) };
aish.Name = "aishwarya";
((employee)aish).designation = "analyst";
Console.WriteLine(aish.work());
Console.WriteLine(((employee)aish).attendtraining(" on azure"));
Console.WriteLine($"empid for {aish.Name} is {((employee)aish).empid}");

//polymorphism
Father sharmajiisfather=new Father();
Console.WriteLine($"sharmaji's father:{sharmajiisfather.Settle()}");
Console.WriteLine($"sharmaji's father gets married:{sharmajiisfather.getmarried()}");
Console.WriteLine($"sharmaji's father's concept of darwing(using abstract):{sharmajiisfather.drwaing()}");
Console.WriteLine($"sharmaji's father's concept of dating(using abstract):{sharmajiisfather.whatisdating()}");


Father sharmaji = new child();
Console.WriteLine($"sharmaji:{sharmaji.Settle()}");
Console.WriteLine($"sharmaji gets married:{((child)sharmaji).getmarried()}");
Console.WriteLine($"sharmaji's concept of darwing(using abstract):{sharmaji.drwaing()}");
Console.WriteLine($"sharmaji's concept of datting(using abstract):{sharmaji.whatisdating()}");





//no virtual, modification disallowed by class, force modify using "new" keyword.
child sharmaji2 = new child();
Console.WriteLine($"manoj gets married:{sharmaji2.getmarried()}");

//see overloading- compile -time polymorphism below
employee vidyasagar = new employee();
vidyasagar.Name = "vidyavahini";
vidyasagar.designation = "developer";
Console.WriteLine(vidyasagar.work());
Console.WriteLine(vidyasagar.work("solving bugs"));

//exposing non-public information through public methods
employee srikar =new employee();
srikar.Name = "raghu";
srikar.settaxinfo("i'm a eligible in the 20% tax payer category");
Console.WriteLine(srikar.getaxinfo());

//test calling one constructor from another
person rana = new person("561065898132aa", "+918105589217");
//this constructor should call the constructor that sets adar number
Console.WriteLine($"Aahar:{rana.aadhar} and mobile number:{rana.mobilenumber}");

employee dhanush = new employee("2057372837232aa", "+9187483472");
Console.WriteLine($"adhar:{dhanush.aadhar} and mobile number:{dhanush.mobilenumber}");
Console.WriteLine($" total count of employees is:{emputil.empcount}");

//adding employees to a temporary db - using static list<employee>
emputil.empdb.Add(srikar);
emputil.empdb.Add(dhanush);
emputil.empdb.Add(vidyasagar);
emputil.empdb.Add(new employee("aa3468237463278", "+91847827482") { Name = "honeymoon", designation = "analuysrt", salary = 600000 });
emputil.empdb.Add(new employee("cd3bcd8237463278", "+9183716371827482") { Name = "honey", designation = "analt2", salary = 700000 });
emputil.empdb.Add(new employee("aa3468237463278", "+77847827482") { Name = "salman", designation = "eating", salary = 900000 });
//get all employees whose aadhar card starts with aa
 var resultlist=emputil.empdb.Where((emp) =>emp.aadhar!=null && emp.aadhar.StartsWith("aa"));
resultlist.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.aadhar}"));
//get all employees with salary greater than 6l
var resultlist1 = emputil.empdb.Where((emp) => emp.salary != null && emp.salary > (600000));
resultlist1.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} has a designation of{emp.designation} with salary of{emp.salary}"));


employee.insert("shiva", true);
employee.insert("shivaram", false);
employee.get1().ForEach((p) =>
{
    if (p.isactive == true)
        Console.WriteLine($"{p.empName} is an {p.isactive} individual");
    else
        Console.WriteLine($"{p.empName} is a child");
});




