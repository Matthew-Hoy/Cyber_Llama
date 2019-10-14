using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models
{
    public class Delivery
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public string Method { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total {get;set;}
        public List<Cart> Products {get;set;}
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }

    public enum DeliveryMethod
    {
        Collection,
        Drop_Off
    }
}