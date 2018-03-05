using com.thameswater.Models;

namespace tests.mocks
{
    public class JobDetailsMock
    {
        public static JobDetails returnPriority1BlockageInvestigation()
        {
            JobDetails details = new JobDetails();

            details.sewer_access = "Rear of property";
            details.description = "Blocked toilet that has now flooded";
            details.customer_needs_to_be_in = "Yes";
            return details;
        }
    }
}