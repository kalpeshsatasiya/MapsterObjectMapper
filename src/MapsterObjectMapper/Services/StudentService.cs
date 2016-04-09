using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapsterObjectMapper.Models;

namespace MapsterObjectMapper.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> GetAll()
        {
            return new List<Student>()
             {
                new Student { StudentId=1, Name="Kalpesh", Email="satasiya.kalpesh2006@gmail.com", City="Ahmedabad" },
                new Student { StudentId=2, Name="Ajay", Email="ajay123@gmail.com", City="Ahmedabad" },
             };            
        }
    }
}
