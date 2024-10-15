using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal abstract class AbstractClassExample
    {
        
        public void sub(int a,int b) {

            Console.WriteLine(a - b);
        }
        public abstract void Add();

        
    }

    class ImplementAbstractClass : AbstractClassExample
    {
        int a = 10, b = 20;
        public override void Add()
        {
            Console.WriteLine(a + b);
        }

        public static void Main()
        {
            ImplementAbstractClass obj = new ImplementAbstractClass();
            obj.Add();
            obj.sub(obj.a,obj.b);
            Console.ReadLine();

        }
    }

}
