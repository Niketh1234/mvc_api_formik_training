using Microsoft.AspNetCore.Mvc;
using RestApiDemo.Models;
using RestApiDemo.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApiDemo.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        // GET: api/<StoresController>
        private readonly IStoreListRepository _repo;
        public StoresController(IStoreListRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return _repo.GetAllStores();
        }

        // GET api/<StoresController>/5
        [HttpGet("{id}")]
        public Store Get(int id)
        {
            return _repo.GetStoreById(id);
        }
        [HttpGet("location/{location}")]
        public IEnumerable<Store> Get(string location)
        {
            return _repo.GetStoreByLocation(location);
        }

        // POST api/<StoresController>
        [HttpPost]
        public void Post([FromBody] Store s)
        {
            _repo.Add(s);
        }

        // PUT api/<StoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Store s)
        {
            _repo.Update(id, s);
        }

        // DELETE api/<StoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
