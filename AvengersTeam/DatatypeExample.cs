using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class DatatypeExample
    {
        //how to give static values
        int Sid = 1211;
        string Sname = "Manasa";
        decimal fees = 12089.8723234M;
        bool choice = false;
        public static void Main()
        {
            int Sid = 1211;
            string Sname = "Manasa";
            decimal fees = 12089.8723234M;
            bool choice = false;
            string res;

            DatatypeExample obj=new DatatypeExample();

            if (choice==true)
            {
                res = "50%";
            }
            else
            {
                res = "no";
            }

            Console.WriteLine("Student Id is " + obj.Sid);
            Console.WriteLine("Student Name is " + obj.Sname);
            Console.WriteLine("Student Fees is " + obj.fees);
            Console.WriteLine("choice of Student to pay Fees is " + res);

            Console.ReadLine();
        }
    }
}
