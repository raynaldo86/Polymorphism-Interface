using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismIterface
{
    class LaserJet : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }

        public void Show()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}
