using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL;
namespace BLL
{
    public class EmployeeManager
    {
        public static List<Employee> getAll()
        {
            return EmployeeDAL.getAll();
        }
    }
}
