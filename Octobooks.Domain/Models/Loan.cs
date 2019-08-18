using Dapper.Contrib.Extensions;
using Octobooks.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Octobooks.Domain.Models
{
    [Table("Loan")]
    public class Loan : Entity
    {
        [Key]
        public int Id { get; set; }
        public int ClientID { get; set; }
        public int BookID { get; set; }
        public string ClientFeedback { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
