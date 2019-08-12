using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Domain.Models
{
    public class Client : Entity
    {
        public string name { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
    }
}
