using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class EmployeeViewModel : IDataErrorInfo
    {
        #region SetterAndGetters
        public int Id{ set; get; }
        private string name;
        public string Name 
        {
            set { name = value; }
            get { return name; }
        }
        private string email;
        public string Email
        {
            set { email = value; }
            get { return email; }
        }
        private string password;
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }
        private string address;
        public string Address
        {
            set { address = value; }
            get { return address; }
        }
        private int employeeType;
        public int EmployeeType
        {
            set { 
                employeeType = value; }
            get {
                return employeeType; }
        }
        private DateTime joiningDate=DateTime.Now;
        public DateTime JoiningDate
        {
            set { joiningDate = value; }
            get { return joiningDate; }
        }
        private string cnic;
        public string CNIC
        {
            set { cnic = value; }
            get { return cnic; }
        }
        private DateTime dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }
        #endregion



        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string propName]
        {
            get 
            {
                string result = null;

                if (propName == "Name")
                {
                    if (string.IsNullOrEmpty(this.name))
                    {
                        result = "Name is required";
                    }
                }

                else if (propName == "Email")
                {
                    if (string.IsNullOrEmpty(this.email))
                    {
                        result = "Email is required";
                    }
                }

                else if (propName == "Password")
                {
                    if (string.IsNullOrEmpty(this.password))
                    {
                        result = "Password is required";
                    }
                }
                else if (propName == "PhoneNumber")
                {
                    if (string.IsNullOrEmpty(this.phoneNumber))
                    {
                        result = "Phone Number is required";
                    }
                }
                else if (propName == "Address")
                {
                    if (string.IsNullOrEmpty(this.address))
                    {
                        result = "Address is required";
                    }
                }
                else if (propName == "CNIC")
                {
                    if (string.IsNullOrEmpty(this.cnic))
                    {
                        result = "CNIC is required";
                    }
                }
                else if (propName == "EmployeeType")
                {
                   // int mValue = Convert.ToInt32(this.employeeType);
                    if (this.employeeType <= 0)
                    {
                        result = "Employee Type is required";
                    }
                }


                return result;
                throw new NotImplementedException(); 
                

            }//end of get statement....

            
        }//end of Implemented method.....
    }//end of class EmployeeViewModel....


}//end of namespace....
