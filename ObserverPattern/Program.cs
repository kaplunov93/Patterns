using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject my = new Subject();
            my.Add(new Observer());
            my.Add(new Observer());
            my.Add(new Observer());
            my.Notify();
            Console.ReadKey();
        }
    }

    class Observer
    {
        public /*abstract*/ void Update() { Console.WriteLine("Notified"); }
    }

    class Subject
    {
        private List<Observer> clients= new List<Observer>();

        public void Add(Observer client)
        {
            clients.Add(client);
        }

        public void Remove(Observer client)
        {
            clients.Remove(client);
        }

        public void Notify()
        {
            foreach(Observer client in clients)
            {
                client.Update();
            }
        }
    }
}
