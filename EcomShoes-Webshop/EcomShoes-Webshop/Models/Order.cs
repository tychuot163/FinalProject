//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcomShoes_Webshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int id { get; set; }
        public string OrderCode { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ContactName { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactReceiverName { get; set; }
        public string ContactReceiverAddress { get; set; }
        public string ContactReceiverPhone { get; set; }
        public string ContactReceiverEmail { get; set; }
        public string Note { get; set; }
        public string EmployeeName { get; set; }
        public Nullable<int> Status { get; set; }
        public decimal TotalPrice { get; set; }
    
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
