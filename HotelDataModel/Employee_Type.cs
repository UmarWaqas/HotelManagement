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
    
    public partial class Employee_Type
    {
        public Employee_Type()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public decimal Price { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}