//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOrder
    {
        public int OrderId { get; set; }
        public string OrderPhoneNumber { get; set; }
        public string OrderAddress { get; set; }
        public string OrderCity { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual TblUser TblUser { get; set; }
    }
}
