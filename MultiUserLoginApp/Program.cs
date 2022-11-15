using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUserLoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Navigator.NavigateTo(PageType.Menu);
            Console.ReadLine();
        }


        static void CountTill(int limit)
        {
            while (true)
            {
                Console.WriteLine("Something is here");
                return;
            }

        }


       

    }
}
