using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using  com.pizzaZ.DataStore;
using System.Collections.Generic;

namespace com.pizzaZ.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        public ActionResult Index()
        {
          // com.pizzaZ.DataStore
            Order order = new Order();
            List<string> listOfStores = Stores.getStores();
            // string listOfStores = Stores.getStores();
           // List<string> listOfStores = new List<string>();
            //listOfStores.Add("11150 Research Blvd Austin,TX 78759");
            //listOfStores.Add( "13764 Research Blvd.,Austin, TX" );
            ViewData["StoreListObject"] = listOfStores;
            return View();
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: OrderController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
