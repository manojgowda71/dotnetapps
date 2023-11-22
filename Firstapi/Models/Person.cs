using System.ComponentModel.DataAnnotations;

namespace Firstapi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Reflection.Metadata.Ecma335;


    public class Person
    {
        [Required]
        public string Aadhar { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [Range(18, 110)]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
    public class PersonOperations// this is an utility class
    {
        static List<Person> _people = new List<Person>();
        public static List<Person> GetPeople()
        {
            if (_people.Count == 0)
            {

                _people.Add(new Person() { Aadhar = "A28u92bjfhsfnjsd9u", Age = 25, Email = "vidya@gmail.com", Name = "Vidya" });
                _people.Add(new Person() { Aadhar = "SHt67232189ewrjvhb", Age = 24, Email = "sagar@gmail.com", Name = "Sagar" });
                _people.Add(new Person() { Aadhar = "GFSgw7y2843bh438y4", Age = 27, Email = "mc@gmail.com", Name = "mc" });
            }
            return _people;
        }


        public static Person Search(string pAadhar)
        {
            return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
        }
        public static List<Person> Age(int startAge, int endAge)
        {
            return GetPeople().Where(p => p.Age >= startAge && p.Age <= endAge).ToList();
        }

        internal static void CreateNew(Person p)
        {
            GetPeople();//get initial set of records
            _people.Add(p);
        }
        public static bool Update(string pAadhar, Person p)
        {
            var found = GetPeople().Where(p => p.Aadhar == p.Aadhar).FirstOrDefault();
            if (found != null)
            {
                found.Email = p.Email;
                found.Name = p.Name;
                found.Age = p.Age;
                return true;
            }
            else
                throw new Exception("No such records");

        }

        internal static bool Delete(string pAadhar)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                GetPeople().Remove(found);
                return true;//here return type is bool
            }
            else
                throw new Exception("no such record");
        }
    }

}