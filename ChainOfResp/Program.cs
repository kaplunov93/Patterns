using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] requests = new int[] {1,12,23,2,15,29 };
            Handler h1 = new Handler1();
            Handler h2 = new Handler2();
            Handler h3 = new Handler3();
            h2.SetSuccessor(h3);
            h1.SetSuccessor(h2);
            foreach(int request in requests)
                h1.HandleRequest(request);
            Console.ReadKey();
        }
    }

    abstract class Handler
    {
        protected Handler succesor;

        public void SetSuccessor(Handler succesor)
        {
            this.succesor = succesor;
        }

        public abstract void HandleRequest(int request);
    }
    
    class Handler1:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (succesor != null)
                succesor.HandleRequest(request);
        }
    }

    class Handler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (succesor != null)
                succesor.HandleRequest(request);
        }
    }

    class Handler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            else if (succesor != null)
                succesor.HandleRequest(request);
        }
    }
}
