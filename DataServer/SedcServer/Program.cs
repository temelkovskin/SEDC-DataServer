﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer();
            ws.Start();
        }
    }
}
