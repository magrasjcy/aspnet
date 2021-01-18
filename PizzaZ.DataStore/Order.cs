namespace com.pizzaZ.DataStore
{
    //[Table("Orders")]
    public class Order
    {
        private uint arrayIdx { get; set; }
        private ulong sequence { get; set; }
        private string address { get; set; }
        private string name { get; set; }
        private string payment { get; set; }
        private float amount { get; set; }
        private Pizza[] items { get; set; } = new Pizza[] { };
        private string username;
        public static Order build(uint Unitno)
        {

            Order order = new Order();
            //ShopData.getLocations(unitno);
            order.items = new Pizza[12];
            return order;
        }
    }

}

