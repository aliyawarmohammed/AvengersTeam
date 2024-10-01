using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class NestedIf
    {

        public static void Main() 
        {

            Console.WriteLine("Start your Program");
            int a = 20, b = 10, c = 5;

            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine("a is greates");
                }
                else if(b>a)
                {
                    if(b>c)
                    {
                        Console.WriteLine("b is greates");

                    }
                    else if(c>a)
                    {
                        if(c>b)
                        {
                            Console.WriteLine("c is greates");

                        }
                    }
                }
            }
            else if(b>c)
            {
                Console.WriteLine("b is greates");
            }
              else if(c>a)
            {
                Console.WriteLine("c is greates");

            }


            Console.ReadLine();
        }   
    }
}
