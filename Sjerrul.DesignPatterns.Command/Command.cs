using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    public abstract class Command
    {
        protected ReceiverBase Receiver;

        public Command(ReceiverBase receiver)
        {
            this.Receiver = receiver;
        }

        public abstract void Execute();
    }
}
