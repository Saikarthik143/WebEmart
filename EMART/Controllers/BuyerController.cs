using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMART.Models;

namespace EMART.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _context;
        public BuyerController(BuyerContext context)
        {
            this._context = context;
        }
        // GET: Buyer
        [HttpGet]
        public IActionResult BuyerRegister()
        {

            return View();
        }
        [HttpPost]
        public IActionResult BuyerRegister(Buyer b)
        {
            try
            {
                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = "hello" + b.UserName + "Successfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = "Sorry" + b.UserName + "failed to register";
                return View();
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Buyer b)
        {
            var LogUser = _context.buyers.Where(e => e.UserName == b.UserName && e.Password == b.Password).ToList();
            if (LogUser.Count ==0)
            {
                ViewBag.message = "Not Valid User";
                return View();
            }
            else
                HttpContext.Session.SetString("UName", b.UserName);
            HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
            return RedirectToAction("CreateDashBoard");
            
        }
        //public ActionResult CreateDashBoard()
        //{
        //    if (HttpContext.Session.GetString("UName") != null)
        //        ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
        //    //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
        //    if (Request.Cookies["lastlogin"] != null)
        //        ViewBag.iidt = Request.Cookies["lastlogin"].ToString();
        //    return View();
        //}
        // GET: Buyer
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