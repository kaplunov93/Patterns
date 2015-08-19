using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.request();
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Base class SabJect
    /// </summary>
    abstract class SubJect
    {
        public abstract void request();
    }
    /// <summary>
    /// Derived class Subject
    /// </summary>
    class Subject : SubJect
    {
        public override void request()
        {
            Console.WriteLine("Called Subject.request();");
        }
    }
    /// <summary>
    /// Proxy Class
    /// </summary>
    class Proxy : SubJect
    {
        private Subject subject;

        public override void request()
        {
            if (subject == null)
                subject = new Subject();
            subject.request();
        }
    }
}
