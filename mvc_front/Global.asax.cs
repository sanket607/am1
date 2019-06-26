using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BOL;
using DAL;
using BLL;

namespace mvc_front
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            List<Employee> ems = new List<Employee>();
            ems = EmployeeManager.getAll();

            //RepoManager.GetAllProducts();
            this.Application["emps"] = ems;
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
