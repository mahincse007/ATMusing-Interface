﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction Tr = new Transaction();
            Tr.Start();

            Console.ReadKey();
        }
    }
}
