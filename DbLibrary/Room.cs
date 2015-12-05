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
    
    public partial class Room
    {
        public Room()
        {
            this.Receivables = new HashSet<Receivable>();
        }
    
        public int Id { get; set; }
        public int Room_Number { get; set; }
        public int Type { get; set; }
        public int ManageBy { get; set; }
        public int Maintainer { get; set; }
        public Nullable<int> ReservationId { get; set; }
        public int Nights { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual ICollection<Receivable> Receivables { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Room_Type Room_Type { get; set; }
    }
}
