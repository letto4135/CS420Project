using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using WaitStaff.Interfaces;
using WaitStaff.Models;
using WaitStaff.Models.ConsumedEvents;
using WaitStaff.Models.PublishedEvents;

namespace WaitStaff.Controllers
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
        public ActionResult TableSeated()
        {
            return new JsonResult(_eventBus.ConsumeEvent("tableSeated"));
        }

        [HttpGet]
        public ActionResult ReadyToPay()
        {
            return new JsonResult(_eventBus.ConsumeEvent("readyToPay"));
        }

        [HttpGet]
        public ActionResult DrinkReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("drinkReady"));
        }

        [HttpGet]
        public ActionResult FoodReady()
        {
            return new JsonResult(_eventBus.ConsumeEvent("foodReady"));
        }

        [HttpPost]
        public ActionResult HaveFoodOrder([FromBody] FoodOrder foodOrder)
        {
            foodOrder.TimeStamp = new DateTime();

            _eventBus.PublishEvent<FoodOrder>("foodOrder", foodOrder);

            return new JsonResult(foodOrder);
        }

        [HttpPost]
        public ActionResult HaveDrinkOrder([FromBody] DrinkOrder drinkOrder)
        {
            drinkOrder.TimeStamp = new DateTime();

            _eventBus.PublishEvent<DrinkOrder>("drinkOrder", drinkOrder);

            return new JsonResult(drinkOrder);
        }

        [HttpPost]
        public ActionResult CheckPaid([FromBody] CheckPaid checkPaid)
        {
            checkPaid.TimeStamp = new DateTime();

            _eventBus.PublishEvent<CheckPaid>("checkPaid", checkPaid);

            return new JsonResult(checkPaid);
        }
    }
}
