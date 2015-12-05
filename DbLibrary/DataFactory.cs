using DbLibrary.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary
{
    class DataFactory
    {
        CustomerTable cstobject;
        public DataFactory()
        {
            cstobject = new CustomerTable();

        }

    }//end of class DataFactory....
}//end of namespace DbLibrary....
