using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EMART.Models;

namespace EMART.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _context;
        public SellerController(SellerContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult SellerRegister()
        {

            return View();
        }
        [HttpPost]
        public IActionResult SellerRegister(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = "hello" + s.username + "Successfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = "Sorry" + s.username + "failed to register";
                return View();
            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Seller s)
        {
            var loguser = _context.sellers.Where(e => e.username == s.username && e.password== s.password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.message = "Not a Valid User";
                return View();
            }
            else
            {//to store session values

                HttpContext.Session.SetString("", s.username);
                HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());


                return View("CreateDashBoard");
            }

        }
        // GET: Seller
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
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