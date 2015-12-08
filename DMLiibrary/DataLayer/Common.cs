using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary
{
    //This class is for Common variables,classes,methods and Interfaces 
    //throughout this application....
    public class Common
    {
        MainDbContext dbContext;
        public Common()
        {
            dbContext = new MainDbContext();

        }
       // public static MainDbContext dbContext = new MainDbContext();
        public bool insert<T>(T empTypeObject)
        {
            Type outType = empTypeObject.GetType();
            // Type t = dbContext.Set<empTypeObject>;
            // Type outType = typeof(T);
            dbContext.Set(outType).Add(empTypeObject);
            return dbContext.SaveChanges() > 0;
        }


        public List<T> getAll<T>(T empTypeObject)
        {
          //  Type outType = typeof(T);
            //Type outType = empTypeObject.GetType();
          //  dbContext.Set(outType).OfType<T>().ToList();
           // List<T> tt = dbContext.Set(outType).OfType<T>().ToList();
            return dbContext.Set(empTypeObject.GetType()).OfType<T>().ToList();//tt;
        }
        
    }//end of class Common.....
    interface DbMethods
    {
        bool insert<T>(T obj);
    }

}//end of namesapce DMLibrary....
