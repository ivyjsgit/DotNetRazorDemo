using System;

namespace DotNetRazorDemo.Models
{
    public class User
    {
        public Guid id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }
        public String city { get; set; }
    }
}
