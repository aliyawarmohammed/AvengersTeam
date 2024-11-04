using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class FilinfoExample
    {

        public static void Main()
        {
			try
			{

                //beging creation of file
                //string path = "D:\\FirstFile.txt";

                //FileInfo fi = new FileInfo(path);
                //fi.Create();
                //Console.WriteLine("File is Created");
                ///Ending creation file
                ///


                //writing data inside file
                string path = "D:\\First";

                FileInfo fi = new FileInfo(path);
                //StreamWriter sw = fi.CreateText();
                //sw.WriteLine("Hello guys ");
                //sw.Close();
                //////////////////////
                ///


                //StreamReader sr=fi.OpenText();

                //string output ="";
                //while ((output=sr.ReadLine())!=null)
                //{

                //    Console.WriteLine(output);
                
                //}



                DirectoryInfo directory=new DirectoryInfo(path);


                directory.Delete();
                Console.WriteLine("diector crated ");



                Console.ReadLine();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
        }
    }
}
