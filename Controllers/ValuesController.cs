using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Interfaces;
using TestAPI.Services;

namespace TestAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IEnumerable<IRepo> _repos;
        public ValuesController(IEnumerable<IRepo> repos)
        {
            _repos = repos;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var repo = _repos.Where(r => r.GetType() == typeof(NameServiceA)).First();
            var name = repo.GetName();
            return name;
        }
    }
}
