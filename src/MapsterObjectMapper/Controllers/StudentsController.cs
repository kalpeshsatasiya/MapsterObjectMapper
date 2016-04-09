using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using MapsterObjectMapper.Models;
using MapsterObjectMapper.Services;
using MapsterObjectMapper.ViewModels;
using System.Collections.Generic;
using Mapster;

namespace MapsterObjectMapper.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: Students
        public IEnumerable<StudentViewModel> Index()
        {
            var students = _studentService.GetAll();
            return students.Adapt<List<Student>, IEnumerable<StudentViewModel>>();
        }
    }
}
