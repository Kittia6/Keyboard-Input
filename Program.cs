﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            Console.WriteLine("Say hello!");
            response = Console.ReadLine();

            Console.WriteLine("You said: " + response);
        } 
    }
}
