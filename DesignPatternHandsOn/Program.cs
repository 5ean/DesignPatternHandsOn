using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObserverPatter();
            //DecoratorPattern();
            //SingletonPattern();
            //IteratorPattern();
            FacadePattern();
            Console.ReadLine();
        }

        private static void ObserverPatter()
        {
            Channel channle = new Channel();

            ISubscriber Joey = new User();
            ISubscriber watchDog = new Moderator();

            channle.Subsribe(Joey);
            channle.Subsribe(watchDog);

            channle.NotifySubscrible();

            channle.UnSubsribe(Joey);
            channle.NotifySubscrible();
        }

        private static void DecoratorPattern()
        {
            IceCream chocolateIceream = new Chocolate();
            chocolateIceream = new Spinkle(chocolateIceream);
            chocolateIceream = new Fudge(chocolateIceream);
            Console.WriteLine(string.Format("Chocolate icecream with spinkle and funge costs: {0}",chocolateIceream.Cost()));
        }

        private static void SingletonPattern()
        {
            var log = Logger.LoggerInstance;
        }

        private static void IteratorPattern()
        {
            ISocialNetworking socialCompany = new Twitter();
            var iterator = socialCompany.CreateIterator();
            while (iterator.MoveNext())
            {
                Console.WriteLine("Twitter User: " + iterator.Current.ToString());
            }

            socialCompany = new Facebook();
            iterator = socialCompany.CreateIterator();
            while (iterator.MoveNext())
            {
                Console.WriteLine("Facebook User: " + iterator.Current.ToString());
            }
        }

        private static void FacadePattern()
        {
            Mom mon = new Mom();
            //kid 1
            Console.WriteLine(
                mon.HereYourPizza(new PizzaOrder() { Cheese = "Mozzarella", Topping = "Muchrooms", Sauce = "Tomato" })
                );

        }
    }

  
    
}
 