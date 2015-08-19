using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Class c = new ClassA();
            c.TemplateMethod();
            c = new ClassB();
            c.TemplateMethod();
            Console.ReadKey();
        }
    }

    abstract class Class
    {
        public abstract void MethodA();
        public abstract void MethodB();
        public void TemplateMethod()
        {
            MethodA();
            MethodB();
        }
    }

    class ClassA : Class
    {
        public override void MethodA()
        {
            Console.WriteLine("Method A from {0}",this.GetType().Name);
        }

        public override void MethodB()
        {
            Console.WriteLine("Method B from {0}", this.GetType().Name);
        }
    }

    class ClassB : Class
    {
        public override void MethodA()
        {
            Console.WriteLine("Method A from {0}", this.GetType().Name);
        }

        public override void MethodB()
        {
            Console.WriteLine("Method B from {0}", this.GetType().Name);
        }
    }
}
