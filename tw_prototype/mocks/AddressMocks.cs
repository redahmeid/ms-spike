using com.thameswater.Models;

namespace tests.mocks
{
    public class AddressMocks
    {


        public static Address returnClearwaterCourtAddress()
        {
            Address address = new Address();

            address.first_line = "Clearwater Court";
            address.second_line = "Vastern Road";
            address.town = "Reading";
            address.post_code = "RG1 8DB";

            return address;

        }
        
        public static Address returnClearwaterCourtAddressPostCode()
        {
            Address address = new Address();
            address.post_code = "RG1 8DB";
            return address;

        }
    }
}