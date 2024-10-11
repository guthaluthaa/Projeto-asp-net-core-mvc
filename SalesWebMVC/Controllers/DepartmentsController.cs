using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department() { Id = Guid.NewGuid(), Name = "Tecnologia" });
            departments.Add(new Department() { Id = Guid.NewGuid(), Name = "Segurança" });

            return View(departments);
        }
    }
}
