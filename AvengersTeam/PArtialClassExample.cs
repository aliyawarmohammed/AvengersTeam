using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal partial class PArtialClassExample
    {
        public void AddToCart() { Console.WriteLine("add to cart is called"); }
    }

    internal partial class PArtialClassExample
    {
        public void RemoveToCart() { Console.WriteLine("remove to cart is called"); }
    }

    internal partial class PArtialClassExample
    {
        public static void Main() {

            PArtialClassExample obj = new PArtialClassExample();
            obj.AddToCart();
            obj.RemoveToCart();
            Console.ReadLine();

        }
    }
}
