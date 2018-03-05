using System.Collections.Generic;

namespace com.thameswater.Models
{
    public class WorkQueue
    {
        public Job nextJob { get; set; }
        public List<Job> queue { get; set; }
    }
}