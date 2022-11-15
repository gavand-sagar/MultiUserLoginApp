using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    public class MenuPage : Page
    {

        Dictionary<string, IOption> Options = new Dictionary<string, IOption>();
        public MenuPage()
        {
            Options.Add("1", new LoginOption());
            Options.Add("2", new SignUpOption());
        }
        public override void Show()
        {
            Console.WriteLine("Pick an option!");

            foreach (var item in Options)
            {
                Console.WriteLine(item.Key + ". " + item.Value.Name);
            }

            string input = Console.ReadLine();
            if (Options.ContainsKey(input))
            {
                Options[input].Perform();
            }
            else
            {
                Navigator.NavigateTo(PageType.Menu);
            }
        }
    }
}
