using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{
    public interface ISubscriber
    {
        void Notify();
    }

    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("watch video");
        }
    }

    public class Moderator : ISubscriber
    {

        public void Notify()
        {
            Console.WriteLine("review video");
        }
    }

    public class Channel
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Subsribe(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void UnSubsribe(ISubscriber s)
        {
            subscribers.Remove(s);
        }

        public void NotifySubscrible()
        {
            subscribers.ForEach(x => x.Notify());
        }
    }
}
