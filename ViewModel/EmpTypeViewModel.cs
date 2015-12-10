using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EmpTypeViewModel : IDataErrorInfo
    {
        private int id;
        private string type;
        private decimal salary;

        public decimal Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }


        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string propertyName]
        {
            get 
            {
                string result = null;

                if (propertyName == "Type")
                {
                    if (string.IsNullOrEmpty(this.type))
                    {
                        result = "Employee Type is required";
                    }
                }

                else if (propertyName == "Salary")
                {
                    if (this.salary<=0)
                    {
                        result = "Salary is required";
                    }
                }

                return result;
                throw new NotImplementedException(); 
            }
        }
    }//end of class EmpTypeViewModel....
}//end of namespace....
