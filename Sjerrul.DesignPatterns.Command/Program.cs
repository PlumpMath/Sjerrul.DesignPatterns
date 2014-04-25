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
            ReceiverBase receiver = new Receiver();
            ReceiverBase receiver2 = new AnotherReceiver();
            Command command = new ConcreteCommand(receiver);

            //Invoker invoker = new StackInvoker();
            Invoker invoker = new QueueInvoker();

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
