using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_a_workflow_engine
{
    internal class WorkFlow
    {
        public List<IActivity> Activities { get; }

        public WorkFlow()
        {
            Activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            Activities.Add(activity);
        }
    }
}
