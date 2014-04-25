using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    public class Receiver : IReceiver
    {
        public void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
