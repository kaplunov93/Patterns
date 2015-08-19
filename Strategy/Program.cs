using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyRunner a = new StrategyRunner(new StrategyA());
            StrategyRunner b = new StrategyRunner(new StrategyB());
            StrategyRunner c = new StrategyRunner(new StrategyC());
            a.Run();
            b.Run();
            c.Run();
            Console.ReadKey();
        }
    }

    abstract class Strategy
    {
        public abstract void Strategyinterface();
    }

    class StrategyA:Strategy
    {
        public override void Strategyinterface()
        {
            Console.WriteLine("Called Strategy A");
        }
    }

    class StrategyB : Strategy
    {
        public override void Strategyinterface()
        {
            Console.WriteLine("Called Strategy B");
        }
    }

    class StrategyC : Strategy
    {
        public override void Strategyinterface()
        {
            Console.WriteLine("Called Strategy C");
        }
    }

    class StrategyRunner
    {
        Strategy _strategy;
        public StrategyRunner(Strategy strategy)
        {
            _strategy = strategy;
        }

        public void Run()
        {
            _strategy.Strategyinterface();
        }
    }
}
