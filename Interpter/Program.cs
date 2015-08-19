using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            List<Exspression> expressions = new List<Exspression>();
            expressions.Add(new TerminalExspression());
            expressions.Add(new NonTerminalExspression());
            expressions.Add(new TerminalExspression());
            expressions.Add(new NonTerminalExspression());
            foreach(Exspression exp in expressions)
            {
                exp.Interpter(context);
            }
            Console.ReadKey();
        }
    }

    class Context
    { }

    abstract class Exspression
    {
        public abstract void Interpter(Context context);
    }

    class TerminalExspression:Exspression
    {
        public override void Interpter(Context context)
        {
            Console.WriteLine("Called Terminal Exspression");
        }
    }

    class NonTerminalExspression : Exspression
    {
        public override void Interpter(Context context)
        {
            Console.WriteLine("Called Non Terminal Exspression");
        }
    }
}
