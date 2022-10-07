using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Class1
    {
        public static void Message(string me)
        {
            Console.WriteLine(me);
        }
        public delegate void classdeligate(string message);
        classdeligate cl = new classdeligate(Message);
         cl("Hello world");

    }
}
