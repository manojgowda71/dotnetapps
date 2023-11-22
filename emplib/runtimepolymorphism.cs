using emplib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public class Father :talents  {
        public virtual string Settle()
        {
            return "get a government job and retire at 60";
        }
       public string getmarried()
        {
            return "arange marriag and settle abroad";
        }

        public override string whatisdating()
        {
            return "meeting special friend at restaurant and home";
        }

        public override string drwaing()
        {
            return "drawing portraits,tanjore paintings and beautiful landscapes";
        }
    }
    public abstract class talents
    {
        public abstract string whatisdating();
        public abstract string drwaing();

        public string getdetails()
        {
            return $"give me details of the employee";
        }
    }
    public class child : Father
{
        public override string whatisdating()
        {
            return "meeting special friend at an unknown place at an unlnown time";
        }

        public override string drwaing()
        {
            return "drawing  paintings of random person";
        }

        public override string Settle()
        {
            string howtolive = "get a fat salaried job in fortune 500 company, visit different countries";
            howtolive = $"{howtolive} and later follow this:{base.Settle()}";
            return howtolive;
        }
        new public string getmarried()
        {
            return "register marriage, surprise parents and settle abroad";
        }

    }
}
