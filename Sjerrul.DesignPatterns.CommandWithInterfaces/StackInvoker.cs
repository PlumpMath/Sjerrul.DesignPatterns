using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    class StackInvoker : IInvoker
    {
        private Stack<ICommand> _commands;

        public StackInvoker()
            : base()
        {
            this._commands = new Stack<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            this._commands.Push(command);
        }

        public void ExecuteNextCommand()
        {
            ICommand command = _commands.Pop();

            command.Execute();
        }
    }
}
