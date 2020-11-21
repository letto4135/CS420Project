using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BusBoy.Interfaces;
using BusBoy.Models;
using BusBoy.Models.ConsumedEvents;
using BusBoy.Models.PublishedEvents;

namespace BusBoy.Controllers
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
        public ActionResult GetCheckPaid()
        {
            return new JsonResult(_eventBus.ConsumeEvent("checkPaid"));
        }

        [HttpPost]
        public ActionResult TableReady([FromBody] TableReady table)
        {
            table.TimeStamp = DateTime.Now;

            _eventBus.PublishEvent<TableReady>("tableReady", table);

            return new JsonResult(table);
        }
    }
}
