//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkInventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Part
    {
        public Part()
        {
            this.PurchaseOrderParts = new HashSet<PurchaseOrderPart>();
            this.SalesOrderParts = new HashSet<SalesOrderPart>();
            this.Spoilages = new HashSet<Spoilage>();
        }
    
        public int PartId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public Nullable<decimal> CurrentValue { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual ICollection<PurchaseOrderPart> PurchaseOrderParts { get; set; }
        public virtual ICollection<SalesOrderPart> SalesOrderParts { get; set; }
        public virtual ICollection<Spoilage> Spoilages { get; set; }
    }
}
