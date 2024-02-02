using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POC_3_Generic_Repos.Models;
using POC_3_Generic_Repos.Repository.Interface;

namespace POC_3_Generic_Repos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : GenericController<Student>
    {
        public StudentController(IStudentService<Student> genericService) : base(genericService) 
        {

            
        }
    }
}
