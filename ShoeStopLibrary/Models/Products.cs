using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStopLibrary.Models
{
    public class Products
    {
        public int id { get; set; }
        public string  brand { get; set; }
        public string  productName { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string category { get; set; }
        public int size { get; set; }
        public string color { get; set; }
        public int quantity { get; set; }
        public string imageUrl { get; set; }


    }
}
