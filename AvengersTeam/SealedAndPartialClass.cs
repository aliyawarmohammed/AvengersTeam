using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal sealed class SealedAndPartialClass
    {
       public void show()
        {
            Console.WriteLine("I have done home work");
        }
    }

    internal class SealedAndPartialClass2 //:SealedAndPartialClass
    {
        public static void Main()
        {
            SealedAndPartialClass obj = new SealedAndPartialClass();
            obj.show();
            Console.ReadLine();
    }
    }

}
