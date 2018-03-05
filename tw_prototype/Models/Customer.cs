using System;
namespace com.thameswater.Models
{
    public class Customer:Model
    {
        public Customer()
        {
        }

        public string title { get; set; }
        public string first_name { get; set; }
        public string surname { get; set; }
        public Address address { get; set; }
        
        
    }
}
