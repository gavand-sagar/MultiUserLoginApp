using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal class PageListContainer
    {
        public static Dictionary<PageType, Page> Pages;
        static PageListContainer()
        {
            Pages = new Dictionary<PageType, Page>();
            Pages.Add(PageType.Login, new LoginPage());
            Pages.Add(PageType.Menu, new MenuPage());
            Pages.Add(PageType.Dashboard, new Dashboard());
            Pages.Add(PageType.SignUp, new SignUpPage());
            Pages.Add(PageType.AddAnItem, new AddItemPage());
            Pages.Add(PageType.ListAll, new ListAllPage());
        }
    }
}
