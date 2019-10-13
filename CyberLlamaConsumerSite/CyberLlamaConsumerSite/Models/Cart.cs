using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models
{
    public class Cart
    {
        //<!--needed -> an array of cart containing(product id, name, image link, price, quantity)-->
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ImageLink { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int MaxQuantity { get; set; }
        public bool Keep { get; set; }
    }
}