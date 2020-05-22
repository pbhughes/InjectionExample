using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAPI.Interfaces;

namespace TestAPI.Services
{
    public class NameServiceB : IRepo
    {
        public string RepoName => "NameServiceB";

        public string GetName()
        {
            return "NameServiceB";
        }
    }
}
