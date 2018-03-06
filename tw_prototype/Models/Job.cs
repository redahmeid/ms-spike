using System;

namespace ThamesWater.Models
{
    public class Job:IModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public string PostCode { get; set; }
        public DateTime TimeCompleted { get; set; }
        
        public JobDetails Details { get; set; }
        public Customer Customer { get; set; }
        public Address JobAddress { get; set; }
    }
}
