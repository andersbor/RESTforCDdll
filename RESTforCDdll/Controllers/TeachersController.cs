using Microsoft.AspNetCore.Mvc;
using SchoolLibrary;

namespace RESTforCDdll.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly TeacherRepository _teachersRepository;

        public TeachersController(TeacherRepository teachersRepository)
        {
            _teachersRepository = teachersRepository;
        }

        // GET: api/<TeachersController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _teachersRepository.Get();
        }

        // GET api/<TeachersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TeachersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TeachersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TeachersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
