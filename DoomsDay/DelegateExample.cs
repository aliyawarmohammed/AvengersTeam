using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{

    delegate void ShowScreen();
    internal class DelegateExample
    {
        public void Show()
        {

            Console.WriteLine("Hi am JAck");
        }

        public void Showchan()
        {

            Console.WriteLine("Hi am chan");
        }

        public static void Main()
        {
            DelegateExample obj = new DelegateExample();
            ShowScreen objdel = new ShowScreen(obj.Show);
            objdel += obj.Showchan;
            //objdel.Invoke();
            Console.ReadLine();

        }

    }
}


//Delegate is similar to a function pointer in C++