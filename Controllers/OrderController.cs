using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  System.Runtime.CompilerServices ;
using Microsoft.Extensions.Logging;
using PizzaX.Models;
using System.Collections.Generic;
namespace PizzaX.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

	/*[Dynamic]
	public dynamic ViewBag { get;}*/
        public IActionResult Index()
        {
	    ViewBag.Title= "Order Pizza!!";
	    List<string> orderings;
	    orderings=new List<string> ();
	    orderings.Add("Pepproni+half Mushroom");
	    ViewBag.orderings=orderings;
            return View();
        }

      /*  public IActionResult Privacy()
        {
            return View();
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
    }
}
