using ThamesWater.Models;

namespace ThamesWater.mocks
{
    public class AddressMocks
    {
        public static Address ReturnClearwaterCourtAddress()
        {
            return new Address
            {
                FirstLine = "Clearwater Court",
                SecondLine = "Vastern Road",
                Town = "Reading",
                PostCode = "RG1 8DB"
            };
        }
        
        public static Address ReturnClearwaterCourtAddressPostCode()
        {
            return new Address { PostCode = "RG1 8DB" };
        }
    }
}