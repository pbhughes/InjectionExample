using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAPI.Interfaces
{
    public interface IRepo
    {
        public string RepoName { get; }
        public string GetName();
    }
}
