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
    
    public partial class tblImportReceipt
    {
        public tblImportReceipt()
        {
            this.tblImportDetails = new HashSet<tblImportDetail>();
        }
    
        public string ImportReceiptID { get; set; }
        public string EmployeeID { get; set; }
        public string DistributorID { get; set; }
        public System.DateTime Date { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual tblDistributor tblDistributor { get; set; }
        public virtual tblEmployee tblEmployee { get; set; }
        public virtual ICollection<tblImportDetail> tblImportDetails { get; set; }
    }
}
