using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
   internal    abstract  class AbtractClassExample
    {
        //methods withot implementation
       public abstract void Show();//abstract method
        //methods with Implmentation
        public void getResult()//non abstract 
        {
            Console.WriteLine("get result Called");

           
        }

        public class TenTeam:AbtractClassExample

        {

            public override void Show() {
            Console.WriteLine("kkk");
            }

            public static void Main()
            {
                TenTeam t = new TenTeam();
                t.Show();

                Console.ReadLine();
            }



        }
    }


}
