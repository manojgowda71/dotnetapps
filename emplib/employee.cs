using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HolidayDal;

namespace emplib
{
    public class employee:person, employeecontract
    {
        static manojdbcontext dbContext=new manojdbcontext();
        public static List<Holidayemployee> get1()
        {

            return dbContext.Holiemployee.ToList() as List<Holidayemployee>;
        }
        public  static void insert(string pname, bool pisactive)
        {
            dbContext.Holiemployee.Add(new Holidayemployee() { empName = pname, isactive = pisactive });
            dbContext.SaveChanges();
        }
        public static void update(string pname, string pupdatedvalue)
        {

            var tobeupdated = dbContext.Holiemployee.ToList().Where((p) => p.empName == pname).FirstOrDefault();
            tobeupdated.empName = pupdatedvalue;
            dbContext.SaveChanges();
        }
        public static void delete(string pName)
        {
            var tobedeleted = dbContext.Holiemployee.ToList().Where((p) => p.empName == pName).FirstOrDefault();
            dbContext.Holiemployee.Remove(tobedeleted);
            dbContext.SaveChanges();
        }
        public static Holidayemployee SearchOne(string pname)
        {
            var result = dbContext.Holiemployee.ToList().Where(p => p.empName == pname).FirstOrDefault();
            return result as Holidayemployee;

        }

        public event EventHandler join;
        public event EventHandler resign;
        //ctor
        //call base con tructor
        public employee() : base()
        {
            this.viewcontract();
            this.sign();
            this.empid = new Random(1000).Next();
            //access utility function
            emputil.empcount++;
        }
        public void triggerjoinevents()
        {
            this.join.Invoke(this, null);
        }
        public void triggerjoinevents1()
        {
            this.resign.Invoke(this, null);
        }
        public employee(string padhar):this() 
        {
            this.aadhar= padhar;

        }

        public employee(string padhar,string pmobile):base(padhar,pmobile)
        {
            this.viewcontract();
            this.sign();
            this.empid = new Random(1000).Next();
            //access utility function
            emputil.empcount++;

        }


        private bool contractsigned=false;
        private bool hasreadcontract = false;

        public void sign()
        {
            contractsigned = true;
        }
        public void viewcontract()
        {
            hasreadcontract = true;
        }

        private int empid1;
    public int empid { get { return empid1; } private set { empid1 = value; } }
    public string designation { get; set; }
    public DateTime DOJ { get; set; }

    public bool isactive { get; set; }

    public double salary { get; set; }
    public string attendtraining(string ptraining) {
            return $"{this.Name} attended a training {ptraining} and he has assigned a role of {designation}";
        }

    public string filltimesheet(List<string> ptasks)
        {
            var csvtask = "";
            foreach (var task in ptasks)
            {
                csvtask = $"{csvtask},{task}";
            }
            return $"{this.Name} has worked on {csvtask} on {DateTime.Now.ToShortDateString()}";      

        }
        public override string work()
        {
            return $"{this.Name} with {this.empid} works for 8 hrs a day and travels 10hrs a  week";
        }
        public string work(string task)
        {
            return $"{this.Name} with {this.empid} has {task} assigned and he has to work";
        }
        public void settaxinfo(string taxinfo)
        {
            this.taxdetails= taxinfo ;
        }
        public string getaxinfo()
        {
            return $"{this.Name}: your tax details are:{this.taxdetails}";
        }
    }
}
