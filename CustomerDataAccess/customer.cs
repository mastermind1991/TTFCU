//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CustomerDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<System.DateTime> BecameCustomer { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
