using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    class ConcreteCommand : ICommand
    {
        IReceiver _receiver;

        public ConcreteCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            this._receiver.Action();
        }
    }
}
