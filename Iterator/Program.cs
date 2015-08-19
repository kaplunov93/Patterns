using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAg collection = new MyAg();
            IAggregate my = (IAggregate)collection;

            IIterator itterator = my.GetIterator();
            while (!itterator.IsDone)
            {
                Console.WriteLine(itterator.NextItem);
            }
            Console.ReadKey();

        }

        interface IIterator
        {
            string FirstItem { get; }
            string NextItem { get; }
            string CurrentItem { get; }
            bool IsDone { get; }
        }

        interface IAggregate
        {
            IIterator GetIterator();
            string this[int itemIndex] { set; get; }
            int Count { get; }
        }

        class MyIt : IIterator
        {
            List<string> data = null;
            int current = -1;

            public void SetCollection(List<string> data)
            {
                this.data = data;
            }

            string IIterator.FirstItem
            {
                get
                {
                    current = 0;
                    return data[current];
                }
                
            }

            string IIterator.NextItem
            {
                get
                {
                    if (current < data.Count - 1)
                        return data[++current];
                    return null;
                }
            }

            string IIterator.CurrentItem
            {
                get 
                { return data[current]; }
                
            }

            bool IIterator.IsDone
            {
              get
                {
                    if (current < data.Count - 1)
                        return false;
                    return true;
                }
                
            }

        }

        class MyAg : IAggregate
        {
            private List<string> data = new List<string>();

            IIterator IAggregate.GetIterator()
            {
                data.Add("Vasia");
                data.Add("Petia");
                data.Add("Sasha");
                MyIt my = new MyIt();
                my.SetCollection(data);
                return (IIterator)my;
            }

            string IAggregate.this[int index]
            {
                get
                {
                    return data[index];
                }
                set
                {
                    data[index] = value;
                }
            }

            int IAggregate.Count
            {
                get
                {
                    return data.Count;
                }
            }
        }

    }
}
