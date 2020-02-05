using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class MeController : ControllerBase
    {
        private readonly ILogger<MeController> _logger;

        public MeController(ILogger<MeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var usr = User;
            var claims = usr.Claims.Select((c,i)=>
            {
                return new {Type = c.Type, Value = c.Value, 
                ValueType = c.ValueType, Issuer = c.Issuer};
            });
            return claims;
        }
    }
}
