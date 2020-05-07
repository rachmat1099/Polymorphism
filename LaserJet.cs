using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Laserjet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimmension : 12*12");
        }

        public override void Print()
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}
