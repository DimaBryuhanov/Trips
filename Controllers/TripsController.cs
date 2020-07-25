using Microsoft.AspNetCore.Mvc;
using Trips.Data;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;
        public TripsController(ITripService service)
        {
            this._service = service;
        }

        [HttpGet("SingleTrip/{id")]
        public IActionResult SingleTrip(int id)
        {
            var trip = this._service.GetTripById(id);
            return Ok(trip);
        }

        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var AllTrips = this._service.GetAllTrips();
            return Ok(AllTrips);
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody] Trip trip)
        {
            if(trip != null)
            {
                this._service.AddTrip(trip);
            }
            return Ok();
        }

        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody] Trip trip)
        {
            this._service.Updatetrip(id, trip);
            return Ok(trip);
        }

        [HttpDelete("DeleteTrip/id")]
        public IActionResult DeleteTrip(int id)
        {
            this._service.Deletetrip(id);
            return Ok();
        }
    }
}