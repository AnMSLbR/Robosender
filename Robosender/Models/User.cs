using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robosender.Models
{
    internal class User
    {
        public string SessionStatus { get; set; }
        public int UserId { get; set; }
        public bool Subscription { get; set; }
        public string ExpiredDate { get; set; }
    }
}
