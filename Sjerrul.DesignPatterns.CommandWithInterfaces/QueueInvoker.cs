using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    class QueueInvoker : IInvoker
    {
        private Queue<ICommand> _commands;

        public QueueInvoker() : base()
        {
            this._commands = new Queue<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            this._commands.Enqueue(command);
        }

        public void ExecuteNextCommand()
        {
            ICommand command = _commands.Dequeue();

            command.Execute();
        }
    }
}
