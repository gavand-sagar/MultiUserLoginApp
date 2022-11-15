using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal class LoginPage : Page
    {
        public override void Show()
        {
            Login();
        }
        internal void Login()
        {
            User user = new User();

            Console.WriteLine("Enter Username: ");
            user.Username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.Password = Console.ReadLine();


            LoginBL loginBL = new LoginBL();
            bool isAuthenticated = loginBL.Validate(user);

            if (isAuthenticated)
            {
                UserData.Username = user.Username;
                Navigator.NavigateTo(PageType.Dashboard);
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine("Please try again!");
            }
        }
    }
}
