using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RoomViewModel : IDataErrorInfo
    {
        private int id{set; get;}
        private int roomNumber;

        public int RoomNumber
        {
            set{roomNumber=value;}
            get{return roomNumber;}
        }
        private int managerId;
        private int maintainerId;
        public int MaintainerId
        {
            set { maintainerId = value; }
            get { return maintainerId; }
        }
        public int ManagerId
        {
            set { managerId = value; }
            get { return managerId; }
        }
        private int roomType;
         public int RoomType
        {
            set{roomType=value;}
            get{return roomType;}
        }




         public string Error
         {
             get { throw new NotImplementedException(); }
         }

         public string this[string propName]
         {
             
                  get 
            {
                string result = null;

                if (propName == "RoomType")
                {
                    if (this.roomType<=0)
                    {
                        result = "Room Type is required";
                    }
                }
                else if (propName == "RoomNumber")
                {
                    if (this.roomNumber <= 199)
                    {
                        result = "Room Number  is required";
                    }
                }

                else if (propName == "ManagerId")
                {
                    if (this.managerId <= 0)
                    {
                        result = "Manager Name is required";
                    }
                }

                else if (propName == "MaintainerId")
                {
                    if (this.maintainerId <= 0)
                    {
                        result = "Maintainer Name is required";
                    }
                }

                return result;
                      throw new NotImplementedException(); }
         }
    }
}
