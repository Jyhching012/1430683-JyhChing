//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1430683_CO5027.App_Code
{
    using System;
    using System.Collections.Generic;
    
    public partial class GVGCart
    {
        public int ID { get; set; }
        public string CustomerId { get; set; }
        public int GpuID { get; set; }
        public int AmountCost { get; set; }
        public Nullable<System.DateTime> DatePurchased { get; set; }
        public bool ItemsInCart { get; set; }
    
        public virtual Product Product { get; set; }
    }
}