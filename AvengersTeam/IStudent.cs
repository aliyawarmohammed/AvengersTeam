using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal interface IStudent
    {
        void show();
    }

    internal interface IFaculty
    {
        void show();
    }

    class A : IStudent, IFaculty
    {


        void IStudent.show()
        {
            Console.WriteLine("Boom Boom Show!");
        }
        void IFaculty.show()
        {
            Console.WriteLine("Boom Boom ggggg!");
        }


        public static void Main()
        {
            IStudent obj = new A();
            obj.show();

            IFaculty obj1 = new A();
            obj.show();

            obj1.show();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}