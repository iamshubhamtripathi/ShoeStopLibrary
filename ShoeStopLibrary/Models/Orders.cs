using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStopLibrary.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int userId { get; set; }
        public int addressId { get; set; }
        public int quantity { get; set; }
        public string status { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime deliveredDate { get; set; }

    }
}
