using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpManagement.Services;
using EmpManagement.Models;

namespace EmpManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.AddEmployee(model);
                return RedirectToAction("Details", new { id = model.Eid });
            }
            else
            {
                throw new Exception();
            }
        }

        public ViewResult Details(int? id)
        {
            Employee model = _employeeRepository.GetEmployee(id ?? 1);

            return View(model);
        }

        public IActionResult AllEmployees()
        {
            var model = _employeeRepository.GetEmployees();
            return View(model);
        }

        [HttpGet]
        public ViewResult Update(int id)
        {
            Employee obj = _employeeRepository.GetEmployee(id);
            return View(obj);
        }

        [HttpPost]
        public ViewResult Update(Employee emp, int id)
        {
            emp.Eid = id;
            Employee empNew = _employeeRepository.Update(emp);
            var model = _employeeRepository.GetEmployees();
            return View("AllEmployees", model);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            _employeeRepository.Delete(id);
            var model = _employeeRepository.GetEmployees();
            return View("AllEmployees", model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
