using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class InputDynamic
    {
        public static void Main()
        {
            Console.WriteLine("Enter roll Number");
            int rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            
            
            Console.WriteLine("Enter Salary");
            float Salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("RollNo is" + rollno);
            Console.WriteLine("Name is" + Name);
            Console.WriteLine("Salary is" + Salary);
            Console.ReadLine();

        }
    }
}
