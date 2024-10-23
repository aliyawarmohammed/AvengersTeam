using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class MyExceptionExample
    {

        public static void Main()
        {
            try
            {
                var num = "ab";

                int c = Convert.ToInt32(num) / 0;
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            finally
            {
                Console.WriteLine("hi");
            }
            Console.ReadLine();

        }
    }
}
