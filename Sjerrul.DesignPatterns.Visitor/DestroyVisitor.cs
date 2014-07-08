using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Visitor
{
    class DestroyVisitor : IVisitor
    {
        public void Visit(Tree visitedObject)
        {
            Console.WriteLine("Burned the tree");
        }

        public void Visit(House visitedObject)
        {
            Console.WriteLine("Demolished the house");
        }
    }
}
