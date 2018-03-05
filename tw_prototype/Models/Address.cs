using System;
using System.Security.Cryptography.X509Certificates;

namespace com.thameswater.Models
{
    public class Address:Model
    {
        public Address()
        {
        }
        
        public string first_line { get; set; }
        public string second_line { get; set; }
        public string town { get; set; }
        public string post_code { get; set; }
    }
}
