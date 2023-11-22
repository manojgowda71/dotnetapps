using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace samplewebapp.Models
{
    public class person
    {
        [Required]
        public string adhar { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [Range(10, 110)]
        public int age { get; set; }
        [EmailAddress]
        public string email { get; set; }
    }
    public class personoperations
    {
      private  static List<person> _people = new List<person>();
        public static List<person> getpeople()
        {
            if (_people.Count == 0) {
                _people.Add(new person() { adhar = "aa217367214687", age = 25, email = "meena@gmail.com", name = "manna" });
                _people.Add(new person() { adhar = "bb217367214687", age = 20, email = "eena@gmail.com", name = "eena" });
                _people.Add(new person() { adhar = "cc217367214687", age = 27, email = "rteena@gmail.com", name = "rana" });
            }
            return _people;
        }
        public static List<person> getpeople2(int startage,int endage)
        {
            return getpeople().Where(p => p.age >= startage && p.age <= endage).ToList();
        }

        public static person search(string padhar)
        {
            return  getpeople().Where(p => p.adhar == padhar).FirstOrDefault();
        }

        internal static void createNew(person p)
        {
            getpeople();
            _people.Add(p);
        }
    }
}

