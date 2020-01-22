using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmartMVC.Models;

namespace EmartMVC.Controllers
{
    public class SellerController : Controller
    {
        private readonly ISeller sellerrepos;// = new SellerRepositiry();
        public SellerController(ISeller se) 
        {
            sellerrepos = se;
        }
        public IActionResult Search(int? id) 
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller se = sellerrepos.GetSeller(ID);
            return View(se);
            
        }
        public IActionResult Index()
        {
            List<Seller> sl = sellerrepos.DisplayDetails();
            return View(sl);
        }
    }
}