using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype1 P1 = new Prototype1(1);
            Prototype P = P1.Clone();
            Console.WriteLine("Cloned: {0}", P.Id);

            Prototype2 P2 = new Prototype2(2);
            P = P2.Clone();
            Console.WriteLine("Cloned: {0}", P.Id);

            Console.ReadKey();
        }
    }

    abstract class Prototype
    {
        private int _Id;

        public Prototype(int Id)
        {
            this._Id=Id;
        }

        public int Id { get { return _Id; } }

        public abstract Prototype Clone();
    }

    class Prototype1:Prototype
    {
        public Prototype1(int Id): base(Id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    class Prototype2 : Prototype
    {
        public Prototype2(int Id)
            : base(Id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
