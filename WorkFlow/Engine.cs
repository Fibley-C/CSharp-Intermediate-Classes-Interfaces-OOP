using System.Collections.Generic;

namespace Workflow
{
    internal class Engine
    {
        private readonly IList<IActivity> _workflowActivitys;

        public Engine()
        {
            _workflowActivitys = new List<IActivity>();
        }

        public void RegisterWorkflowActivity(IActivity activity)
        {
            _workflowActivitys.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _workflowActivitys)
            {
                activity.Execute();
            }
        }
    }
}