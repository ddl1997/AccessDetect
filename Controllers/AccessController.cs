using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AccessDetect.Models;

namespace AccessDetect.Controllers
{
    [Route("api/access")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        public AccessContext _accessContext;

        public AccessController(AccessContext accessContext)
        {
            _accessContext = accessContext;
        }

        [HttpGet]
        public bool Get()
        {
            string ip = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            Access a = new Access(Guid.NewGuid().ToString("N"), ip, DateTime.Now);
            _accessContext.Access.Add(a);
            return _accessContext.SaveChanges() > 0; 
        }

        [HttpGet("pv")]
        public int PvGet()
        {
            return _accessContext.Access.Count<Access>();
        }

        [HttpGet("uv")]
        public int UvGet()
        {
            var accesses = _accessContext.Access.Select(p => p.Ip);
            int count = accesses.ToList().Distinct().Count();
            return count;
        }
    }
}
