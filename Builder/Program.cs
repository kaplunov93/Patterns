using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dialer dialer = new Dialer();
            Builder builder= new CarBuilder();
            dialer.Construct(builder);
            Product product = builder.Get();
            product.Show();
            Console.ReadKey();
        }
    }

    class Dialer
    {
        public void Construct(Builder b)
        {
            b.AddParts();
        }
    }

    abstract class Builder
    {
        public abstract void AddParts();
        public abstract Product Get();
    }

    class CarBuilder: Builder
    {
        private Product parts = new Product();

        public override void AddParts()
        {
            parts.Add("Rims");
            parts.Add("Schocks");
            parts.Add("Engine");
            parts.Add("lamps");
            parts.Add("Seats");
            parts.Add("Music");
        }

        public override Product Get()
        {
            return parts;
        }
    }

    class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product contains:");
            foreach(string part in _parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
