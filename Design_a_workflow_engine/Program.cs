using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_workflow_engine
{
    internal class Program
    {
        static void Main()
        {
            WorkFlow workflow = new WorkFlow();

            workflow.AddActivity(new Jogging());
            workflow.AddActivity(new Treadmill());

            var workflowEngine = new WorkFlowEngine();

            //Show Activities
            foreach (IActivity activity in workflow.Activities)
            {
                workflowEngine.Run(activity);
            }

        }
    }
}
