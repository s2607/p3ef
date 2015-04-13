using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkInventory
{
	public partial class Vendor
	{
		public Decimal TotalPurchases
		{
			get
			{
				//Returns a decimal of the total purchases for the Vendor as a public readonly property.
				return PurchaseOrders.Sum(po => po.PurchaseOrderParts.Sum(pop => pop.ExtendedCost));
			}
		}
		public List<Part> GetAllParts
		{
			get
			{
				//Returns a List<Part> of all parts ordered from the Vendor as a read-only public property. 

				return (from po in PurchaseOrders
						from pop in po.PurchaseOrderParts
						select pop.Part).ToList();
			}
		}
	}
}
