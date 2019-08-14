using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Octobooks.Domain.Models
{
    [Table("Client")]
    public class Client : Entity
    {
        public string name { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
    }
}
