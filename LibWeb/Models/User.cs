using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibWeb.Models
{
    public class User
    {
        public string nome { get; set; }

        public string nome_user { get; set; }
        
        public DateTime date { get; set; }

        public string estado { get; set; }

        public string email { get; set; }

        public string senha { get; set; }
    }
}