using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    public class Receiver : ReceiverBase
    {
        public override void Action()
        {
            Console.WriteLine("Called Receiver.Action()");
        }
    }
}
