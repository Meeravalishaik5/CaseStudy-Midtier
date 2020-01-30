using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmartMvcCaseStudy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmartMvcCaseStudy.Controllers
{
    public class SellerController : Controller
    {
        private readonly SellerContext _context;
        private readonly CategoryContext _categoryContext;
        private readonly SubCategoryContext _subCategoryContext;
        private readonly ItemsContext _itemsContext;
        public SellerController(SellerContext context1,CategoryContext categoryContext,SubCategoryContext subCategory,ItemsContext itemsContext)
        {
            this._context = context1;
            this._categoryContext = categoryContext;
            this._subCategoryContext = subCategory;
            this._itemsContext = itemsContext;
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Seller se)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Add(se);
                _context.SaveChanges();
                ViewBag.msg = se.SUSERNAME + " Has Done Registration";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = se.SUSERNAME + " Has Failed To Register";
                //return View();
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Seller se) 
        {
            Seller loguser = _context.Sellers.FirstOrDefault(e => e.SUSERNAME == se.SUSERNAME && e.SPASSWORD == se.SPASSWORD);
            if (loguser == null)
            {
                ViewBag.msg = "Not Valid User";
                return View();
            }
            else
            {
                //HttpContext.Session.SetString("UName", uc.Username);
                //HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("SellerOP");
            }

        }
        public ActionResult SellerOP() 
        {
            return View();
        }
        [HttpGet]
        public ActionResult SOperations() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult SOperations(Category ce)
        {
            try
            {
                // TODO: Add insert logic here
                _categoryContext.Add(ce);
                _categoryContext.SaveChanges();
                ViewBag.msg = ce.CNAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.CNAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }
        [HttpGet]
        public ActionResult AddSubCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSubCategory(SubCategory ce)
        {
            try
            {
                // TODO: Add insert logic here
                _subCategoryContext.Add(ce);
                _subCategoryContext.SaveChanges();
                ViewBag.msg = ce.SNAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.SNAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Items ce)
        {
            try
            {
                // TODO: Add insert logic here
                _itemsContext.Add(ce);
                _itemsContext.SaveChanges();
                ViewBag.msg = ce.INAME + " Has Added Successfully";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = ce.INAME + " Has Failed To ADD";
                //return View();
            }
            return View();

        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}