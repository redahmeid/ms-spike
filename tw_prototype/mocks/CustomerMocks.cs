using com.thameswater.Models;

namespace tests.mocks
{
    public class CustomerMocks
    {
        public static Customer returnMrJBloggsFromReading()
        {
            Customer customer = new Customer();

            customer.address = AddressMocks.returnClearwaterCourtAddress();
            customer.title = "Mr";
            customer.first_name = "J";
            customer.surname = "Bloggs";

            return customer;


        }
    }
}