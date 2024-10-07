using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class RunTimePolymorphism
    {
      public virtual void show()
        {
            Console.WriteLine("Stree2");
        }

    }


    internal class RunTimePolymorphism2: RunTimePolymorphism
    {
        public override void show()
        {
            Console.WriteLine("Chichoree Movie");
        }

        public static void Main()
        {
            RunTimePolymorphism obj = new RunTimePolymorphism2();
            obj.show();
            Console.ReadLine();
        }

    }

}
