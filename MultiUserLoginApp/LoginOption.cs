using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal class LoginOption : IOption
    {
        public string Name { get; set; }
        public LoginOption()
        {
            Name = "Login";
        }
        public void Perform()
        {
            Navigator.NavigateTo(PageType.Login);
        }
    }

    internal class SignUpOption : IOption
    {
        public string Name { get; set; }
        public SignUpOption()
        {
            Name = "Sign Up";
        }
        public void Perform()
        {
            Navigator.NavigateTo(PageType.SignUp);
        }
    }
}
