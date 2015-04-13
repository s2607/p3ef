using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkInventory; //NOTE: this isnt added automaticly
using EntityFrameworkInventory.Repository;

namespace EntityFrameworkInventory
{
	public partial class Part
	{
		public static List<Part> GetPartsWithoutSpoilages()
		{
			var paRep = new PartRepository();
			var parts = paRep.All().ToList();
			return parts.Where(p => p.Spoilages.Count < 1).ToList();
		}
		public static Part GetHighestValue()
		{
			//Static method that returns the Part with the highest current inventory value as a public static method. 
			var paRep = new PartRepository();
			var parts = paRep.All().ToList();
			return parts.OrderByDescending(p => p.CurrentValue).FirstOrDefault();

		}
		public static Dictionary<int,Part> GetPartDictionary(){
			//Static method that returns the Part with the highest current inventory value as a public static method. 
			var paRep = new PartRepository();
			var parts = paRep.All().ToList();
			//return (from part in parts group part by part.PartId into pg select pg).ToDictionary();
			return parts.ToDictionary(p => p.PartId);

		}
		public static List<Part> GetAllParts( PurchaseOrder PurchaseOrder ) {	
			//A public static method that returns a List<Part> of Parts for a given PurchaseOrder parameter.
			return (from pop in PurchaseOrder.PurchaseOrderParts select pop.Part).ToList();
		}

	}

}
