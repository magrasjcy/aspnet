using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System.Threading;
namespace com.pizzaZ.Controllers
{
    public class PizzaService : BackgroundService
    {

        public void Dispose() { }
        // public virtual bool Equals(object o) { }
        //  public Type GetType() { }
        protected  async Task ExecuteAsync(CancellationToken _ctoken)
        {
            while (!_ctoken.IsCancellationRequested)
            {
                try
                {
                    var result = await httpClient.GetAsync("https://www.c-sharpcorner.com/members/atul-warade");
                }
                catch (Exception ex)
                {
                    //_logger.LogError("The Website is Down {0}.", ex.Message);
                }
                finally
                {
                    await Task.Delay(1000 * 5, _ctoken);
                }
            }
            //  public override Task StartAsync(CancellationToken _ctoken) { }
            //  public  override Task StopAsync(CancellationToken _ctoken) { }
            //  public Object MemberwiseClone() { }
        }
        GetIngredients()
        {

        }
    }
}
