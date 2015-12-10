using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary.DataLayer
{
    class EmployeeTypeDA: Common //:DbMethods
    {
        MainDbContext dbContext;
        Common common;

        public EmployeeTypeDA()
        {
            dbContext = new MainDbContext();
            common = new Common();
        }

        public List<Employee_Type> getAll()
        {
            //List<Employee_Type> tt=dbContext.Employee_Type.ToList();
            return dbContext.Employee_Type.ToList(); //tt;
        }
        /*

        public bool insertEmployeeType<T>(T empTypeObject)
        {
            Type outType=empTypeObject.GetType();
           // Type t = dbContext.Set<empTypeObject>;
           // Type outType = typeof(T);
            dbContext.Set(outType).Add(empTypeObject);
            return dbContext.SaveChanges() > 0;
        }

        public bool insert<T>(T obj)
        {
            Type outType = obj.GetType();
            // Type t = dbContext.Set<empTypeObject>;
            // Type outType = typeof(T);
            dbContext.Set(outType).Add(obj);
            return dbContext.SaveChanges() > 0;

            throw new NotImplementedException();
        }*/
    }
}
