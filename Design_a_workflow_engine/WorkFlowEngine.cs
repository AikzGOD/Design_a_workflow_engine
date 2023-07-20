using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_workflow_engine
{
    internal class WorkFlowEngine
    {
        public void Run(IActivity activity)
        {
            activity.Run();
        }
    }
}
