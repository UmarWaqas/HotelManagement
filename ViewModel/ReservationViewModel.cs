using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
   public class ReservationViewModel : IDataErrorInfo
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
        private string cnic;
        public string CNIC
        {
            set { cnic = value; }
            get { return cnic; }
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
        
        private int roomNumber;
        public int RoomNumber
        {
            set
            {
                roomNumber = value;
            }
            get
            {
                return roomNumber;
            }
        }
        private int roomType;
        public int RoomType
        {
            set
            {
                roomType = value;
            }
            get
            {
                return roomType;
            }
        }
        private int nights;
        public int Nights
        {
            set
            {
                nights = value;
            }
            get
            {
                return nights;
            }
        }
        private DateTime dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }
        }
        private DateTime checkInDate = DateTime.Now;
        public DateTime CheckInDate
        {
            set { checkInDate = value; }
            get { return checkInDate; }
        }
        
        private DateTime checkOutDate = DateTime.Now;
        public DateTime CheckOutDate
        {
            set { checkOutDate = value; }
            get { return checkOutDate; }
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

                else if (propName == "Nights")
                {
                    if (this.nights<=0)
                    {
                        result = "Night is required";
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
                else if (propName == "RoomType")
                {
                    // int mValue = Convert.ToInt32(this.employeeType);
                    if (this.roomType <= 0)
                    {
                        result = "Room Type is required";
                    }
                }
                else if (propName == "RoomNumber")
                {
                    // int mValue = Convert.ToInt32(this.employeeType);
                    if (this.roomNumber <= 0)
                    {
                        result = "Room Number is required";
                    }
                }


                return result;
                throw new NotImplementedException();


            }//end of get statement....


        }//end of Implemented method.....
    }//end of class ReservationViewModel....
}//end of namespace....
