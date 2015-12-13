using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RoomTypeViewModel : IDataErrorInfo
    {
         #region SetterAndGetters
        private int id;
        private string type;
        private decimal charges;
        private int capacity;

        public int Capacity
        {
            set
            {
                capacity = value;
            }
            get
            {
                return capacity;
            }
        }

        public decimal Charges
        {
            set
            {
                charges = value;
            }
            get
            {
                return charges;
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


        #endregion

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
                        result = "Room Type is required";
                    }
                }

                else if (propertyName == "Capacity")
                {
                    if (this.capacity <= 0)
                    {
                        result = "Room Capacity is required";
                    }
                }

                else if (propertyName == "Charges")
                {
                    if (this.charges <= 0)
                    {
                        result = "Number of Guests are required";
                    }
                }

                return result;
                throw new NotImplementedException();
            }
        }
    }//end of class RoomTypeViewModel....
    
}//end of namespace....
