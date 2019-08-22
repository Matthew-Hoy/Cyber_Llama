using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaConsumerSite.Models
{
    public class UserPositionView
    {
        public IEnumerable<UserPositions> userPosition { get; set; }
        public string chosenPosition { get; set; }
    }
}