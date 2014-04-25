using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create receiver, command, and invoker
            IReceiver receiver = new Receiver();
            IReceiver receiver2 = new AnotherReceiver();
            ICommand command = new ConcreteCommand(receiver);

            IInvoker invoker = new StackInvoker();
            //IInvoker invoker = new QueueInvoker();

            // Set and execute command
            invoker.AddCommand(command);

            command = new ConcreteCommand(receiver2);
            invoker.AddCommand(command);

            invoker.ExecuteNextCommand();
            invoker.ExecuteNextCommand();

            // Wait for user
            Console.ReadKey();
        }
    }
}
