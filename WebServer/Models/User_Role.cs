using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServer.Models
{
    public class User_Role    
    {
        public static string Superadmin()
        {
            return ("superadmin");
        }

        public static string Admin()
        {
            return ("admin");
        }

        public static string Manager()
        {
            return ("manager");
        }

        public static string User()
        {
            return ("user");
        }
    }
}
