using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System.Threading;
namespace com.pizzaZ.Controllers
{
    public class BackgroundService
    {

        public void Dispose() { }
        public virtual bool Equals(Object) { }
        public Type GetType() { }
        public ExecuteAsync(CancellationToken) { }
        public Task StartAsync(CancellationToken) { }
        public Task StopAsync(CancellationToken) { }
        public Object MemberwiseClone()
    }
}
