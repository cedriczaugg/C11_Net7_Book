﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal partial class Program
    {
        static void Output(string title, IEnumerable<string> collection)
        {
            WriteLine(title);
            foreach (string item in collection)
            {
                WriteLine($" {item}");
            }
        }

        static void OutputPQ<TElement, TPriority>(string title,
            IEnumerable<(TElement Element, TPriority Priority)> collection)
        {
            WriteLine(title);
            foreach ((TElement, TPriority) item in collection)
            {
                WriteLine($" {item.Item1}: {item.Item2}");
            }
        }
    }
}
