using ThamesWater.Models;

namespace ThamesWater.mocks
{
    public class CustomerMocks
    {
        public static Customer ReturnMrJBloggsFromReading()
        {
            return new Customer
            {
                Address = AddressMocks.ReturnClearwaterCourtAddress(),
                Title = "Mr",
                FirstName = "J",
                Surname = "Bloggs"
            };
        }
    }
}