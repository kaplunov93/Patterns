using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new StateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();

            Console.ReadKey();
        }
    }

    class Context
    {
        private State _state;

        public Context(State state)
        {
            _state = state;
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine("State change to: {0}",_state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }

    abstract class State
    {
        abstract public void Handle(Context context);
    }

    class StateA : State
    {
        public override void Handle(Context context)
        {
            context.State =new StateB();
        }
    }

    class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
}
