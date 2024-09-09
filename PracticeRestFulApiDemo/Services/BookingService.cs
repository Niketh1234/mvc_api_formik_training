using PracticeRestFulApiDemo.Controllers;
using PracticeRestFulApiDemo.Models;

namespace PracticeRestFulApiDemo.Services
{
    public class BookingService
    {
        private readonly BookingContext _bookingContext = new BookingContext();
        public List<Details> GetAllBookings()
        {
            return _bookingContext.BookingDetails.ToList();
        }
        public bool AddBooking(Details d)
        {
            _bookingContext.BookingDetails.Add(d);
            _bookingContext.SaveChanges();
            return true;
        }
        public bool DeleteBooking(int id)
        {
           var v =  _bookingContext.BookingDetails.Find(id);
            if (v != null)
            {
                _bookingContext.BookingDetails.Remove(v);
                _bookingContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool UpdateBooking(int id, Details obj)
        {
            var v = _bookingContext.BookingDetails.Find(id);
            if (v != null)
            {
                v.Name = obj.Name;
                v.Price = obj.Price;
                _bookingContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
