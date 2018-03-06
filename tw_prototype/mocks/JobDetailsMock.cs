using ThamesWater.Models;

namespace ThamesWater.mocks
{
    public class JobDetailsMock
    {
        public static JobDetails ReturnPriority1BlockageInvestigation()
        {
            return new JobDetails
            {
                sewer_access = "Rear of property",
                description = "Blocked toilet that has now flooded",
                customer_needs_to_be_in = "Yes"
            };
        }
    }
}