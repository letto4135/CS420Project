using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Host_ess.Interfaces;
using Host_ess.Models;
using Host_ess.Models.ConsumedEvents;
using Host_ess.Models.PublishedEvents;

namespace Host_ess.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SourceController : ControllerBase
    {
        IConfiguration _configuration;
        IEventBus _eventBus;

        public SourceController(IConfiguration configuration, IEventBus eventBus)
        {
            _eventBus = eventBus;
            _configuration = configuration;
            eventBus.HostName = _configuration["rabbitmqhostname"];
            eventBus.PortNumber = Convert.ToInt32(_configuration["rabbitmqport"]);
        }

        /*[HttpPost]
        public ActionResult HaveEmptyGlass([FromBody] EmptyGlass emptyGlass, int tableNumber, int seatNumber)
        {

            EmptyGlassEvent ege = new EmptyGlassEvent();
            ege.EmptyGlass = emptyGlass;
            ege.TableNumber = tableNumber;
            ege.SeatNumber = seatNumber;
            ege.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<EmptyGlassEvent>("emptyglass", ege);

            return new JsonResult(ege);
        }*/

        [HttpPost]
        public ActionResult HaveReservation([FromBody] Reservation reservation)
        {
            ReservationTaken resTaken = new ReservationTaken() 
            { 
                GuestCount=reservation.GuestCount,
                Name = reservation.Name,
                PhoneNumber = reservation.PhoneNumber,
                TimeStamp = new DateTime()
            };

            _eventBus.PublishEvent<ReservationTaken>("newReservation", resTaken);

            return new JsonResult(resTaken);
        }

        [HttpPost]
        public ActionResult TableReady([FromBody] TableReady ready)
        {
            SeatedTable seated = new SeatedTable()
            {
                TableNumber = ready.TableNumber,
                Guests = ready.SeatCount,
                TimeStamp = new DateTime()
            };

            _eventBus.PublishEvent<SeatedTable>("seatedTable", seated);

            return new JsonResult(seated);
        }
    }
}
