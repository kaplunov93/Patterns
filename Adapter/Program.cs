using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Target adapter = new Adapter();
            adapter.Request();
            Console.ReadKey();
        }
    }

    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target request");
        }
    }

    class Adapter : Target
    {
        private SpecificAdapter my = new SpecificAdapter();
        public override void Request()
        {
            Console.WriteLine("Called Adapter Request");
            my.SpecificRequest();

        }
    }

    class SpecificAdapter
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called Specific Request");
        }
    }
}
