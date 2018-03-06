using System.Collections.Generic;

namespace ThamesWater.Models
{
    public class WorkQueue
    {
        public Job NextJob { get; set; }
        public List<Job> Queue { get; set; }
    }
}