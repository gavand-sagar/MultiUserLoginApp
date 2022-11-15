using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal static class Navigator
    {
        public static void NavigateTo(PageType pageName)
        {
            Console.Clear();
            PageListContainer.Pages[pageName].Show();
        }
    }
}
