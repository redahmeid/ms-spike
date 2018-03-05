using System;
namespace com.thameswater.Models
{
    public class Job:Model
    {
        public Job()
        {
        }
        
        
        public string Id { get; set; }
        public string type { get; set; }
        public int priority { get; set; }
        public string status { get; set; }
        public string post_code { get; set; }
        public DateTime time_completed { get; set; }
        
        public JobDetails details { get; set; }
        public Customer customer { get; set; }
        public Address job_address { get; set; }
        
        
        
    }
}
