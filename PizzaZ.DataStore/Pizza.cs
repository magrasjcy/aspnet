using System;
namespace  com.pizzaZ.DataStore {
   /* [Table("Pizza")]*/
    class Pizza {
       public class ingredients {
       public double UnitCost {get;set;}
       public uint Crust {get;set;}
       public uint Count {get;set;}
       public uint Size  {get;set;}
       public Topping[] Toppings { get; set; } = new Topping[] { };
       public Topping[] HalfToppings { get; set; } = new Topping[] { };
       
       public ingredients(uint arg0,uint arg1,uint arg2,Topping[] arg3,Topping[] arg4)
       {
           this.Size=arg0;
	       this.Count=arg1;
	       this.Crust=arg2;
	       Toppings=arg3;
	       HalfToppings=arg4;
       }
       } ;
       public ingredients Ingredients {get;set;}  
       public Pizza( ingredients arg0, double cost) {
	   this.Ingredients.UnitCost=cost;
	   this.Ingredients=arg0;
       }
       
      // public static double getpizzacost(uint arg0) { 
      //     if (arg0 < _pizza.Length) return _pizza[arg0]._ingredients.UnitCost;
      //	   else return 5.00f;
      // }       
       void OnLoaded()
        {//  Anchovies,
          //  Mushroom,
        //GreenPepper,
        //pineapple,
        //pepperoni,
        //Beef
            //_pizza[0] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.artichokes },new Topping[] {}), 6.75d);
            //_pizza[1] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] {Topping.artichokes },new Topping[] {}), 8.75d);
            //_pizza[2] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.artichokes },new Topping[] {}), 11.75d);
            //_pizza[3] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.artichokes },new Topping[] {}), 6.75d);
            //_pizza[4] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] {Topping.artichokes },new Topping[] {}), 8.75d);
            //_pizza[5] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] {Topping.artichokes },new Topping[] {}), 11.75d);
            //_pizza[6] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 6.75d);
            //_pizza[7] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 8.75d);
            //_pizza[8] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 11.75d);
            //_pizza[9] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.anchovies},new Topping[] {}), 6.75d);
            //_pizza[10] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.anchovies },new Topping[] {}), 8.75d);
            //_pizza[11] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.anchovies },new Topping[] {}), 11.75d);
            //_pizza[12] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 6.75d);
            //_pizza[13] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 8.75d);
            //_pizza[14] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 11.75d);
            //_pizza[15] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 6.75d);
            //_pizza[16] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 8.75d);
            //_pizza[17] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 11.75d);
            //_pizza[18] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 6.75d);
            //_pizza[19] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 8.75d);
            //_pizza[20] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 11.75d);
            //_pizza[21] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.green_peppers },new Topping[] {}), 6.75d);
            //_pizza[22] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.green_peppers },new Topping[] {}), 8.75d);
            //_pizza[23] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.green_peppers},new Topping[] {}), 11.75d);
        }
        public string toString()
        {
            string[] Sizes = {"small","medium","large"};
            string message = this.Ingredients.Count.ToString() + Sizes[this.Ingredients.Size]+this.Ingredients.Toppings[0]+"pizza";
            return message;
        }
    }
}
