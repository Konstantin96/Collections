using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollections
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            LinkedList<string> link = new LinkedList<string>();
            link.AddFirst("bob");
            link.AddFirst("Shon");
            link.AddFirst("KOL");
            link.AddFirst("Trol");
            LinkedListNode<string> node;
            for (node = link.First; node != null; node = node.Next)
            {
                Console.WriteLine(node.Value);
            }

            return;

            Dictionary<int, int> d = new Dictionary<int, int>();
            d.Add(1, 5);
            d.Add(2, 5);
            d.Add(3, 5);
            foreach (var item in d)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            return;

            Queue<int> qe = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                qe.Enqueue(rnd.Next(11));
            }
            Console.WriteLine("1 Очередь : ");
            foreach (var item in qe)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count" + qe.Count);


            Console.WriteLine("2 Очередь : ");
            for (int i = 0; i < qe.Count; i++)
            {
                Console.WriteLine(qe.Dequeue());
            }
            Console.WriteLine("Count" + qe.Count);

            return;

            ArrayList obj = new ArrayList()
            { 1,2,"ggs",'d',0.2f,true};
            WriteCollection(obj);

            return;

            ArrayList collection = Exmpl01(10);
            Console.Write("First Collections: ");
            WriteCollection(collection);
            RemoveElement(1, 5, ref collection);
            Console.WriteLine("------------------------");
            WriteCollection(collection);
            Console.WriteLine("Sort");
            collection.Sort();
            WriteCollection(collection);
        }
        static ArrayList Exmpl01(int i)
        {
            Random rnd = new Random();
            ArrayList arr = new ArrayList();
            for (int r = 0; r < i; r++)
            {
                arr.Add(rnd.Next(1, 10));
            }
            return arr;
        }

        public static void RemoveElement(int i, int j, ref ArrayList arr)
        {
            arr.RemoveRange(i, j);
        }

        public static void AddElement(int i, ref ArrayList arr)
        {
            arr.Add(i);
        }

        public static void WriteCollection(ArrayList arr)
        {
            foreach (var item in arr)
            {
                if (item.GetType() == typeof(int))
                {
                    Console.Write("Int :");
                }
                else if (item.GetType() == typeof(bool))
                {
                    Console.Write("Bool :");
                }
                else if (item.GetType() == typeof(char))
                {
                    Console.Write("Char :");
                }
                else if (item.GetType() == typeof(string))
                {
                    Console.Write("String :");
                }
                else if (item.GetType() == typeof(float))
                {
                    Console.Write("Float :");
                }
                Console.WriteLine(" {0}", item);
            }
        }
    }
}
