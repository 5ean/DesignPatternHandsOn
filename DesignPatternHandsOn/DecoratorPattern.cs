using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{
    #region Component
    abstract class IceCream
    {
        public abstract double Cost();
    }

    #endregion

    #region ConcreteComponent
    class Chocolate: IceCream
    {

        public override double Cost()
        {
            return 1.5;
        }
    }

    class Vanilla : IceCream
    {

        public override double Cost()
        {
            return 1;
        }
    }

    #endregion

    #region Decorator
    abstract class Topping : IceCream
    {
        protected IceCream IceCream { get; set; }

        protected Topping(IceCream ic)
        {
            IceCream = ic;
        }
    }

    #endregion


    #region  ConcreteDecorator
    class Fudge: Topping
    {
        public Fudge(IceCream ic)
            : base(ic)
        {

        }

        public override double Cost()
        {
            return 0.25 + IceCream.Cost();
        }
    }

    class Spinkle: Topping
    {
        public Spinkle(IceCream ic)
            : base(ic)
        {

        }

        public override double Cost()
        {
            return 0.5 + IceCream.Cost();
        }
    }
    #endregion
}
