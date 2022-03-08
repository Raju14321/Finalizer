using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    class DestDemo2 : DestDemo1
    {
        public DestDemo2()
        {
            Console.WriteLine("Instance2 is created.");
        }
        ~DestDemo2()
        {
            Console.WriteLine("Instance2 is destroyed.");
        }
        static void Main()
        {
            DestDemo2 obj = new DestDemo2();
            obj = null;
            GC.Collect();
            Console.ReadLine();
        }
    }

}
