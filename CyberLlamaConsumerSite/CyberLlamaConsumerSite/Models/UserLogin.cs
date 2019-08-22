using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberLlamaAdminSite.Models
{
    public class UserLogin
    {
        public string UserID { get; set; }
        public string UserName{get; set;}
        public int UserType { get; set; }
    }
}