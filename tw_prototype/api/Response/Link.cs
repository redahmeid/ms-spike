using System;
namespace com.thameswater.api.Response
{
    public class Link
    {
        public Link()
        {
        }
        public string rel { get; set; }
        public string url { get; set; }
        public string defaultText { get; set; }

    }
}
