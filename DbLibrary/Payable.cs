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
    
    public partial class Payable
    {
        public int Id { get; set; }
        public int PaidTo { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
