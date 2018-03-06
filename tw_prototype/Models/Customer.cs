namespace ThamesWater.Models
{
    public class Customer:IModel
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public Address Address { get; set; }
    }
}
