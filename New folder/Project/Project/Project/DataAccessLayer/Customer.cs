//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public string PhoneNum1 { get; set; }
        public string PhoneNum2 { get; set; }
        public Nullable<decimal> Depit { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
