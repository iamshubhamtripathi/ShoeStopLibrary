using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStopLibrary.Models
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobileNumber { get; set; }
        public int primaryAddressId { get; set; }
        public string password { get; set; }
    }
}
