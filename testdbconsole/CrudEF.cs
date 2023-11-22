using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDal;

namespace testdbconsole
{
    public class CrudEF<T> where T:parent
    {
        static  TestDbContext dbContext = new TestDbContext();
        public static void add(string pname, bool pisactive) {
            dbContext.parents.Add(new parent() { Name = pname, IsActive = pisactive });
            dbContext.SaveChanges();
        }
        public static void update(string pname, string pupdatedvalue) {

            var tobeupdated = dbContext.parents.ToList().Where((p) => p.Name == pname).FirstOrDefault();
            tobeupdated.Name = pupdatedvalue;
            dbContext.SaveChanges();
        }

        public static List<T> get() {
        
            return dbContext.parents.ToList() as List<T>;
        }
        public static T SearchOne(string pname) 
        {
          var result=dbContext.parents.ToList().Where(p => p.Name == pname).FirstOrDefault();
            return result as T;

        }
        public static void delete(string pName) {
            var tobedeleted = dbContext.parents.ToList().Where((p) => p.Name == pName ).FirstOrDefault();
            dbContext.parents.Remove(tobedeleted);
            dbContext.SaveChanges();
        }

    }
}
