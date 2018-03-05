using System;
using com.thameswater.Models;
using Microsoft.IdentityModel.Tokens;

namespace tests.mocks
{
    public class JobMocks
    {

        public static Job returnPriority1BlockageInvestigationNotStartedWorkQueue()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 1;
            job.status = "Not Started";
            job.type = "Blockage Investigation";
            job.post_code = AddressMocks.returnClearwaterCourtAddressPostCode().post_code;
            
            //job.customer = CustomerMocks.returnMrJBloggsFromReading();
            //job.job_address = AddressMocks.returnClearwaterCourtAddressPostCode();
            return job;
        }
        
        public static Job returnPriority2SewerCleaningNotStartedWorkQueue()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 2;
            job.status = "Not Started";
            job.type = "Sewer Cleaning - reactive";
            job.post_code = AddressMocks.returnClearwaterCourtAddressPostCode().post_code;
            //job.customer = CustomerMocks.returnMrJBloggsFromReading();
            //job.job_address = AddressMocks.returnClearwaterCourtAddressPostCode();
            return job;
        }
        
        public static Job returnPriority3BlockageInvestigationNotStartedWorkQueue()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 3;
            job.status = "Not Started";
            job.type = "Blockage Investigation";
            job.post_code = AddressMocks.returnClearwaterCourtAddressPostCode().post_code;
            //job.customer = CustomerMocks.returnMrJBloggsFromReading();
            //job.job_address = AddressMocks.returnClearwaterCourtAddressPostCode();
            return job;
        }
        
        public static Job returnPriority4BlockageInvestigationNotStartedWorkQueue()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 4;
            job.status = "Not Started";
            job.type = "Blockage Investigation";
            job.post_code = AddressMocks.returnClearwaterCourtAddressPostCode().post_code;
            //job.customer = CustomerMocks.returnMrJBloggsFromReading();
            //job.job_address = AddressMocks.returnClearwaterCourtAddressPostCode();
            return job;
        }
        
        public static Job returnPollutionIncidentCompleted()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.status = "Completed";
            job.type = "Pollution Incident";
            job.post_code = AddressMocks.returnClearwaterCourtAddressPostCode().post_code;
            job.time_completed = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,13,32,0);
            //job.customer = CustomerMocks.returnMrJBloggsFromReading();
            //job.job_address = AddressMocks.returnClearwaterCourtAddressPostCode();
            return job;
        }

        public static Job returnPriority1BlockageInvestigationNotStartedJob()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 1;
            job.status = "Not Started";
            job.type = "Blockage Investigation";
            job.post_code = AddressMocks.returnClearwaterCourtAddress().post_code;
            job.details = JobDetailsMock.returnPriority1BlockageInvestigation();
            job.customer = CustomerMocks.returnMrJBloggsFromReading();
            job.job_address = AddressMocks.returnClearwaterCourtAddress();
            return job;
        }
        
        public static Job returnPriority1BlockageInvestigationCustomerCalledJob()
        {
            Job job = new Job();
            job.Id = Guid.NewGuid().ToString();
            job.priority = 1;
            job.status = "Customer Called";
            job.type = "Blockage Investigation";
            job.post_code = AddressMocks.returnClearwaterCourtAddress().post_code;
            job.details = JobDetailsMock.returnPriority1BlockageInvestigation();
            job.customer = CustomerMocks.returnMrJBloggsFromReading();
            job.job_address = AddressMocks.returnClearwaterCourtAddress();
            return job;
        }
        
        
    }
}