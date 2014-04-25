using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    abstract public class Invoker
    {
        abstract public void AddCommand(Command command);

        abstract public void ExecuteNextCommand();
    }
}
