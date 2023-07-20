using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_workflow_engine
{
    internal class Treadmill : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Running in the treadmill...");
        }
    }
}
