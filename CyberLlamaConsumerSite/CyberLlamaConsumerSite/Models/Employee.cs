using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models
{
    public class Employee
    {
        public int Admin_ID { get; set; }
        public string First_Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Conrtact_Number { get; set; }
        public int Position { get; set; }
    }
}