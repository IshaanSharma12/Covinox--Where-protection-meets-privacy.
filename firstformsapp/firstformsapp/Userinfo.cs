using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstformsapp
{
    internal class Userinfo
    {
        public string Username { get; set; }
        public string UserId { get; set; }
        public int UserAge { get; set; }
        
        public Userinfo( string username, string userId, int userAge)
        {
            Username= username;
            UserId = userId;
            UserAge = userAge;
        }

        public override string ToString()
        {
            return UserAge + "\t" + Username + "\t" + UserId + "\n";
        }
    }
}
