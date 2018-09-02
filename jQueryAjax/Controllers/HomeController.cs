using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendReceivedValue(string inputString)
        {
            return Json(inputString);

        }
        public ActionResult GetEmployee(int empId)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmployeeId = 1, FirstName="Arun", LastName = "Kumar" });
            employees.Add(new Employee { EmployeeId = 2, FirstName="Govind", LastName = "Raj" });
            return Json(employees.Where(e => e.EmployeeId == empId),JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetResult()
        {
            return Json("I'm JSON data", JsonRequestBehavior.AllowGet);
        }
        public ActionResult PostEmployee(int? EmployeeId, string FirstName, string LastName )

        {
            Employee employee = new Employee();
            employee.EmployeeId = EmployeeId;
            employee.FirstName = FirstName;
            employee.LastName = LastName;
            return Json(employee);
        }
        public ActionResult GetEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { EmployeeId = 1, FirstName = "Arun", LastName = "Kumar" });
            employees.Add(new Employee { EmployeeId = 2, FirstName = "Govind", LastName = "Raj" });
            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }

    class Employee
    {
        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string  LastName { get; set; }
    }
}