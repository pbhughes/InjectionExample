﻿using System;
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
        public async Task<string> Get([FromQuery] string serviceName)
        {
            var repo = _repos.Where(r => r.RepoName.Contains( serviceName )).First();
            var name = repo.GetName();
            return name;
        }

        [HttpGet]
        [Route("{Service}")]
        public async Task<string> GetService([FromQuery] string serviceName){
            var repo = _repos.Where(r => r.RepoName.Contains( serviceName )).First();
            var name = $"{repo.GetName()} + {repo.GetType().ToString()}";
            return name;
        }

        [HttpPost]
        [Route("{Trigger}")]
        public async Task<string> TriggerService([FromQuery] string serviceName){
            var repo = _repos.Where(r => r.RepoName.Contains( serviceName )).First();
            var name = $"{repo.GetName()} + {repo.GetType().ToString()}";
            return name;
        }
    }
}
