using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary.DataLayer
{
    class CustomerDA
    {
        MainDbContext dbContext;
        public CustomerDA()
        {
            dbContext = new MainDbContext();

            
        }//end of Cunstructor....

        //Methods for accessing data from datbase....

        public bool insertCustomer(Customer cstObject)
        {
            dbContext.Customers.Add(cstObject);
            return dbContext.SaveChanges() > 0;
        }//end of method insertCustomer.....

        public List<Customer> selectAllCustomer()
        {

            return dbContext.Customers.ToList();
        }//end of method selectAllCustomer....


        public bool deleteCustomer(int id)
        {
            Customer cst = dbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
            if(cst!=null)
            {
                dbContext.Customers.Remove(cst);

            }
            return dbContext.SaveChanges() > 0;
        }//end of method deleteCustomer....

        public bool updateCustomer(int id)
        {
            Customer cst = dbContext.Customers.Where(x => x.Id == id).FirstOrDefault();
            if (cst != null)
            {
               // dbContextForCustomer.Customers.Remove(cst);

            }
            return dbContext.SaveChanges() > 0;
        }//end of method updateCustomer....
    }
}
