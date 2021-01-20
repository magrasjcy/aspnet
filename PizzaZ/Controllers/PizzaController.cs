using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc; 


namespace com.pizzaZ.Controllers
{
    public class PizzaController : AsyncController
    {
        public void PizzaAsync(Ingredients)
        {
            AsyncManager.OutstandingOperations.Increment();
            PizzaService pizzaService = new PizzaService();
            //pizzaService.GetHeadlinesCompleted += (sender, e) =>
            pizzaService.GetIngredients += (sender, e) =>
            {
                AsyncManager.Parameters[""] = e.Value;
                AsyncManager.OutstandingOperations.Decrement();
            };
           
        }
        public Microsoft.AspNetCore.Mvc.ActionResult PizzaCompleted(string[] headlines)
        {
            return View("Pizza", new ViewStringModel
            {
                NewsHeadlines = headlines
            });
        }

    }
}
