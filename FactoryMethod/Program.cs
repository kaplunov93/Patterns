using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories =new Factory[2];
            factories[0] = new Factory1();
            factories[1] = new Factory2();
            foreach (Factory factory in factories)
            {
                Product product = factory.Create();
                Console.WriteLine(product.GetType().Name + " by " + factory.GetType().Name);
            }
            Console.ReadKey();
        }
    }

    abstract class Product
    {

    }

    class Product1:Product
    {

    }

    class Product2:Product
    {

    }

    abstract class Factory
    {
        public abstract Product Create();
    }

    class Factory1:Factory
    {
        public override Product Create()
        {
            return new Product1();
        }
    }

    class Factory2 : Factory
    {
        public override Product Create()
        {
            return new Product2();
        }
    }
}
