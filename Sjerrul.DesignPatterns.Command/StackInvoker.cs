using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Command
{
    class StackInvoker : Invoker
    {
        private Stack<Command> _commands;

        public StackInvoker()
            : base()
        {
            this._commands = new Stack<Command>();
        }

        public override void AddCommand(Command command)
        {
            this._commands.Push(command);
        }

        public override void ExecuteNextCommand()
        {
            Command command = _commands.Pop();

            command.Execute();
        }
    }
}
