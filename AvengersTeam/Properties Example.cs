using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvengersTeam
{
    internal class Properties_Example
    {

        private string name="Ganghadar vidhyadhar shastri";
        private int age=40;
        public int MyAge { get; set; } = 12;
        public   string Name 
        {
            get { return name; }//readonly properties
            set { name = value; }//write properties
        }


    }


    internal class Properties_Shaktiman: Properties_Example
    {

         public static void Main()
        {
            Properties_Shaktiman obj = new Properties_Shaktiman();
            obj.Name = "shaktiman";
            obj.MyAge = 100;
            Console.WriteLine(obj.MyAge);
            Console.WriteLine(obj.Name);
            Console.ReadLine();
        }




    }
}
