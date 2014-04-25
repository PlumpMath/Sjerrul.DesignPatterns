using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Command
{
    public interface IInvoker
    {
        void AddCommand(ICommand command);

        void ExecuteNextCommand();
    }
}
