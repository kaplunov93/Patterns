using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";
            CareTaker c = new CareTaker();
            c.Memento = o.CreateMemento();
            o.State = "Off";
            o.SetMemento(c.Memento);
            Console.ReadKey();
            
        }
    }

    class Memento
    {
        private string _state;

        public Memento(String state)
        {
            _state = state;
        }

        public string State
        {
            get
            {
                return _state;
            }
        }
    }

    class CareTaker
    {
        private Memento memento;

        public Memento Memento
        {
            get
            {
                return memento;
            }
            set
            {
                memento = value;
            }
        }

    }

    class Originator
    {
        private string _state;

        public string State
        {
            set
            {
                _state = value;
                Console.WriteLine("State: {0}",_state);
            }
            get
            {
                return _state;
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(_state);
        }

        public void SetMemento(Memento memento)
        {
           Console.WriteLine("Restoring State");
            State = memento.State;
        }
    }
}
