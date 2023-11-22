using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emplib
{
    public enum gender { 
        Male,female
    }

    public class person
    {
        public person()
        {

        }
        public person(string padhar) :this()
        {
            this.aadhar = padhar;
        }
        public person(string padhar, string pmobile): this(padhar)
        {
            this.mobilenumber = pmobile;
        }
        public string Name { get; set; }
        public string aadhar { get; set; }

        public string email { get; set;}

        public string address { get; set; }

        public string mobilenumber { get; set; }

        public DateTime DOB { get; set; }

        public string eat() {
            return $"{this.Name} eats breakfast, lunch, dinner";
        }

        public string sleep() {
            return $"{this.Name} sleep 8hrs a day";
        }

        public virtual string work() {
            return $"{this.Name} works 8 hrs a day";
        }
        public gender persongender { get; set; } 
        
        protected string taxdetails { get; set; }
    }
}
