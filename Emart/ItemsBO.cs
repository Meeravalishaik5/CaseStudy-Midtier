using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emart
{
	class ItemsBO
	{
		public static List<Items> Ilist { get; set; } = new List<Items>();
		public static List<Subcategory> Slist { get; set; } = new List<Subcategory>();
		public void AddCatandSubcategory(int c_id, string cname, int s_id, string scname, string scdes)
		{
			Slist.Add(new Subcategory(c_id, cname, s_id, scname, scdes));
		}
		public void AddItems(int c_id, int s_id, int id, double pri, string item_nam, string des, int st, string rem, double gst)
		{
			//List<Subcategory> s1 = Slist.FindAll(e => e.cid == c_id);

			Ilist.Add(new Items(c_id, s_id, id, pri, item_nam, des, st, rem, gst));
		}
		public void BuyItem(int iid) 
		{
			int flag1 = 0;
			List<Items> il = Ilist.FindAll(e => e.id == iid);
			foreach (Items ie in il) 
			{
				Console.WriteLine("Item id..."+ie.id+"\nItem name.."+ie.item_name+"\nPrice..."+ie.price
					+"\nGst..."+ie.Gst+"\nFinal Price..."+ie.price+(ie.price*(ie.Gst/100)));
				flag1 = 1;
			}
			if (flag1 == 1) 
			{
				Console.WriteLine("Item Purchased Successfully..Pay It When Delievered...");
			}
			else 
			{
				Console.WriteLine("Item Purchase Failed..");
			}
		}
	}
}
