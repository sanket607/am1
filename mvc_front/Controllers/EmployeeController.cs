using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using BOL;
namespace mvc_front.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            string msg = "Emp LIst";
            List<Employee> emp = new List<Employee>();
            emp = EmployeeManager.getAll();

            ViewData["emps"] = emp;
            return View();
        }
    }
}