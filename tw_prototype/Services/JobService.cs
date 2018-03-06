using System.Collections.Generic;
using System.Linq;
using ThamesWater.mocks;
using ThamesWater.Models;

namespace ThamesWater.Services
{
    public class JobService
    {

        public static WorkQueue GetWorkQueue()
        {
            var queue = new WorkQueue
            {
                NextJob = JobMocks.ReturnPriority1BlockageInvestigationNotStartedWorkQueue()
            };

            var jobs = new List<Job>
            {
                JobMocks.ReturnPriority2SewerCleaningNotStartedWorkQueue(), 
                JobMocks.ReturnPriority4BlockageInvestigationNotStartedWorkQueue(), 
                JobMocks.ReturnPriority3BlockageInvestigationNotStartedWorkQueue(), 
                JobMocks.ReturnPollutionIncidentCompleted()
            };

            queue.Queue = jobs.OrderBy(j => j.TimeCompleted).ThenBy(j => j.Priority).ToList();
            
            return queue;
        }
    }
}