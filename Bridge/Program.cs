using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner R = new MyRunner();
            R.Implement = new MyImplement1();
            R.Operation();
            R.Implement = new MyImplement2();
            R.Operation();
            Console.ReadKey();
        }
    }

    class Runner
    {
        protected Implement implement;

        public Implement Implement
        {
            set
            {
                implement = value;
            }
        }
        public virtual void Operation()
        {
            implement.Operation();
        }
    }

    class MyRunner: Runner
    {
        public override void Operation()
        {
            base.Operation();
        }
    }

    abstract class Implement
    {
        public abstract void Operation();
    }

    class MyImplement1: Implement
    {
        public override void Operation()
        {
            Console.WriteLine("Run My Implement 1");
        }
    }

    class MyImplement2 : Implement
    {
        public override void Operation()
        {
            Console.WriteLine("Run My Implement 2");
        }
    }
}
