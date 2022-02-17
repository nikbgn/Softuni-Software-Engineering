﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split()
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator =
                new ListyIterator<string>(items);

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "END") break;
                else if (cmd == "Move") Console.WriteLine(listyIterator.Move());
                else if (cmd == "HasNext") Console.WriteLine(listyIterator.HasNext());
                else if (cmd == "Print") listyIterator.Print();
            }
            
            
        }



        class ListyIterator<T>
        {

            private readonly List<T> items;

            private int idx;

            public ListyIterator(List<T> collection)
            {
                this.items = collection;
                idx = 0;
            }

            public bool Move()
            {
                if (idx + 1 >= items.Count) return false;
                idx++;
                return true;
            }

            public bool HasNext()
            {
                if (idx + 1 >= items.Count) return false;
                return true;
            }

            public void Print()
            {
                if(!(items.Count <= 0))
                {
                    Console.WriteLine(items[idx]);
                }
                else
                {
                    throw new Exception("Invalid Operation!");
                }
            }

        }
    }
}
