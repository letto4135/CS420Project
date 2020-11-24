using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Bartender.Interfaces;
using Bartender.Models;
using Bartender.Models.PublishedEvents;
using Bartender.Models.ConsumedEvents;

namespace Bartender.Controllers
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
        public ActionResult GetDrinkOrder()
        {
            return new JsonResult(_eventBus.ConsumeEvent("drinkOrder"));
        }

        [HttpPost]
        public ActionResult DrinkReady([FromBody] DrinkReady drink)
        {
            drink.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<DrinkReady>("drinkReady", drink);

            return new JsonResult(drink);
        }
    }
}
