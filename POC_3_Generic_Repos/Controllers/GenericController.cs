using Microsoft.AspNetCore.Mvc;
using POC_3_Generic_Repos.Repository.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POC_3_Generic_Repos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {
        private IStudentService<T> _genericService;

        public GenericController(IStudentService<T> studentService)
        {
            _genericService = studentService;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public List<T> Put(int id, [FromBody] T value)
        {
            var extInfo = _genericService.GetById(id);
            if (extInfo == null)
            {
                return new List<T>();
            }
            return _genericService.Update(value);
            
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
    }
}
