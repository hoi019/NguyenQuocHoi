using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class CustomersMD
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string CName { get; set; }
        public string CPhone { get; set; }
        public string CAddress { get; set; }
        public string CEmail { get; set; }
    }
}
