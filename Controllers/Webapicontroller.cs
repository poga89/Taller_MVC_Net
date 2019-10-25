using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_taller.Models;

namespace MVC_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebapiController : Controller
    {
        private readonly ILogger<WebapiController> _logger;

        public WebapiController(ILogger<WebapiController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/Webapi/Contactenos")] 
        public IActionResult Create(ContactsViewModel model) 
        { 
            if (model.name == null || model.email == null || model.asunto == null)
            {
                return NotFound();
            }
            return Accepted(new {message = model.name + "Enviado Gracias!!.."}); 
        } 
    }


}