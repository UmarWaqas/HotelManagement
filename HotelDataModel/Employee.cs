//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Account_Payable = new HashSet<Account_Payable>();
            this.Reservations = new HashSet<Reservation>();
            this.Rooms = new HashSet<Room>();
            this.Rooms1 = new HashSet<Room>();
        }
    
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePassword { get; set; }
        public int EmployeeType { get; set; }
    
        public virtual ICollection<Account_Payable> Account_Payable { get; set; }
        public virtual Employee_Type Employee_Type { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Room> Rooms1 { get; set; }
    }
}
