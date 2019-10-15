using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models.ViewModels
{
    public class Management
    {
        public List<Employee> Employees { get; set; }
        public List<Statistics> pcSold { get; set; }
        public List<Statistics> pcStock { get; set; }
        public List<Statistics> partSold { get; set; }
        public List<Statistics> partStock { get; set; }
    }
}