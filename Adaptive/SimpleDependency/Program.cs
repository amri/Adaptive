﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDependency
{
    class Program
    {
        static void Main(string[] args)
        {
              IAdapter adapter = new Adapter(new Target());
                Console.WriteLine(adapter.MethodA());
        }
    }
}
