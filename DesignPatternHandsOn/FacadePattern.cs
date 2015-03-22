using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{
    #region Concrete
    class Cheese
    {
        private string cheese;
        public Cheese(string p)
        {
            cheese = p;
        }

        public override string ToString()
        {
            return cheese;
        }
    }

    class Sauce
    {
        private string sauce;
        public Sauce(string p)
        {
            sauce = p;
        }

        public override string ToString()
        {
            return sauce;
        }
    }

    class PizzaTopping
    {
        private string pizzaTopping;
        public PizzaTopping(string p)
        {
            pizzaTopping = p;
        }

        public override string ToString()
        {
            return pizzaTopping;
        }
    }

    class Dough
    {
        public string Sauce { private set; get; }
        public string Topping { private set; get; }
        public string Cheese { private set; get; }

        public void AddSauce(Sauce sauce)
        {
            Sauce = sauce.ToString();
        }

        public void AddPizzaTopping(PizzaTopping topping)
        {
            Topping = topping.ToString();
        }

        public void AddCheese(Cheese cheese)
        {
            Cheese = cheese.ToString();
        }
    }

    class Oven
    {
        public int Temperature { get; set; }

        public double Timer { get; set; }

        public string Cook(Dough dough)
        {
            return string.Format("Here is your pizza\n Cheese: {0}\n Sauce: {1}\n Topping: {2}\n", dough.Cheese, dough.Sauce, dough.Topping);
        }
    }
    #endregion

#region Facade
    class Mom
    {
        public string HereYourPizza(PizzaOrder order)
        {
            Dough dough = new Dough();
            dough.AddCheese(new Cheese(order.Cheese));
            dough.AddSauce(new Sauce(order.Sauce));
            dough.AddPizzaTopping(new PizzaTopping(order.Topping));

            var Oven = new Oven() { Temperature =425, Timer = 20 };
            return Oven.Cook(dough);
        }
    }
#endregion

    struct PizzaOrder
    {
        public string Cheese { get; set; }
        public string Sauce { get; set; }
        public string Topping { get; set; }
    }
}
