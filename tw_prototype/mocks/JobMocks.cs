using System;
using ThamesWater.Models;

namespace ThamesWater.mocks
{
    public class JobMocks
    {

        public static Job ReturnPriority1BlockageInvestigationNotStartedWorkQueue()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 1,
                Status = "Not Started",
                Type = "Blockage Investigation",
                PostCode = AddressMocks.ReturnClearwaterCourtAddressPostCode().PostCode,
                //Customer = CustomerMocks.returnMrJBloggsFromReading(),
                //JobAddress = AddressMocks.returnClearwaterCourtAddressPostCode()
            };
        }
        
        public static Job ReturnPriority2SewerCleaningNotStartedWorkQueue()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 2,
                Status = "Not Started",
                Type = "Sewer Cleaning - reactive",
                PostCode = AddressMocks.ReturnClearwaterCourtAddressPostCode().PostCode,
                //Customer = CustomerMocks.returnMrJBloggsFromReading(),
                //JobAddress = AddressMocks.returnClearwaterCourtAddressPostCode()
            };
        }
        
        public static Job ReturnPriority3BlockageInvestigationNotStartedWorkQueue()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 3,
                Status = "Not Started",
                Type = "Blockage Investigation",
                PostCode = AddressMocks.ReturnClearwaterCourtAddressPostCode().PostCode,
                //Customer = CustomerMocks.returnMrJBloggsFromReading(),
                //JobAddress = AddressMocks.returnClearwaterCourtAddressPostCode()            
            };
        }
        
        public static Job ReturnPriority4BlockageInvestigationNotStartedWorkQueue()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 4,
                Status = "Not Started",
                Type = "Blockage Investigation",
                PostCode = AddressMocks.ReturnClearwaterCourtAddressPostCode().PostCode,
                //Customer = CustomerMocks.returnMrJBloggsFromReading(),
                //JobAddress = AddressMocks.returnClearwaterCourtAddressPostCode()            
            };
        }
        
        public static Job ReturnPollutionIncidentCompleted()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Status = "Completed",
                Type = "Pollution Incident",
                PostCode = AddressMocks.ReturnClearwaterCourtAddressPostCode().PostCode,
                TimeCompleted = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 13, 32, 0),
                //Customer = CustomerMocks.returnMrJBloggsFromReading(),
                //JobAddress = AddressMocks.returnClearwaterCourtAddressPostCode()
            };
        }

        public static Job ReturnPriority1BlockageInvestigationNotStartedJob()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 1,
                Status = "Not Started",
                Type = "Blockage Investigation",
                PostCode = AddressMocks.ReturnClearwaterCourtAddress().PostCode,
                Details = JobDetailsMock.ReturnPriority1BlockageInvestigation(),
                Customer = CustomerMocks.ReturnMrJBloggsFromReading(),
                JobAddress = AddressMocks.ReturnClearwaterCourtAddress()
            };
        }
        
        public static Job ReturnPriority1BlockageInvestigationCustomerCalledJob()
        {
            return new Job
            {
                Id = Guid.NewGuid().ToString(),
                Priority = 1,
                Status = "Customer Called",
                Type = "Blockage Investigation",
                PostCode = AddressMocks.ReturnClearwaterCourtAddress().PostCode,
                Details = JobDetailsMock.ReturnPriority1BlockageInvestigation(),
                Customer = CustomerMocks.ReturnMrJBloggsFromReading(),
                JobAddress = AddressMocks.ReturnClearwaterCourtAddress()
            };
        }
    }
}