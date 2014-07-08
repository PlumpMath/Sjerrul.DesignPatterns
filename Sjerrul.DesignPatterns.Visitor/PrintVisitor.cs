using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Visitor
{
    class PrintVisitor : IVisitor
    {
        public void Visit(Tree visitedObject)
        {
            Console.WriteLine("Visited Tree");
        }

        public void Visit(House visitedObject)
        {
            Console.WriteLine("Visited House");
        }
    }
}
