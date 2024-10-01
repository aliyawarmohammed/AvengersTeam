using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class VoterApp
    {
        public static void Main()
        {
            Console.WriteLine("Please Enter your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>=18)//true
            {
                Console.WriteLine("Eliggible for Vote");
            }
            else
            {
                Console.WriteLine("Not Eliggible for Vote");

            }

            Console.ReadLine();

        }

    }
}
