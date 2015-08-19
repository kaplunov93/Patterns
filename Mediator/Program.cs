using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new Mediator();

            Client1 c1 = new Client1(m);
            Client2 c2 = new Client2(m);

            m.Client1 = c1;
            m.Client2 = c2;

            c1.Send("Hello!!!");
            c2.Send("And you Hello!!!");

            Console.ReadKey();
        }
    }

    abstract class IMediator
    {
        abstract public void Send(String message,IClient client);
    }

    class Mediator : IMediator
    {
        private Client1 c1;
        private Client2 c2;

        public Client1 Client1 { set { c1 = value; } }
        public Client2 Client2 { set { c2 = value; } }

        public override void Send(string message, IClient client)
        {
            if (client == c1)
                c2.Notyfy(message);
            else c1.Notyfy(message);
        }
    }

    abstract class IClient
    {
        protected IMediator mediator;

        public IClient(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Send(String message);
        public abstract void Notyfy(String message);
    }

    class Client1 : IClient
    {
        public Client1(IMediator mediator) : base(mediator) { }
        
        public override void Send(string message)
        {
            mediator.Send(message, this);
        }

        public override void Notyfy(string message)
        {
            Console.WriteLine("Client 1 notified : {0}",message);
        }
    }

    class Client2 : IClient
    {
        public Client2(IMediator mediator) : base(mediator) { }

        public override void Send(string message)
        {
            mediator.Send(message, this);
        }

        public override void Notyfy(string message)
        {
            Console.WriteLine("Client 2 notified : {0}", message);
        }
    }


}
