using Microsoft.AspNetCore.Mvc;
using PracticeRestFulApiDemo.Models;
using PracticeRestFulApiDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticeRestFulApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        // GET: api/<BookingController>
        private readonly BookingService _bookingService = new BookingService();
        [HttpGet]
        public IEnumerable<Details> Get()
        {
            return _bookingService.GetAllBookings();
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingController>
        [HttpPost]
        public void Post([FromBody] Details value)
        {
            _bookingService.AddBooking(value);
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Details value)
        {
            _bookingService.UpdateBooking(id,value);
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bookingService.DeleteBooking(id);
        }
    }
}
