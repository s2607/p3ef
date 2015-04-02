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
    
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            this.PurchaseOrderParts = new HashSet<PurchaseOrderPart>();
        }
    
        public int PurchaseOrderId { get; set; }
        public System.DateTime PODate { get; set; }
        public int VendorId { get; set; }
        public Nullable<System.DateTime> ReceivedDate { get; set; }
    
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderPart> PurchaseOrderParts { get; set; }
    }
}
