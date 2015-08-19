using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component components = new Composite("root");
            components.Add(new Leaf("FIRST"));
            Component second = new Composite("SECOND");
            Component second1 = new Composite("SECOND 1");
            Component second2 = new Composite("SECOND 2");
            second2.Add(new Leaf("SECOND 3"));
            second1.Add(second2);
            second.Add(second1);
            components.Add(second);
            components.Add(new Leaf("THIRD"));
            components.Add(second1);
            components.Add(second2);
            components.Display(0);
            Console.ReadKey();
        }
    }

    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Del(Component c);
        public abstract void Display(int depth);

    }

    class Leaf:Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component c)
        {
            Console.WriteLine("Leaf can't add children");
        }

        public override void Del(Component c)
        {
            Console.WriteLine("Leaf haven't children");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
        }
    }

    class Composite:Component
    {
        protected List<Component> cheldrens = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component c)
        {
            cheldrens.Add(c);
        }

        public override void Del(Component c)
        {
            cheldrens.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach(Component children in cheldrens)
            {
                children.Display(depth+1);
            }
        }
    }
}
