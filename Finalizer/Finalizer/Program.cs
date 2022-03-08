using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalizer
{
    class DestDemo1
    {
      public DestDemo1()
      {
            Console.WriteLine("Instance off created");
      }
      ~DestDemo1()
      {
            Console.WriteLine("Instance of destroye");
      }
       static void Main()
       {
            DestDemo1 d1 = new DestDemo1();
            DestDemo1 d2 = new DestDemo1();
            DestDemo1 d3 = new DestDemo1();
            DestDemo1 d4 = new DestDemo1();
            d2 = null;
            GC.Collect();
            Console.ReadLine();
            
            
       }

    }
}
