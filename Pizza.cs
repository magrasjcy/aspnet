using System;
namespace  com.pizzaX.DataStore {
    class Pizza {
       private Pizza[] _pizza = new Pizza[48];
       public class ingredients {
       public double unitcost {get;set;}
       public uint crust {get;set;}
       public uint count {get;set;}
       public uint size  {get;set;}
       public Topping[] toppings;
       public Topping[] halftoppings;
       
       public ingredients(uint arg0,uint arg1,uint arg2,Topping[] arg3,Topping[] arg4)
       {
           this.size=arg0;
	   this.count=arg1;
	   this.crust=arg2;
	   toppings=arg3;
	   halftoppings=arg4;
       }
       } ;
       public ingredients _ingredients {get;set;}  
       public Pizza( ingredients arg0, double cost) {
	   this._ingredients.unitcost=cost;
	   this._ingredients=arg0;
       }
       
      // public static double getpizzacost(uint arg0) { 
      //     if (arg0 < _pizza.Length) return _pizza[arg0]._ingredients.unitcost;
      //	   else return 5.00f;
      // }       
       void OnLoaded()
        {//  Anchovies,
          //  Mushroom,
        //GreenPepper,
        //pineapple,
        //pepperoni,
        //Beef
            _pizza[0] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.artichokes },new Topping[] {}), 6.75d);
            _pizza[1] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] {Topping.artichokes },new Topping[] {}), 8.75d);
            _pizza[2] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.artichokes },new Topping[] {}), 11.75d);
            _pizza[3] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.artichokes },new Topping[] {}), 6.75d);
            _pizza[4] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] {Topping.artichokes },new Topping[] {}), 8.75d);
            _pizza[5] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] {Topping.artichokes },new Topping[] {}), 11.75d);
            _pizza[6] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 6.75d);
            _pizza[7] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 8.75d);
            _pizza[8] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.anchovies },new Topping[] {}), 11.75d);
            _pizza[9] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.anchovies},new Topping[] {}), 6.75d);
            _pizza[10] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.anchovies },new Topping[] {}), 8.75d);
            _pizza[11] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.anchovies },new Topping[] {}), 11.75d);
            _pizza[12] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 6.75d);
            _pizza[13] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 8.75d);
            _pizza[14] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.chicken },new Topping[] {}), 11.75d);
            _pizza[15] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 6.75d);
            _pizza[16] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 8.75d);
            _pizza[17] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.chicken },new Topping[] {}), 11.75d);
            _pizza[18] = new Pizza(new Pizza.ingredients(1, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 6.75d);
            _pizza[19] = new Pizza(new Pizza.ingredients(2, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 8.75d);
            _pizza[20] = new Pizza(new Pizza.ingredients(3, 1, 1, new Topping[] { Topping.green_peppers },new Topping[] {}), 11.75d);
            _pizza[21] = new Pizza(new Pizza.ingredients(1, 1, 2, new Topping[] { Topping.green_peppers },new Topping[] {}), 6.75d);
            _pizza[22] = new Pizza(new Pizza.ingredients(2, 1, 2, new Topping[] { Topping.green_peppers },new Topping[] {}), 8.75d);
            _pizza[23] = new Pizza(new Pizza.ingredients(3, 1, 2, new Topping[] { Topping.green_peppers},new Topping[] {}), 11.75d);
        }
        public string toString()
        {
            string[] sizes = {"small","medium","large"};
            string message = this._ingredients.count.ToString() + sizes[this._ingredients.size]+this._ingredients.toppings[0]+"pizza";
            return message;
        }
    }
}
