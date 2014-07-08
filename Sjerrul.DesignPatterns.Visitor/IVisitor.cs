using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sjerrul.DesignPatterns.Visitor
{
    public interface IVisitor
    {
        void Visit(Tree visitedObject);
        void Visit(House visitedObject);
    }
}
