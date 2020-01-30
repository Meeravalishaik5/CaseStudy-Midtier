using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmartMvcCaseStudy.Models;

namespace EmartMvcCaseStudy.Controllers
{
    public class BuyerController : Controller
    {
        private readonly BuyerContext _buyerContext;
        public BuyerController(BuyerContext buyerContext) 
        {
            this._buyerContext = buyerContext;
        }
        [HttpGet]
        public ActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Buyer be )
        {
            try
            {
                // TODO: Add insert logic here
                _buyerContext.Add(be);
                _buyerContext.SaveChanges();
                ViewBag.msg = be.BUSERNAME + " Has Done Registration";

                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.msg = be.BUSERNAME+ " Has Failed To Register";
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
        public ActionResult Login(Buyer se)
        {
            Buyer loguser = _buyerContext.Buyers.FirstOrDefault(e => e.BUSERNAME == se.BUSERNAME && e.BPASSWORD == se.BPASSWORD);
            if (loguser == null)
            {
                ViewBag.msg = "Not Valid User";
                return View();
            }
            else
            {
                //HttpContext.Session.SetString("UName", uc.Username);
                //HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("Details");
            }

        }
        // GET: Buyer1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
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

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
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