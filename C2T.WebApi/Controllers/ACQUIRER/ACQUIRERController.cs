using System.Collections.Generic;
using C2T.WebApi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace C2T.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ACQUIRERController : Controller
    {
        private IACQUIRERRepository ACQUIRERRepo { get; set; }

        public ACQUIRERController(IACQUIRERRepository _repo)
        {
            ACQUIRERRepo = _repo;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        
        [HttpGet("{id}", Name = "GetAllACQUIRER")]
        public IActionResult GetById(string id)
        {
            var item = ACQUIRERRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

    }
}
