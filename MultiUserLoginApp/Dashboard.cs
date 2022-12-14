using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    public class Dashboard : Page
    {
        public void ShowDashboard()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {UserData.Username}");
            Console.WriteLine("Pick an option below");
            Console.WriteLine("1. Add an Item");
            Console.WriteLine("2. List all items");
            string input = Console.ReadLine();
            if (input == "1")
            {
                Navigator.NavigateTo(PageType.AddAnItem);
            }else if (input == "2")
            {
                Navigator.NavigateTo(PageType.ListAll);
            }
        }

        public override void Show()
        {
            ShowDashboard();
        }
    }
}
