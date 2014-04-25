using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    class QueueInvoker : Invoker
    {
        private Queue<Command> _commands;

        public QueueInvoker() : base()
        {
            this._commands = new Queue<Command>();
        }

        public override void AddCommand(Command command)
        {
            this._commands.Enqueue(command);
        }

        public override void ExecuteNextCommand()
        {
            Command command = _commands.Dequeue();

            command.Execute();
        }
    }
}
