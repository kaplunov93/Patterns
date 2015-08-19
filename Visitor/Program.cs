using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure o = new ObjectStructure();

            o.Attach(new ElementA());
            o.Attach(new ElementB());

            o.Accept(new Visitor1());
            o.Accept(new Visitor2());

            Console.ReadKey();

        }
    }

    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA el);
        public abstract void VisitElementB(ElementB el);
    }

    class Visitor1 : Visitor
    {
        public override void VisitElementA(ElementA el)
        {
            Console.WriteLine("{0} visited by {1}",el.GetType().Name,this.GetType().Name);
        }

        public override void VisitElementB(ElementB el)
        {
            Console.WriteLine("{0} visited by {1}", el.GetType().Name, this.GetType().Name);
        }
    }

    class Visitor2 : Visitor
    {
        public override void VisitElementA(ElementA el)
        {
            Console.WriteLine("{0} visited by {1}", el.GetType().Name, this.GetType().Name);
        }

        public override void VisitElementB(ElementB el)
        {
            Console.WriteLine("{0} visited by {1}", el.GetType().Name, this.GetType().Name);
        }
    }


    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }

    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
    }

    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
    }

    class ObjectStructure
    {
        List<Element> objects = new List<Element>();

        public void Attach(Element el)
        {
            objects.Add(el);
        }

        public void Detach(Element el)
        {
            objects.Remove(el);
        }

        public void Accept(Visitor visitor)
        {
            foreach(Element obj in objects)
            {
                obj.Accept(visitor);
            }
        }
    }
}
