using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    class CustomerViewModel
    {
        #region SetterAndGetters
        public int Id { set; get; }
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
        
       
        private string cnic;
        public string CNIC
        {
            set { cnic = value; }
            get { return cnic; }
        }
        private DateTime dateOfBirth;
        public DateTime Date_of_Birth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }
        #endregion
    }
}
