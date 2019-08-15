using Dapper.Contrib.Extensions;
using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace Octobooks.Domain.Models
{
    [Table("Client")]
    public class Client : Entity
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
    }
}
