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
    
    public partial class ContactDetail
    {
        public int id { get; set; }
        public int ContactID { get; set; }
        public string Message { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string EmployeeName { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
}