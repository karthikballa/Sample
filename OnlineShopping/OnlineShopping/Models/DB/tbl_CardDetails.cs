//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShopping.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_CardDetails
    {
        public int CardID { get; set; }
        public string LoginID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string Type { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public string Expirydate { get; set; }
        public string CVV { get; set; }
    }
}
