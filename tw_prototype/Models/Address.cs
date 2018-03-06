namespace ThamesWater.Models
{
    public class Address : IModel
    {
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
    }
}
