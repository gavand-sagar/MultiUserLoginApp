using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LoginBL
    {
        List<User> users = new List<User>();
        public bool Validate(User user)
        {

            if (user == null)
            {
                return false;
            }
            else
            {
                return (user.Username == "Admin" && user.Password == "123");
            }
        }

    }
}
