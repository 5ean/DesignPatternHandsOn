using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternHandsOn
{

    /*
     Interface Iiterator is already implemented by .net, which is called IEnumerator
     so we do not need to implement again.
    */

    interface ISocialNetworking
    {
         IEnumerator CreateIterator();
    }

    class Facebook:ISocialNetworking
    {
        LinkedList<string> users = new LinkedList<string>();

        public Facebook()
        {
            users.AddLast("A");
            users.AddLast("B");
            users.AddLast("C");
            users.AddLast("D");
            users.AddLast("E");
        }


        public IEnumerator CreateIterator()
        {
            return users.GetEnumerator();
        }
    }

    class Twitter: ISocialNetworking
    {
        List<string> users = new List<string>();

        public Twitter()
        {
            users.Add("a");
            users.Add("b");
            users.Add("c");
            users.Add("d");
            users.Add("e");
        }

        public IEnumerator CreateIterator()
        {
            return users.GetEnumerator();
        }
    }
}
