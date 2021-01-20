using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.pizzaZ.DataStore;
namespace com.pizzaZ.Store
{
    public class StoreController : Controller
    {
        // GET: StoreController
        public ActionResult Index()
        {
            List<DataStore.Stores> listOfOutlets = (List<DataStore.Stores>)DataStore.Stores.getOutlets();
            ViewData["StoreListObject"] = listOfOutlets;
            return View();
        }

        // GET: StoreController/Details/5
#pragma warning disable IDE0060 // Remove unused parameter
        public ActionResult Details(int id)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            return View();
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
