//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExportDetail
    {
        public string ProductID { get; set; }
        public string ExportReceiptID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual tblExportReceipt tblExportReceipt { get; set; }
        public virtual tblProduct tblProduct { get; set; }
    }
}