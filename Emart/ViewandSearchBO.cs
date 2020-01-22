using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emart
{
   public interface ViewandSearchBO
    {
        void viewItems();
        
    }
	public interface IViewandSearchBO 
    {
        void SearchItem(int id);
    }
    public class BuyerandSeller : ViewandSearchBO,IViewandSearchBO 
    {
		public void viewItems()
		{
			Console.WriteLine("Category List..");
			foreach (Subcategory i in ItemsBO.Slist)
			{
				Console.WriteLine("Category Id.." + i.cid + "\tCategory Name.." + i.cname);
			}
			Console.WriteLine("Enter Category Id..Which you want to view..");
			int opt = int.Parse(Console.ReadLine());
			List<Subcategory> sl = ItemsBO.Slist.FindAll(e => e.cid == opt);
			foreach (Subcategory s in sl)
			{
				Console.WriteLine("Subcatogery id.." + s.Sid + "\tSubcatogery name.." + s.Scname + "\tAbout Subcatogery.." + s.Details);
			}
			Console.WriteLine("Enter Subcatogery id To View Products..");
			int opt2 = int.Parse(Console.ReadLine());
			List<Items> il = ItemsBO.Ilist.FindAll(e1 => e1.scatogery_id == opt2);
			foreach (Items i in il)
			{
				Console.WriteLine(i.ToString());
			}
		}
		public void SearchItem(int iid1)
		{
			List<Items> il = ItemsBO.Ilist.FindAll(i => i.id == iid1);
			foreach (Items i1 in il)
			{
				Console.WriteLine(i1.ToString());
			}
		}
	}
}
