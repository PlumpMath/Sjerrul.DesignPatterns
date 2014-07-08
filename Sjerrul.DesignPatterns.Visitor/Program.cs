using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.DesignPatterns.Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IVisitable> _objects = new List<IVisitable>();
            _objects.Add(new Tree());
            _objects.Add(new Tree());
            _objects.Add(new House());

            IVisitor visitor = new PrintVisitor();
            //IVisitor visitor = new DestroyVisitor();

            foreach (IVisitable o in _objects)
            {
                o.Accept(visitor);
            }

            Console.ReadLine();
        }
    }
}
