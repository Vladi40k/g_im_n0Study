using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study.Autorization
{
    [Serializable]
    public class User
    {
        public User(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }

        public string email { get; set; }
        public string pass { get; set; }

    }
}