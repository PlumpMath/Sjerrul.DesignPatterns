using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(ReceiverBase receiver) :
            base(receiver)
        {
        }

        public override void Execute()
        {
            this.Receiver.Action();
        }
    }
}
