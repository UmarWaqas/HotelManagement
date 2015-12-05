//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Payables = new HashSet<Payable>();
            this.Reservations = new HashSet<Reservation>();
            this.Rooms = new HashSet<Room>();
            this.Rooms1 = new HashSet<Room>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Cnic { get; set; }
        public int Employee_Type { get; set; }
        public System.DateTime Joining_Date { get; set; }
        public string Phone { get; set; }
    
        public virtual Employee_Type Employee_Type1 { get; set; }
        public virtual ICollection<Payable> Payables { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Room> Rooms1 { get; set; }
    }
}
