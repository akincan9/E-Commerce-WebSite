
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

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public Nullable<decimal> TotalPrice { get; set; }

        public string OrderedCarts { get; set; }

        public Nullable<bool> IsDelivered { get; set; }

        public Nullable<System.DateTime> OrderDateTime { get; set; }

        public Nullable<int> UserId { get; set; }



        public virtual TblUser TblUser { get; set; }

    }

}
� 2022 GitHub, Inc.
Terms
Privacy