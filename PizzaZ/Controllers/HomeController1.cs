using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PizzaZ.Controllers
{
    public class HomeController1 : AsyncController
    {
        public IActionResult Index()
        {
            AsyncManager.OutstandingOperations.Increment();
            NewsService newsService = new NewsService();
            newsService.GetHeadlinesCompleted += (sender, e) =>
            {
                AsyncManager.Parameters["headlines"] = e.Value;
                AsyncManager.OutstandingOperations.Decrement();
            };
            return View();
        }
    }
}
