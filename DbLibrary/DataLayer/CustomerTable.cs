using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.DataLayer
{
    class CustomerTable
    {
        MaindbContext dbContextForCustomer;
        public CustomerTable()
        {
            dbContextForCustomer = new MaindbContext();

            
        }//end of Cunstructor....

        //Methods for accessing data from datbase....

        public bool insertCustomer(Customer cstObject)
        {
            dbContextForCustomer.Customers.Add(cstObject);
            return dbContextForCustomer.SaveChanges() > 0;
        }//end of method insertCustomer.....

        public List<Customer> selectAllCustomer()
        {
            
            return dbContextForCustomer.Customers.ToList() ;
        }//end of method selectAllCustomer....


        public bool deleteCustomer(int id)
        {
            Customer cst = dbContextForCustomer.Customers.Where(x=> x.CustomerId==id).FirstOrDefault();
            if(cst!=null)
            {
                dbContextForCustomer.Customers.Remove(cst);

            }
            return dbContextForCustomer.SaveChanges() > 0;
        }//end of method deleteCustomer....

        public bool updateCustomer(int id)
        {
            Customer cst = dbContextForCustomer.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            if (cst != null)
            {
               // dbContextForCustomer.Customers.Remove(cst);

            }
            return dbContextForCustomer.SaveChanges() > 0;
        }//end of method updateCustomer....
    }
}
