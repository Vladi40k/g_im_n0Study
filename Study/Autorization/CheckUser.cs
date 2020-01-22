using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study.Autorization
{
    public class CheckUser
    {

        //public CheckUser(BD) { } pass

        public static bool Check_Stday(User user)
        {
            return user.email == "test_email" && user.pass == "test_pass" ? true : false;
        }

        public bool Check(User user)
        {
            return false;
        }

    }
}