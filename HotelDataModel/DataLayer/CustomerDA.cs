using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDataModel.DataLayer
{
    public class CustomerDA
    {
        //Database Context object....
        HotelDbContext dbContext;

        public CustomerDA()
        {
            dbContext = new HotelDbContext();
        }

        public bool insert(Customer cstm)
        {
            dbContext.Customers.Add(cstm);

            return dbContext.SaveChanges() > 0;
        }//end of insert method....


    }// end of class CustomerDA....


}// end of namespace.....
