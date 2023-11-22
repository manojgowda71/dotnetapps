using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace employeecontroller.Models
{
    public class employee
    {
        [Key]
        [Required]
        public int empId { get; set; }
        [Required]
        [StringLength(50)]
        public string empName { get; set; }
        public bool isactive { get; set; }
        [EmailAddress]
        public string email { get; set; }
    }
    public class employeeoperations
    {
        private static List<employee> _employee1 = new List<employee>();
        public static List<employee> getemployee()
        {
            if (_employee1.Count == 0)
            {
                _employee1.Add(new employee() { empId = 140755, isactive=true, email = "harsha@gmail.com", empName = "harsha" });
                _employee1.Add(new employee() { empId = 140756, isactive = true, email = "gowtham@gmail.com", empName = "gowtham" });
                _employee1.Add(new employee() { empId = 140757, isactive = false, email = "dishanth@gmail.com", empName = "dishanth" });
            }
            return _employee1;
        }
       
        public static employee search(int pempid)
        {
            return getemployee().Where(p => p.empId ==pempid).FirstOrDefault();
        }

        internal static void createNew(employee p)
        {
            getemployee();
            _employee1.Add(p);
        }
    }
}
