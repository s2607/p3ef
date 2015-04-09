using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkInventory; //NOTE: this isnt added automaticly
using EntityFrameworkInventory.Repository;
namespace EntityFrameworkInventory
{
	public partial class Customer
	{
		public const string StudentName ="Stephen Wiley";
		public decimal TotalSales
		{
			get
			{
							var total = (from salesOrder in SalesOrders
									from sop in salesOrder.SalesOrderParts
									select sop).Sum(s => s.ExtendedPrice);
							return total;
			}
		}
		public static List<Customer> GetCustomersWithOrders()
		{
			var coRep = new CustomerRepository();
			var Cs = coRep.All();
			return Cs.Where(c => c.SalesOrders.Count > 0).ToList();
			
			//return coRep.Filter(c => c.CustomerId.Equals((from so in salesOdersa select so.CustomerId))).ToList();
		}
		public static Customer GetLargestCustomer()
		{
			var soRep = new SalesOrderRepository();
			//return soRep.All().OrderByDescending(so => so.TotalSales).FirstOrDefault().CustomerId;
			var coRep = new CustomerRepository();
			var Cs = coRep.All().ToList();
			var selected  =Cs.OrderByDescending(c => c.TotalSales);
			return selected.FirstOrDefault();
		}
		public static List<Customer> GetCustomersByOrderSizeDescending()
		{
			var coRep = new CustomerRepository();
			var Cs = coRep.All().ToList();
			return Cs.OrderByDescending(c => c.TotalSales).ToList();
		}

	}
}
