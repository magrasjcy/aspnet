using System;
using System.Collections.Generic;
using System.Text;

namespace com.pizzaZ.DataStore
{
    public partial class Stores
    {
        string Address { get; set; }
        private short StoreNo { get; set; }
        private static Stores[] _stores { get; set; } = new Stores[24] {null,null,null,null,null,null,null,null,
        null, null, null, null, null, null, null, null,
    null,null,null,null,null,null,null,null};
        
   //     {
   ////         Store store = new Store();
     //       store.processOrders(99U);
   //     }
     //   public void processOrders(uint unitno)
     //   {
     //       Order order = acceptOrder(unitno);
     //   }
        public Order acceptOrder(uint unitno)
        {
            Order order = Order.build(unitno);
            return order;
        }
        public static List<string> getStores()
        {
            List<string> addresses = new List<string>();

            //if (Stores._stores == null)
            //{
            //    Stores._stores = new Stores[5] { null, null, null, null, null };
            //    Stores.OnCreated();
            //    if (Stores._stores[0] != null) {
            //        return new List<string>() { Stores._stores[0].Address };
            //    }else return new List<string>();
            //}
            //else if (Stores._stores[0] == null) { return "A"; }
            //else return Stores._stores[0].Address;
            //if (Stores._stores[0] != null && Stores._stores[1] != null &&
            //   Stores._stores[0].Address != null && Stores._stores[1].Address != null)
            Stores.OnCreated();
            {
                addresses.Add(Stores._stores[0].Address);
                addresses.Add(Stores._stores[1].Address);
                //addresses = Stores._stores[0].Address + ":" + Stores._stores[1].Address;
            } // else if ( Stores._stores==null) { addresses += ":A"; }

          
            return addresses;
        }
        public static List<Stores> getOutlets()
        {
            List<Stores> outlets = new List<Stores>();
            return outlets;
        }
        public Stores(string arg0, short arg1)
        {
            this.Address = arg0;
            this.StoreNo = arg1;
        }
        public static void OnCreated()
        {
            Stores._stores[0] = new Stores("11150 Research Blvd, Austin,TX 78759", 1);
            Stores._stores[1] = new Stores("13764 Research Blvd.,Austin, TX", 1);
            Stores._stores[2] = new Stores("2051 Cypress Creek Rd, Austin,TX", 2);
            Stores._stores[3] = new Stores("13201 Pond Springs Rd.,Austin,TX", 3);
            Stores._stores[4] = new Stores("13764 Research Blvd.,Austin, TX", 4);
        }
    }
}