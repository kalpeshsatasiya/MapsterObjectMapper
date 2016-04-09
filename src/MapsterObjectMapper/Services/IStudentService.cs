using MapsterObjectMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapsterObjectMapper.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
    }
}
