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
using RabbitMQ.Client;
using System.Text;
using RabbitMQ.Client.Events;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Cors;

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

        [HttpGet]
        public ActionResult GetReservation()
        {
            return new JsonResult(_eventBus.ConsumeEvent("newReservation"));
        }

        [HttpGet]
        public ActionResult TableReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("tableReady"));
        }

        [HttpPost]
        public ActionResult NewReservation([FromBody] ReservationTaken reservation)
        {
            reservation.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<ReservationTaken>("newReservation", reservation);

            return new JsonResult(reservation);
        }
       
        [HttpPost]
        public ActionResult TableSeated([FromBody] SeatedTable table)
        {
            table.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<SeatedTable>("seatedTable", table);

            return new JsonResult(table);
        }
    }
}
