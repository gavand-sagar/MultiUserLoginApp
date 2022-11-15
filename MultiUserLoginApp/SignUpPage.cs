using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    public class SignUpPage : Page
    {
        public override void Show()
        {
            Console.WriteLine("We are about to sign up!");
            User u = new User();
            Console.WriteLine("Enter Name");
            u.Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            u.Password = Console.ReadLine();
            bool added = new LoginBL().AddUser(u);
            if (added)
            {
                Navigator.NavigateTo(PageType.Menu);
            }
            else
            {
                Navigator.NavigateTo(PageType.SignUp);
            }
        }
    }
}
