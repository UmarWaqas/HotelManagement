﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMLibrary.DataLayer
{
    class EmployeeDA
    {
        MainDbContext dbContext;

        public EmployeeDA()
        {
            dbContext = new MainDbContext();
        }


    }//end of class EmployeeDA...
}//end of namespace.....