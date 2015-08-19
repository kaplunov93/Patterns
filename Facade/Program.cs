using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            facade.MethodC();
            Console.ReadKey();
        }
    }

    class Facade
    {
        private SybSystem1 _one;
        private SybSystem2 _two;
        private SybSystem3 _three;
        private SybSystem4 _four;

        public Facade()
        {
            _one = new SybSystem1();
            _two = new SybSystem2();
            _three = new SybSystem3();
            _four = new SybSystem4();
        }

        public void MethodA()
        {
            Console.WriteLine("\n ---- Method A run ----");
            _one.Method();
            _two.Method();
            _three.Method();
            _four.Method();
        }

        public void MethodB()
        {
            Console.WriteLine("\n ---- Method B run ----");
            _one.Method();
            _two.Method();
        }

        public void MethodC()
        {
            Console.WriteLine("\n ---- Method C run ----");
            _three.Method();
            _four.Method();
        }

    }

    class SybSystem1
    {
        public void Method()
        {
            Console.WriteLine("SybSystem 1 method called");
        }
    }

    class SybSystem2
    {
        public void Method()
        {
            Console.WriteLine("SybSystem 2 method called");
        }
    }

    class SybSystem3
    {
        public void Method()
        {
            Console.WriteLine("SybSystem 3 method called");
        }
    }

    class SybSystem4
    {
        public void Method()
        {
            Console.WriteLine("SybSystem 4 method called");
        }
    }
}
