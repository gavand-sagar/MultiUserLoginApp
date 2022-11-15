using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SpecialUser : User
    {
        public double discount { get; set; }

        public override void DisplayInformation()
        {
            Console.WriteLine($"This is a special user {Username}, with {discount} Discount");
        }
    }

    public class GoldUser : SpecialUser
    {
        public override void DisplayInformation()
        {
            Console.WriteLine($"Gold {Username}, so password is not visible");
        }
    }
}
