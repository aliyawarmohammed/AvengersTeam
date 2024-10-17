using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoomsDay
{
    internal class ListExample2
    {

        public static void Main()
        {
            List<EmployeeModel> listobj = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1211;
            emp.EmpName = "Jasprit";
            emp.EmpSalary = 9393;


            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 1212;
            emp1.EmpName = "Ganga";
            emp1.EmpSalary = 8393;


            listobj.Add(emp);
            listobj.Add(emp1);

            foreach (var item in listobj)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.EmpSalary);
            }
            Console.ReadLine();
        }
    }
}
