using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class GreatestNumber
    {
        public static void Main()
        {
            Console.WriteLine("Start your Program");
            int a=10,b=10,c=10;

            if(a>b && a>c)
            {
                Console.WriteLine("a is greatest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("b is greatest");

            }
            else if(c>a && c>b) 
            {
                Console.WriteLine("c is greatest");

            }
            else
            {
                Console.WriteLine("All are Equal");

            }

        }
    }
}
