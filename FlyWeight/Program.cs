using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 0;

            FlyWeightFactory f = new FlyWeightFactory();
            FlyWeight fx = f.GetFlyWeight("X");
            fx.Operation(++state);
            FlyWeight fy = f.GetFlyWeight("Y");
            fy.Operation(++state);
            FlyWeight fz = f.GetFlyWeight("Z");
            fz.Operation(++state);
            Console.ReadKey();
        }
    }


    class FlyWeightFactory
    {
        private Hashtable flyweights = new Hashtable();
        
        public FlyWeightFactory()
        {
            flyweights.Add("X",new CFlyWeight());
            flyweights.Add("Y", new CFlyWeight());
            flyweights.Add("Z", new CFlyWeight());
        }  

        public FlyWeight GetFlyWeight(string key)
        {
            return (FlyWeight)flyweights[key];
        }
    }

    abstract class FlyWeight
    {
        public abstract void Operation(int state);
    }

    class CFlyWeight: FlyWeight
    {
        public override void Operation(int state)
        {
            Console.WriteLine("FlyWeight: {0}",state);
        }
    }
}
