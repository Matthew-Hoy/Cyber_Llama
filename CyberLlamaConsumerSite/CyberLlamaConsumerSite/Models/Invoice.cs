using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models
{
    public class Invoice
    {
        public int user_ID { get; set; }
        public int pc_ID { get; set; }
        public int InvoiceId { get; set; }
        public DateTime date { get; set; }
        public int numItems { get; set; }
        public string type { get; set; }
    }
}