using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class MethodOverloading
    {

        void faculty(string Engsub)
        {
            Console.WriteLine("Sir going to teach english");
        }

        void faculty(string Engsub,string Hindi)
        {
            Console.WriteLine("Sir going to teach english and Hindi");
        }

        void faculty(string Engsub,string Hindi,string Sanskrit)
        {
            Console.WriteLine("Sir going to teach english,hindi,sanskrit");
        }


        public static void Main()
        {
            MethodOverloading obj = new MethodOverloading();

            obj.faculty("Englis");
            obj.faculty("Englis","hindi");
            obj.faculty("Englis","hindi","sanskrit");

            Console.ReadLine();

        }
    }
}
