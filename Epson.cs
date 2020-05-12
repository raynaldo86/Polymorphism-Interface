﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIterface
{
    class Epson : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }

        public void Show()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
