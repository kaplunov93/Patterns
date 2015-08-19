using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker(new MyComand(new Reciever1()));
            invoker.ExecuteComand();
            invoker.SetComand(new MyComand(new Reciever2()));
            invoker.ExecuteComand();
            Console.ReadKey();
        }
    }

    abstract class Comand
    {
        protected Reciever reciever;

        public Comand(Reciever reciever)
        {
            this.reciever = reciever;
        }

        abstract public void Execute();

    }

    class MyComand:Comand
    {
        public MyComand(Reciever reciever) : base(reciever) { }

        public override void Execute()
        {
            reciever.Action();
        }
    }
    
    abstract class Reciever
    {
        public abstract void Action();
    }
    class Reciever1:Reciever
    {
        public override void Action()
        {
            Console.WriteLine("Reciever1.Action();");
        }
    }

    class Reciever2:Reciever
    {
        public override void Action()
        {
            Console.WriteLine("Reciever2.Action();");
        }
    }

    class Invoker
    {
        private Comand comand;

        public void SetComand(Comand comand)
        {
            this.comand = comand;
        }
        public Invoker(Comand comand)
        {
            this.comand = comand;
        }

        public void ExecuteComand()
        {
            comand.Execute();
        }
    }

}
