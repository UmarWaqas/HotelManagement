using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary.DataLayer
{
    class ReservationDA
    {
        MainDbContext dbContext;
        public ReservationDA()
        {
            dbContext = new MainDbContext();
        }


    }//end of class ReservationDA....
}//end of namespace....
