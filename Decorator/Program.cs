using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component c = new ComponentA();
            Decorator d1 = new DecoratorA();
            Decorator d2 = new DecoratorB();
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();

            Console.ReadKey();
        }
    }

    abstract class Component
    {
        public abstract void Operation();
    }

    class ComponentA:Component
    {
        public override void Operation()
        {
            Console.WriteLine("Called operation from Component A");
        }
    }

    abstract class Decorator:Component
    {
        private Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
                _component.Operation();
        }
    }

    class DecoratorA:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Called Decorator A Operation");
        }
    }

    class DecoratorB:Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("Called Decorator B Operation");
        }

        private void AddedBehavior() { }
    }
}
