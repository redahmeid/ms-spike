using System.Collections.Generic;
using System.Linq;
using com.thameswater.Models;
using tests.mocks;

namespace tw_prototype.Services
{
    public class JobService
    {

        public static WorkQueue getWorkQueue()
        {
            WorkQueue queue = new WorkQueue();
            List<Job> jobs = new List<Job>();

            queue.nextJob = JobMocks.returnPriority1BlockageInvestigationNotStartedWorkQueue();
            
            jobs.Add(JobMocks.returnPriority2SewerCleaningNotStartedWorkQueue());
            jobs.Add(JobMocks.returnPriority4BlockageInvestigationNotStartedWorkQueue());
            jobs.Add(JobMocks.returnPriority3BlockageInvestigationNotStartedWorkQueue());           
            jobs.Add(JobMocks.returnPollutionIncidentCompleted());

            queue.queue = jobs.OrderBy(j => j.time_completed).ThenBy(j => j.priority).ToList();
            
            return queue;
        }

        
    }
}