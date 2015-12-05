using DMLibrary.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary
{
    class DataFactory
    {
        CustomerDA cstobject;
        public DataFactory()
        {
            cstobject = new CustomerDA();

        }

    }//end of class DataFactory....


}//end of namespace DMLibrary....
