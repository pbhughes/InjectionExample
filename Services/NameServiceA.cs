using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Interfaces;

namespace TestAPI.Services
{
    public class NameServiceA : IRepo
    {
        public string RepoName => "NameServiceA";

        public string GetName()
        {
            return "NameA";
        }
    }
}
